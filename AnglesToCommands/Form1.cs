using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnglesToCommands
{
    public partial class Form1 : Form
    {
        Quaternion qRef;
        Quaternion lastq;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void UpdateRef()
        {
            qRef = lastq;
        }

        private void Update(Quaternion currentVal)
        {
            currentVal = Quaternion.Normalize(currentVal);

            lastq = currentVal;

            var qrel = currentVal * Quaternion.Inverse(qRef);
            var eRef = QuaternionToEuler(qRef);
            var eCur = QuaternionToEuler(currentVal);
            var eRel = QuaternionToEuler(qrel);
            SetQuaternion(valqX, valqY, valqZ, valqW, currentVal);
            SetQuaternion(valqrX, valqrY, valqrZ, valqW, qRef);
            SetQuaternion(valqoX, valqoY, valqoZ, valqoW, qrel);

            SetEuler(valX, valY, valZ, eCur);
            SetEuler(valrX, valrY, valrZ, eRef);
            SetEuler(valoX, valoY, valoZ, eRel);


        }

        private void SetEuler(Control XField, Control YField, Control ZField, Vector3 vals)
        {
            XField.Text = Math.Round(vals.X).ToString();
            YField.Text = Math.Round(vals.Y).ToString();
            ZField.Text = Math.Round(vals.Z).ToString();
        }
        private void SetQuaternion(Control XField, Control YField, Control ZField, Control WField, Quaternion q)
        {
            XField.Text = Math.Round(q.X, 2).ToString();
            YField.Text = Math.Round(q.Y, 2).ToString();
            ZField.Text = Math.Round(q.Z, 2).ToString();
            WField.Text = Math.Round(q.W, 2).ToString();
        }

        public static Vector3 QuaternionToEuler(Quaternion q)
        {
            Vector3 euler;
            
            // if the input quaternion is normalized, this is exactly one. Otherwise, this acts as a correction factor for the quaternion's not-normalizedness
            float unit = (q.X * q.X) + (q.Y * q.Y) + (q.Z * q.Z) + (q.W * q.W);

            // this will have a magnitude of 0.5 or greater if and only if this is a singularity case
            float test = q.X * q.W - q.Y * q.Z;

            if (test > 0.4995f * unit) // singularity at north pole
            {
                euler.X = (float)Math.PI / 2;
                euler.Y = 2f * (float)Math.Atan2(q.Y, q.X);
                euler.Z = 0;
            }
            else if (test < -0.4995f * unit) // singularity at south pole
            {
                euler.X = -(float)Math.PI / 2;
                euler.Y = -2f * (float)Math.Atan2(q.Y, q.X);
                euler.Z = 0;
            }
            else // no singularity - this is the majority of cases
            {
                euler.X = (float)Math.Asin(2f * (q.W * q.X - q.Y * q.Z));
                euler.Y = (float)Math.Atan2(2f * q.W * q.Y + 2f * q.Z * q.X, 1 - 2f * (q.X * q.X + q.Y * q.Y));
                euler.Z = (float)Math.Atan2(2f * q.W * q.Z + 2f * q.X * q.Y, 1 - 2f * (q.Z * q.Z + q.X * q.X));
            }

            // all the math so far has been done in radians. Before returning, we convert to degrees...
            euler *= 180 / (float)Math.PI;

            //...and then ensure the degree values are between 0 and 360
            euler.X %= 360;
            euler.Y %= 360;
            euler.Z %= 360;

            return euler;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            string lastSelected = comboBox1.SelectedItem.ToString();
            comboBox1.Items.Clear();
            for(int i = 0; i < ports.Length; i++)
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

        void AnnounceAccelData(Quaternion q)
        {
            Invoke(new Action(() => {
                Update(q);
            }));
        }

        private void StopAccel()
        {
            accelRunning = false;
            buttonAccelConnect.Text = "Подключить";
        }

        private void ConnectAccel()
        {
            var comport = comboBox1.SelectedIndex == -1 ? comboBox1.SelectedItem.ToString() : "";
            if (comport == "")
                return;
            accelRunning = true;
            buttonAccelConnect.Text = "Отключить";
            Thread t = new Thread(() => {
                try
                {
                    using (SerialPort p = new SerialPort(comport))
                    {
                        p.ReadTimeout = 100;
                        while (accelRunning)
                        {
                            var line = p.ReadLine();
                            if (line.StartsWith("quat"))
                            {
                                var parts = line.Split('\t');
                                Quaternion q = new Quaternion(
                                    float.Parse(parts[1]),
                                    float.Parse(parts[2]),
                                    float.Parse(parts[3]),
                                    float.Parse(parts[4])
                                    );
                                AnnounceAccelData(q);
                            }
                        }
                    }
                }catch(Exception e)
                {
                    Invoke(new Action(() => {
                        MessageBox.Show(e.Message + "\r\n" + e.StackTrace, "Считывание данных прервано");
                        StopAccel();
                    }));
                }
            });
            t.Start();
        }
    }
}
