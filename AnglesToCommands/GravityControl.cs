using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Numerics;
using System.Threading;
using System.Windows.Forms;

namespace AnglesToCommands
{
    public partial class GravityControl : Form
    {
        public GravityControl()
        {
            InitializeComponent();
            VecForward = new Vector3(0, 0, 1);
            VecBackward = new Vector3(0, 0, 1);
            VecLeft = new Vector3(0, 0, 1);
            VecRight = new Vector3(0, 0, 1);
            comboBox1_SelectedIndexChanged(null, null);
            buttonForwardUpdate_Click(null, null);
            buttonBackwardUpdate_Click(null, null);
            buttonLeftUpdate_Click(null, null);
            buttonRightUpdate_Click(null, null);
        }

        #region ui handling
        Control lastSuccess;
        DateTime lastSuccessTime = DateTime.Now;
        private bool CheckControlCanbeSet(Control c)
        {
            return !(c == lastSuccess 
                && (DateTime.Now - lastSuccessTime).TotalSeconds < Math.Max(VerificationTime / 4, 1));
        }
        CommandState[] commands = new CommandState[4] { 0, 0, 0, 0 };
        private void SetCommandSuccess(Control c, int command)
        {
            lastSuccess = c;
            lastSuccessTime = DateTime.Now;
            c.BackColor = Color.Green;
            commands[command - 1] = CommandState.Selected;
        }
        private void SetCommandProcessing(Control c, int command)
        {
            if (!CheckControlCanbeSet(c))
                return;
            c.BackColor = Color.Yellow;
            commands[command - 1] = CommandState.InProgress;
        }
        private void SetCommandUnclear(Control c, int command)
        {
            if (!CheckControlCanbeSet(c))
                return;
            c.BackColor = Color.LightGray;
            commands[command - 1] = CommandState.Unclear;
        }
        private void SetCommandNotSet(Control c, int command)
        {
            if (!CheckControlCanbeSet(c))
                return;
            c.BackColor = Color.White;
            commands[command - 1] = CommandState.NotSelected;
        }

        private void SetVectorVals(Control c, Vector3 v)
        {
            var st = Math.Round(v.X, 2) + ";" + Math.Round(v.Y, 2) + ";" + Math.Round(v.Z);
            c.Text = st;
        }

        private void SetAngleBetweenVectors(Control c, double angle)
        {
            c.Text = Math.Round(angle, 2).ToString();
        }
        #endregion

        #region networking
        private void SendToRecievers(int commandCode)
        {
            //if (!clientControl1.Client.IsRunning)
            //    return;
            //byte[] data = new byte[2]{
            //   (byte)NetManager.MessageCodes.Command,
            //   (byte)command
            //};
            

            //var addresses = clientControl1.CheckedClientAddresses;
            //clientControl1.Client.SendData(addresses, data);

            if (clientControl1.Client.IsRunning)
            {
                string command = (commandCode + 5).ToString();

                byte[] m_SendData = new byte[4 + 2 * command.Length];
                Array.Copy(BitConverter.GetBytes(NetManager.MessageCodes.Command), m_SendData, 4);

                for (int i = 0; i < command.Length; i++)
                {
                    var bts = BitConverter.GetBytes(command[i]);
                    Array.Copy(bts, 0, m_SendData, 4 + i * 2, 2);
                }
            }
        }
        #endregion

        #region commands update
        Vector3 lastGravityVec = new Vector3(0, 0, 1);
        List<Tuple<int, DateTime>> commandsExecuted = new List<Tuple<int, DateTime>>();

