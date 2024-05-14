namespace AnglesToCommands
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.clientControl1 = new NetManager.Client.ClientControl();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonAccelConnect = new System.Windows.Forms.Button();
            this.numericUpDownForward = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBackward = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLeft = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRight = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.valqX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.valqY = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.valqZ = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.valqW = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.valZ = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.valY = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.valX = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.valrZ = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.valrY = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.valrX = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.valqrW = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.valqrZ = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.valqrY = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.valqrX = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.valoZ = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.valoY = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.valoX = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.valqoW = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.valqoZ = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.valqoY = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.valqoX = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBackward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRight)).BeginInit();
            this.SuspendLayout();
            // 
            // clientControl1
            // 
            this.clientControl1.IPServer = ((System.Net.IPAddress)(resources.GetObject("clientControl1.IPServer")));
            this.clientControl1.Location = new System.Drawing.Point(12, 12);
            this.clientControl1.Name = "clientControl1";
            this.clientControl1.Size = new System.Drawing.Size(174, 213);
            this.clientControl1.TabIndex = 0;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(13, 232);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(173, 23);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Подключить";
            this.buttonConnect.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вперёд (1)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Назад (2)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Лево (3)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Право (4)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "COM:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(361, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(88, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonAccelConnect
            // 
            this.buttonAccelConnect.Location = new System.Drawing.Point(456, 12);
            this.buttonAccelConnect.Name = "buttonAccelConnect";
            this.buttonAccelConnect.Size = new System.Drawing.Size(114, 23);
            this.buttonAccelConnect.TabIndex = 8;
            this.buttonAccelConnect.Text = "Подключить";
            this.buttonAccelConnect.UseVisualStyleBackColor = true;
            this.buttonAccelConnect.Click += new System.EventHandler(this.buttonAccelConnect_Click);
            // 
            // numericUpDownForward
            // 
            this.numericUpDownForward.DecimalPlaces = 1;
            this.numericUpDownForward.Location = new System.Drawing.Point(354, 74);
            this.numericUpDownForward.Name = "numericUpDownForward";
            this.numericUpDownForward.Size = new System.Drawing.Size(76, 20);
            this.numericUpDownForward.TabIndex = 9;
            // 
            // numericUpDownBackward
            // 
            this.numericUpDownBackward.DecimalPlaces = 1;
            this.numericUpDownBackward.Location = new System.Drawing.Point(354, 271);
            this.numericUpDownBackward.Name = "numericUpDownBackward";
            this.numericUpDownBackward.Size = new System.Drawing.Size(76, 20);
            this.numericUpDownBackward.TabIndex = 10;
            // 
            // numericUpDownLeft
            // 
            this.numericUpDownLeft.DecimalPlaces = 1;
            this.numericUpDownLeft.Location = new System.Drawing.Point(226, 177);
            this.numericUpDownLeft.Name = "numericUpDownLeft";
            this.numericUpDownLeft.Size = new System.Drawing.Size(76, 20);
            this.numericUpDownLeft.TabIndex = 11;
            // 
            // numericUpDownRight
            // 
            this.numericUpDownRight.DecimalPlaces = 1;
            this.numericUpDownRight.Location = new System.Drawing.Point(480, 186);
            this.numericUpDownRight.Name = "numericUpDownRight";
            this.numericUpDownRight.Size = new System.Drawing.Size(76, 20);
            this.numericUpDownRight.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Показания";
            // 
            // valqX
            // 
            this.valqX.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.valqX.Location = new System.Drawing.Point(195, 322);
            this.valqX.Name = "valqX";
            this.valqX.ReadOnly = true;
            this.valqX.Size = new System.Drawing.Size(60, 20);
            this.valqX.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "X =";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(266, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Y =";
            // 
            // valqY
            // 
            this.valqY.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.valqY.Location = new System.Drawing.Point(295, 322);
            this.valqY.Name = "valqY";
            this.valqY.ReadOnly = true;
            this.valqY.Size = new System.Drawing.Size(60, 20);
            this.valqY.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(370, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Z =";
            // 
            // valqZ
            // 
            this.valqZ.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.valqZ.Location = new System.Drawing.Point(399, 322);
            this.valqZ.Name = "valqZ";
            this.valqZ.ReadOnly = true;
            this.valqZ.Size = new System.Drawing.Size(60, 20);
            this.valqZ.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(481, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "W =";
            // 
            // valqW
            // 
            this.valqW.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.valqW.Location = new System.Drawing.Point(510, 322);
            this.valqW.Name = "valqW";
            this.valqW.ReadOnly = true;
            this.valqW.Size = new System.Drawing.Size(60, 20);
            this.valqW.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(370, 351);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Z =";
            // 
            // valZ
            // 
            this.valZ.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.valZ.Location = new System.Drawing.Point(399, 348);
            this.valZ.Name = "valZ";
            this.valZ.ReadOnly = true;
            this.valZ.Size = new System.Drawing.Size(60, 20);
            this.valZ.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(266, 351);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Y =";
            // 
            // valY
            // 
            this.valY.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.valY.Location = new System.Drawing.Point(295, 348);
            this.valY.Name = "valY";
            this.valY.ReadOnly = true;
            this.valY.Size = new System.Drawing.Size(60, 20);
            this.valY.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(166, 351);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "X =";
            // 
            // valX
            // 
            this.valX.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.valX.Location = new System.Drawing.Point(195, 348);
            this.valX.Name = "valX";
            this.valX.ReadOnly = true;
            this.valX.Size = new System.Drawing.Size(60, 20);
            this.valX.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(70, 325);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Quaternion:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(98, 351);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Euler:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(78, 407);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 45;
            this.label16.Text = "Euler Ref:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(50, 378);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 13);
            this.label17.TabIndex = 44;
            this.label17.Text = "Quaternion Ref:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(370, 404);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 13);
            this.label18.TabIndex = 43;
            this.label18.Text = "Z =";
            // 
            // valrZ
            // 
            this.valrZ.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.valrZ.Location = new System.Drawing.Point(399, 401);
            this.valrZ.Name = "valrZ";
            this.valrZ.ReadOnly = true;
            this.valrZ.Size = new System.Drawing.Size(60, 20);
            this.valrZ.TabIndex = 42;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(266, 404);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 13);
            this.label19.TabIndex = 41;
            this.label19.Text = "Y =";
            // 
            // valrY
            // 
            this.valrY.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.valrY.Location = new System.Drawing.Point(295, 401);
            this.valrY.Name = "valrY";
            this.valrY.ReadOnly = true;
            this.valrY.Size = new System.Drawing.Size(60, 20);
            this.valrY.TabIndex = 40;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(166, 404);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(23, 13);
            this.label20.TabIndex = 39;
            this.label20.Text = "X =";
            // 
            // valrX
            // 
            this.valrX.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.valrX.Location = new System.Drawing.Point(195, 401);
            this.valrX.Name = "valrX";
            this.valrX.ReadOnly = true;
            this.valrX.Size = new System.Drawing.Size(60, 20);
            this.valrX.TabIndex = 38;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(481, 378);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(27, 13);
            this.label21.TabIndex = 37;
            this.label21.Text = "W =";
            // 
            // valqrW
            // 
            this.valqrW.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.valqrW.Location = new System.Drawing.Point(510, 375);
            this.valqrW.Name = "valqrW";
            this.valqrW.ReadOnly = true;
            this.valqrW.Size = new System.Drawing.Size(60, 20);
            this.valqrW.TabIndex = 36;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(370, 378);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(23, 13);
            this.label22.TabIndex = 35;
            this.label22.Text = "Z =";
            // 
            // valqrZ
            // 
            this.valqrZ.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.valqrZ.Location = new System.Drawing.Point(399, 375);
            this.valqrZ.Name = "valqrZ";
            this.valqrZ.ReadOnly = true;
            this.valqrZ.Size = new System.Drawing.Size(60, 20);
            this.valqrZ.TabIndex = 34;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(266, 378);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(23, 13);
            this.label23.TabIndex = 33;
            this.label23.Text = "Y =";
            // 
            // valqrY
            // 
            this.valqrY.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.valqrY.Location = new System.Drawing.Point(295, 375);
            this.valqrY.Name = "valqrY";
            this.valqrY.ReadOnly = true;
            this.valqrY.Size = new System.Drawing.Size(60, 20);
            this.valqrY.TabIndex = 32;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(166, 378);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(23, 13);
            this.label24.TabIndex = 31;
            this.label24.Text = "X =";
            // 
            // valqrX
            // 
            this.valqrX.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.valqrX.Location = new System.Drawing.Point(195, 375);
            this.valqrX.Name = "valqrX";
            this.valqrX.ReadOnly = true;
            this.valqrX.Size = new System.Drawing.Size(60, 20);
            this.valqrX.TabIndex = 30;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(68, 459);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(64, 13);
            this.label25.TabIndex = 61;
            this.label25.Text = "Euler Origin:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(40, 433);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(92, 13);
            this.label26.TabIndex = 60;
            this.label26.Text = "Quaternion Origin:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(370, 455);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(23, 13);
            this.label27.TabIndex = 59;
            this.label27.Text = "Z =";
            // 
            // valoZ
            // 
            this.valoZ.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.valoZ.Location = new System.Drawing.Point(399, 452);
            this.valoZ.Name = "valoZ";
            this.valoZ.ReadOnly = true;
            this.valoZ.Size = new System.Drawing.Size(60, 20);
            this.valoZ.TabIndex = 58;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(266, 455);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(23, 13);
            this.label28.TabIndex = 57;
            this.label28.Text = "Y =";
            // 
            // valoY
            // 
            this.valoY.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.valoY.Location = new System.Drawing.Point(295, 452);
            this.valoY.Name = "valoY";
            this.valoY.ReadOnly = true;
            this.valoY.Size = new System.Drawing.Size(60, 20);
            this.valoY.TabIndex = 56;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(166, 455);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(23, 13);
            this.label29.TabIndex = 55;
            this.label29.Text = "X =";
            // 
            // valoX
            // 
            this.valoX.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.valoX.Location = new System.Drawing.Point(195, 452);
            this.valoX.Name = "valoX";
            this.valoX.ReadOnly = true;
            this.valoX.Size = new System.Drawing.Size(60, 20);
            this.valoX.TabIndex = 54;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(481, 429);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(27, 13);
            this.label30.TabIndex = 53;
            this.label30.Text = "W =";
            // 
            // valqoW
            // 
            this.valqoW.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.valqoW.Location = new System.Drawing.Point(510, 426);
            this.valqoW.Name = "valqoW";
            this.valqoW.ReadOnly = true;
            this.valqoW.Size = new System.Drawing.Size(60, 20);
            this.valqoW.TabIndex = 52;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(370, 429);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(23, 13);
            this.label31.TabIndex = 51;
            this.label31.Text = "Z =";
            // 
            // valqoZ
            // 
            this.valqoZ.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.valqoZ.Location = new System.Drawing.Point(399, 426);
            this.valqoZ.Name = "valqoZ";
            this.valqoZ.ReadOnly = true;
            this.valqoZ.Size = new System.Drawing.Size(60, 20);
            this.valqoZ.TabIndex = 50;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(266, 429);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(23, 13);
            this.label32.TabIndex = 49;
            this.label32.Text = "Y =";
            // 
            // valqoY
            // 
            this.valqoY.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.valqoY.Location = new System.Drawing.Point(295, 426);
            this.valqoY.Name = "valqoY";
            this.valqoY.ReadOnly = true;
            this.valqoY.Size = new System.Drawing.Size(60, 20);
            this.valqoY.TabIndex = 48;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(166, 429);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(23, 13);
            this.label33.TabIndex = 47;
            this.label33.Text = "X =";
            // 
            // valqoX
            // 
            this.valqoX.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.valqoX.Location = new System.Drawing.Point(195, 426);
            this.valqoX.Name = "valqoX";
            this.valqoX.ReadOnly = true;
            this.valqoX.Size = new System.Drawing.Size(60, 20);
            this.valqoX.TabIndex = 46;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 485);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.valoZ);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.valoY);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.valoX);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.valqoW);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.valqoZ);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.valqoY);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.valqoX);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.valrZ);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.valrY);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.valrX);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.valqrW);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.valqrZ);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.valqrY);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.valqrX);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.valZ);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.valY);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.valX);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.valqW);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.valqZ);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.valqY);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.valqX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownRight);
            this.Controls.Add(this.numericUpDownLeft);
            this.Controls.Add(this.numericUpDownBackward);
            this.Controls.Add(this.numericUpDownForward);
            this.Controls.Add(this.buttonAccelConnect);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.clientControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBackward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NetManager.Client.ClientControl clientControl1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonAccelConnect;
        private System.Windows.Forms.NumericUpDown numericUpDownForward;
        private System.Windows.Forms.NumericUpDown numericUpDownBackward;
        private System.Windows.Forms.NumericUpDown numericUpDownLeft;
        private System.Windows.Forms.NumericUpDown numericUpDownRight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox valqX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox valqY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox valqZ;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox valqW;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox valZ;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox valY;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox valX;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox valrZ;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox valrY;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox valrX;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox valqrW;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox valqrZ;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox valqrY;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox valqrX;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox valoZ;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox valoY;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox valoX;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox valqoW;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox valqoZ;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox valqoY;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox valqoX;
    }
}

