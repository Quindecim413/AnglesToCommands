namespace AnglesToCommands
{
    partial class GravityControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GravityControl));
            this.buttonAccelConnect = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.clientControl1 = new NetManager.Client.ClientControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRightUpdate = new System.Windows.Forms.Button();
            this.buttonLeftUpdate = new System.Windows.Forms.Button();
            this.buttonBackwardUpdate = new System.Windows.Forms.Button();
            this.textBoxRightAngle = new System.Windows.Forms.TextBox();
            this.textBoxLeftAngle = new System.Windows.Forms.TextBox();
            this.textBoxBackwardAngle = new System.Windows.Forms.TextBox();
            this.textBoxRightVec = new System.Windows.Forms.TextBox();
            this.textBoxLeftVec = new System.Windows.Forms.TextBox();
            this.textBoxBackwardVec = new System.Windows.Forms.TextBox();
            this.textBoxForwardVec = new System.Windows.Forms.TextBox();
            this.buttonForwardUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxForwardAngle = new System.Windows.Forms.TextBox();
            this.numericUpDownVerificationAngle = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownVerificationTime = new System.Windows.Forms.NumericUpDown();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxCurVal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDownNotWorkingTimeout = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonShowProjection = new System.Windows.Forms.Button();
            this.buttonCharts = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVerificationAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVerificationTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNotWorkingTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAccelConnect
            // 
            this.buttonAccelConnect.Location = new System.Drawing.Point(356, 12);
            this.buttonAccelConnect.Name = "buttonAccelConnect";
            this.buttonAccelConnect.Size = new System.Drawing.Size(114, 23);
            this.buttonAccelConnect.TabIndex = 21;
            this.buttonAccelConnect.Text = "Подключить";
            this.buttonAccelConnect.UseVisualStyleBackColor = true;
            this.buttonAccelConnect.Click += new System.EventHandler(this.buttonAccelConnect_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(261, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(88, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "COM:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Право (8)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Лево (9)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Назад (7)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(5, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 27);
            this.label1.TabIndex = 15;
            this.label1.Text = "Вперёд (6)";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(13, 232);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(173, 23);
            this.buttonConnect.TabIndex = 14;
            this.buttonConnect.Text = "Подключить";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // clientControl1
            // 
            this.clientControl1.IPServer = ((System.Net.IPAddress)(resources.GetObject("clientControl1.IPServer")));
            this.clientControl1.Location = new System.Drawing.Point(12, 12);
            this.clientControl1.Name = "clientControl1";
            this.clientControl1.Size = new System.Drawing.Size(174, 213);
            this.clientControl1.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.buttonRightUpdate, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonLeftUpdate, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonBackwardUpdate, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxRightAngle, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxLeftAngle, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxBackwardAngle, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxRightVec, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxLeftVec, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxBackwardVec, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxForwardVec, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonForwardUpdate, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxForwardAngle, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(201, 53);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(521, 172);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // buttonRightUpdate
            // 
            this.buttonRightUpdate.Location = new System.Drawing.Point(259, 137);
            this.buttonRightUpdate.Name = "buttonRightUpdate";
            this.buttonRightUpdate.Size = new System.Drawing.Size(64, 23);
            this.buttonRightUpdate.TabIndex = 43;
            this.buttonRightUpdate.Text = "Обновить";
            this.buttonRightUpdate.UseVisualStyleBackColor = true;
            this.buttonRightUpdate.Click += new System.EventHandler(this.buttonRightUpdate_Click);
            // 
            // buttonLeftUpdate
            // 
            this.buttonLeftUpdate.Location = new System.Drawing.Point(259, 100);
            this.buttonLeftUpdate.Name = "buttonLeftUpdate";
            this.buttonLeftUpdate.Size = new System.Drawing.Size(64, 23);
            this.buttonLeftUpdate.TabIndex = 42;
            this.buttonLeftUpdate.Text = "Обновить";
            this.buttonLeftUpdate.UseVisualStyleBackColor = true;
            this.buttonLeftUpdate.Click += new System.EventHandler(this.buttonLeftUpdate_Click);
            // 
            // buttonBackwardUpdate
            // 
            this.buttonBackwardUpdate.Location = new System.Drawing.Point(259, 63);
            this.buttonBackwardUpdate.Name = "buttonBackwardUpdate";
            this.buttonBackwardUpdate.Size = new System.Drawing.Size(64, 23);
            this.buttonBackwardUpdate.TabIndex = 41;
            this.buttonBackwardUpdate.Text = "Обновить";
            this.buttonBackwardUpdate.UseVisualStyleBackColor = true;
            this.buttonBackwardUpdate.Click += new System.EventHandler(this.buttonBackwardUpdate_Click);
            // 
            // textBoxRightAngle
            // 
            this.textBoxRightAngle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxRightAngle.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxRightAngle.Location = new System.Drawing.Point(329, 137);
            this.textBoxRightAngle.Name = "textBoxRightAngle";
            this.textBoxRightAngle.ReadOnly = true;
            this.textBoxRightAngle.Size = new System.Drawing.Size(189, 20);
            this.textBoxRightAngle.TabIndex = 38;
            // 
            // textBoxLeftAngle
            // 
            this.textBoxLeftAngle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxLeftAngle.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxLeftAngle.Location = new System.Drawing.Point(329, 100);
            this.textBoxLeftAngle.Name = "textBoxLeftAngle";
            this.textBoxLeftAngle.ReadOnly = true;
            this.textBoxLeftAngle.Size = new System.Drawing.Size(189, 20);
            this.textBoxLeftAngle.TabIndex = 37;
            // 
            // textBoxBackwardAngle
            // 
            this.textBoxBackwardAngle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxBackwardAngle.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxBackwardAngle.Location = new System.Drawing.Point(329, 63);
            this.textBoxBackwardAngle.Name = "textBoxBackwardAngle";
            this.textBoxBackwardAngle.ReadOnly = true;
            this.textBoxBackwardAngle.Size = new System.Drawing.Size(189, 20);
            this.textBoxBackwardAngle.TabIndex = 36;
            // 
            // textBoxRightVec
            // 
            this.textBoxRightVec.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxRightVec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRightVec.Location = new System.Drawing.Point(72, 137);
            this.textBoxRightVec.Name = "textBoxRightVec";
            this.textBoxRightVec.ReadOnly = true;
            this.textBoxRightVec.Size = new System.Drawing.Size(181, 20);
            this.textBoxRightVec.TabIndex = 31;
            // 
            // textBoxLeftVec
            // 
            this.textBoxLeftVec.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxLeftVec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLeftVec.Location = new System.Drawing.Point(72, 100);
            this.textBoxLeftVec.Name = "textBoxLeftVec";
            this.textBoxLeftVec.ReadOnly = true;
            this.textBoxLeftVec.Size = new System.Drawing.Size(181, 20);
            this.textBoxLeftVec.TabIndex = 30;
            // 
            // textBoxBackwardVec
            // 
            this.textBoxBackwardVec.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxBackwardVec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBackwardVec.Location = new System.Drawing.Point(72, 63);
            this.textBoxBackwardVec.Name = "textBoxBackwardVec";
            this.textBoxBackwardVec.ReadOnly = true;
            this.textBoxBackwardVec.Size = new System.Drawing.Size(181, 20);
            this.textBoxBackwardVec.TabIndex = 29;
            // 
            // textBoxForwardVec
            // 
            this.textBoxForwardVec.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxForwardVec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxForwardVec.Location = new System.Drawing.Point(72, 26);
            this.textBoxForwardVec.Name = "textBoxForwardVec";
            this.textBoxForwardVec.ReadOnly = true;
            this.textBoxForwardVec.Size = new System.Drawing.Size(181, 20);
            this.textBoxForwardVec.TabIndex = 19;
            // 
            // buttonForwardUpdate
            // 
            this.buttonForwardUpdate.Location = new System.Drawing.Point(259, 26);
            this.buttonForwardUpdate.Name = "buttonForwardUpdate";
            this.buttonForwardUpdate.Size = new System.Drawing.Size(64, 23);
            this.buttonForwardUpdate.TabIndex = 21;
            this.buttonForwardUpdate.Text = "Обновить";
            this.buttonForwardUpdate.UseVisualStyleBackColor = true;
            this.buttonForwardUpdate.Click += new System.EventHandler(this.buttonForwardUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Ориентир";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 5);
            this.label8.Margin = new System.Windows.Forms.Padding(5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Бизисные значения (x,y,z)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(331, 5);
            this.label11.Margin = new System.Windows.Forms.Padding(5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(181, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Отклонение от ориентира (градус)";
            // 
            // textBoxForwardAngle
            // 
            this.textBoxForwardAngle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxForwardAngle.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxForwardAngle.Location = new System.Drawing.Point(329, 26);
            this.textBoxForwardAngle.Name = "textBoxForwardAngle";
            this.textBoxForwardAngle.ReadOnly = true;
            this.textBoxForwardAngle.Size = new System.Drawing.Size(189, 20);
            this.textBoxForwardAngle.TabIndex = 34;
            // 
            // numericUpDownVerificationAngle
            // 
            this.numericUpDownVerificationAngle.DecimalPlaces = 1;
            this.numericUpDownVerificationAngle.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownVerificationAngle.Location = new System.Drawing.Point(272, 274);
            this.numericUpDownVerificationAngle.Maximum = new decimal(new int[] {
            899,
            0,
            0,
            65536});
            this.numericUpDownVerificationAngle.Name = "numericUpDownVerificationAngle";
            this.numericUpDownVerificationAngle.Size = new System.Drawing.Size(65, 20);
            this.numericUpDownVerificationAngle.TabIndex = 23;
            this.numericUpDownVerificationAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownVerificationAngle.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 26);
            this.label9.TabIndex = 24;
            this.label9.Text = "Необходимая близость между векторами\r\nдля срабатывания команды (в градусах)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(238, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Удерживание команды для срабатывания (с)";
            // 
            // numericUpDownVerificationTime
            // 
            this.numericUpDownVerificationTime.DecimalPlaces = 1;
            this.numericUpDownVerificationTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownVerificationTime.Location = new System.Drawing.Point(273, 316);
            this.numericUpDownVerificationTime.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownVerificationTime.Name = "numericUpDownVerificationTime";
            this.numericUpDownVerificationTime.Size = new System.Drawing.Size(64, 20);
            this.numericUpDownVerificationTime.TabIndex = 26;
            this.numericUpDownVerificationTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownVerificationTime.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(460, 260);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(262, 106);
            this.textBoxLog.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(372, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Показания:";
            // 
            // textBoxCurVal
            // 
            this.textBoxCurVal.Location = new System.Drawing.Point(460, 234);
            this.textBoxCurVal.Name = "textBoxCurVal";
            this.textBoxCurVal.Size = new System.Drawing.Size(262, 20);
            this.textBoxCurVal.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(409, 260);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Лог:";
            // 
            // numericUpDownNotWorkingTimeout
            // 
            this.numericUpDownNotWorkingTimeout.DecimalPlaces = 1;
            this.numericUpDownNotWorkingTimeout.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownNotWorkingTimeout.Location = new System.Drawing.Point(273, 351);
            this.numericUpDownNotWorkingTimeout.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownNotWorkingTimeout.Name = "numericUpDownNotWorkingTimeout";
            this.numericUpDownNotWorkingTimeout.Size = new System.Drawing.Size(64, 20);
            this.numericUpDownNotWorkingTimeout.TabIndex = 32;
            this.numericUpDownNotWorkingTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownNotWorkingTimeout.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Таймаут после срабатывания";
            // 
            // buttonShowProjection
            // 
            this.buttonShowProjection.Location = new System.Drawing.Point(601, 12);
            this.buttonShowProjection.Name = "buttonShowProjection";
            this.buttonShowProjection.Size = new System.Drawing.Size(121, 23);
            this.buttonShowProjection.TabIndex = 33;
            this.buttonShowProjection.Text = "Проекция";
            this.buttonShowProjection.UseVisualStyleBackColor = true;
            this.buttonShowProjection.Click += new System.EventHandler(this.buttonShowProjection_Click);
            // 
            // buttonCharts
            // 
            this.buttonCharts.Location = new System.Drawing.Point(474, 12);
            this.buttonCharts.Name = "buttonCharts";
            this.buttonCharts.Size = new System.Drawing.Size(121, 23);
            this.buttonCharts.TabIndex = 34;
            this.buttonCharts.Text = "Графики";
            this.buttonCharts.UseVisualStyleBackColor = true;
            this.buttonCharts.Click += new System.EventHandler(this.buttonCharts_Click);
            // 
            // GravityControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 375);
            this.Controls.Add(this.buttonCharts);
            this.Controls.Add(this.buttonShowProjection);
            this.Controls.Add(this.numericUpDownNotWorkingTimeout);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxCurVal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.numericUpDownVerificationTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericUpDownVerificationAngle);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonAccelConnect);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.clientControl1);
            this.Name = "GravityControl";
            this.Text = " ";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVerificationAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVerificationTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNotWorkingTimeout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAccelConnect;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConnect;
        private NetManager.Client.ClientControl clientControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxForwardVec;
        private System.Windows.Forms.Button buttonRightUpdate;
        private System.Windows.Forms.Button buttonLeftUpdate;
        private System.Windows.Forms.Button buttonBackwardUpdate;
        private System.Windows.Forms.TextBox textBoxRightAngle;
        private System.Windows.Forms.TextBox textBoxLeftAngle;
        private System.Windows.Forms.TextBox textBoxBackwardAngle;
        private System.Windows.Forms.TextBox textBoxRightVec;
        private System.Windows.Forms.TextBox textBoxLeftVec;
        private System.Windows.Forms.TextBox textBoxBackwardVec;
        private System.Windows.Forms.Button buttonForwardUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxForwardAngle;
        private System.Windows.Forms.NumericUpDown numericUpDownVerificationAngle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDownVerificationTime;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxCurVal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDownNotWorkingTimeout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonShowProjection;
        private System.Windows.Forms.Button buttonCharts;
    }
}