        DateTime lastSend = DateTime.Now;
        DateTime lastRecieve = DateTime.Now;
        private void Update(Vector3 gravityVec)
        {
            lastGravityVec = gravityVec;
            SetVectorVals(textBoxCurVal, gravityVec);


            SetAngleBetweenVectors(textBoxForwardAngle, AngleBetween(VecForward, gravityVec));
            SetAngleBetweenVectors(textBoxBackwardAngle, AngleBetween(VecBackward, gravityVec));
            SetAngleBetweenVectors(textBoxLeftAngle, AngleBetween(VecLeft, gravityVec));
            SetAngleBetweenVectors(textBoxRightAngle, AngleBetween(VecRight, gravityVec));
            bool[] flags = new bool[4];
            CheckoutVectors(gravityVec, VerificationAngle, out flags[0], out flags[1], out flags[2], out flags[3]);

            DateTime now = DateTime.Now;
            double timeVerification = VerificationTime / 0.95;
            double recieveFreq = 1 / (now - lastRecieve).TotalSeconds;
            lastRecieve = now;
            int[] codes = new int[4] { 1, 2, 3, 4 };
            //int[] codes = new int[4] { 6, 7, 8, 9 };
            if (flags.Select(el => el ? 1 : 0).Sum() == 1)
            for (int i = 0; i < 4; i++)
            {
                if (flags[i])
                {
                    commandsExecuted.Add(Tuple.Create(codes[i], now));
                }
            }

            if ((now - lastSend).TotalSeconds < NotWorkingTimeout)
            {
                commandsExecuted.Clear();
            }

            

            commandsExecuted = commandsExecuted.Where(el => (now - el.Item2).TotalSeconds <= timeVerification).ToList();

            var forwardCommands = commandsExecuted.Where(el => el.Item1 == codes[0]).ToList();
            int forwardPortion = commandsExecuted.Count(el => el.Item1 == codes[0]);// / (double)commandsExecuted.Count;
            int backwardPortion = commandsExecuted.Count(el => el.Item1 == codes[1]);// / (double)commandsExecuted.Count;
            int leftPortion = commandsExecuted.Count(el => el.Item1 == codes[3]);// / (double)commandsExecuted.Count;
            int rightPortion = commandsExecuted.Count(el => el.Item1 == codes[2]);// / (double)commandsExecuted.Count;

            
            SetFlagAndSendIfPossible(codes[0], forwardPortion, recieveFreq, textBoxForwardAngle);
            SetFlagAndSendIfPossible(codes[1], backwardPortion, recieveFreq, textBoxBackwardAngle);
            SetFlagAndSendIfPossible(codes[3], leftPortion, recieveFreq, textBoxLeftAngle);
            SetFlagAndSendIfPossible(codes[2], rightPortion, recieveFreq, textBoxRightAngle);
        }

        private void SetFlagAndSendIfPossible(int command, int commandPortion, double recieveFreq, Control c)
        {
            double commandExecutedThreshold = 0.95;
            double commandProcessingThreshold = 0.4;
            double commandUnderAssumptionThreshold = 0.2;

            double verTime = VerificationTime / commandExecutedThreshold;
            double requiredNumberOfSamplesInVerificationTime = verTime * recieveFreq;
            double density = commandPortion / (requiredNumberOfSamplesInVerificationTime);

            if (density >= commandExecutedThreshold)
            {
                SetCommandSuccess(c, command);
                commandsExecuted.Clear();
                lastSend = DateTime.Now;
                Log("Sending command: " + (command+5));
                SendToRecievers(command);
            }
            else if (density >= commandProcessingThreshold)
            {
                SetCommandProcessing(c, command);
            }
            else if (density >= commandUnderAssumptionThreshold)
            {
                SetCommandUnclear(c, command);
            }
            else
            {
                SetCommandNotSet(c, command);
            }
        }

        private void Log(string text)
        {
            textBoxLog.Text = text + "\r\n" +textBoxLog.Text;
        }

        private void CheckoutVectors(Vector3 g, double verificationAngle, out bool okForward, out bool okBackward, out bool okLeft, out bool okRight)
        {
            okForward = Math.Abs(AngleBetween(g, VecForward)) <= verificationAngle;
            okBackward = Math.Abs(AngleBetween(g, VecBackward)) <= verificationAngle;
            okLeft = Math.Abs(AngleBetween(g, VecLeft)) <= verificationAngle;
            okRight = Math.Abs(AngleBetween(g, VecRight)) <= verificationAngle;
        }
        private static double AngleBetween(Vector3 v1, Vector3 v2)
        {
            var cos = Vector3.Dot(v1, v2) / v1.Length() / v2.Length();
            double angle = Math.Acos(cos) / Math.PI * 180;
            return angle;
        }
        Vector3 VecForward;
        Vector3 VecBackward;
        Vector3 VecLeft;
        Vector3 VecRight;
        double VerificationAngle
        {
            get
            {
                return (double)numericUpDownVerificationAngle.Value;
            }
        }
        double VerificationTime
        {
            get
            {
                return (double)numericUpDownVerificationTime.Value;
            }
        }
        double NotWorkingTimeout
        {
            get
            {
                return (double)numericUpDownNotWorkingTimeout.Value;
            }
        }
        #endregion

        #region accelerometr
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            string lastSelected = (comboBox1.SelectedItem??"").ToString();
            comboBox1.Items.Clear();
            for (int i = 0; i < ports.Length; i++)
            {
                var p = ports[i];
                comboBox1.Items.Add(p);
                if (p == lastSelected)
                {
                    comboBox1.SelectedIndex = i;
                }
            }
        }

        bool accelRunning = false;
        private void buttonAccelConnect_Click(object sender, EventArgs e)
        {
            if (accelRunning)
            {
                StopAccel();
            }
            else
            {
                ConnectAccel();
            }
        }

        void AnnounceAccelData(Vector3 gravityVec)
        {
            Invoke(new Action(() => {
                Update(gravityVec);
                drawer?.Update(gravityVec, VecForward, VecBackward, VecLeft, VecRight,
                    commands[0], commands[1], commands[2], commands[3], VerificationAngle);
                charts?.Update(gravityVec);
            }));
        }

        private void StopAccel()
        {
            accelRunning = false;
            buttonAccelConnect.Text = "Подключить";
        }

        private void ConnectAccel()
        {
            var comport = comboBox1.SelectedIndex == -1 ? "" : comboBox1.SelectedItem.ToString();
            if (comport == "")
                return;
            accelRunning = true;
            buttonAccelConnect.Text = "Отключить";
            Thread t = new Thread(() => {
                try
                {
                    using (SerialPort p = new SerialPort(comport))
                    {
                        p.Open();
                        
                        while (accelRunning)
                        {
                            var line = p.ReadLine();
                            p.ReadTimeout = 100;
                            if (line.StartsWith("g"))
                            {
                                var parts = line.Split('\t');
                                parts[3].Replace('\r', '0');
                                Vector3 g = new Vector3(
                                    float.Parse(parts[1], CultureInfo.InvariantCulture),
                                    float.Parse(parts[2], CultureInfo.InvariantCulture),
                                    float.Parse(parts[3], CultureInfo.InvariantCulture)
                                    );
                                AnnounceAccelData(g);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    if (!IsDisposed)
                        try
                        {
                            Invoke(new Action(() => {
                                MessageBox.Show(e.Message + "\r\n" + e.StackTrace, "Считывание данных прервано");
                                StopAccel();
                            }));
                        }
                        catch { }
                }
            });
            t.Start();
        }
        #endregion

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (!clientControl1.Client.IsRunning)
            {
                clientControl1.Client.StartClient();
                buttonConnect.Text = "Отключить";
            }
            else
            {
                clientControl1.Client.StopClient();
                buttonAccelConnect.Text = "Подключить";
            }
        }

        private void buttonForwardUpdate_Click(object sender, EventArgs e)
        {
            VecForward = lastGravityVec;
            SetVectorVals(textBoxForwardVec, VecForward);
        }

        private void buttonBackwardUpdate_Click(object sender, EventArgs e)
        {
            VecBackward = lastGravityVec;
            SetVectorVals(textBoxBackwardVec, VecBackward);
        }

        private void buttonLeftUpdate_Click(object sender, EventArgs e)
        {
            VecLeft = lastGravityVec;
            SetVectorVals(textBoxLeftVec, VecLeft);
        }

        private void buttonRightUpdate_Click(object sender, EventArgs e)
        {
            VecRight = lastGravityVec;
            SetVectorVals(textBoxRightVec, VecRight);
        }

        AnglesDrawer drawer;
        Charts charts;

        private void buttonShowProjection_Click(object sender, EventArgs e)
        {
            if(drawer == null)
            {
                drawer = new AnglesDrawer();
            }
            drawer.Show();
        }

        private void buttonCharts_Click(object sender, EventArgs e)
        {
            if (charts == null)
            {
                charts = new Charts();
            }
            charts.Show();
        }
    }
}
