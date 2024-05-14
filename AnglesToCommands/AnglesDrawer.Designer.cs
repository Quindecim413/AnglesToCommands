namespace AnglesToCommands
{
    partial class AnglesDrawer
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRotationAngle = new System.Windows.Forms.TextBox();
            this.trackBarRotationAngle = new System.Windows.Forms.TrackBar();
            this.buttonFixCenter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxFlipCoordinates = new System.Windows.Forms.CheckBox();
            this.trackBarZoom = new System.Windows.Forms.TrackBar();
            this.textBoxZoom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotationAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 75);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(859, 338);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.875F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.125F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.15981F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.84019F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(859, 413);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxRotationAngle, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.trackBarRotationAngle, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonFixCenter, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxFlipCoordinates, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.trackBarZoom, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxZoom, 3, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(859, 75);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Угол поворота";
            // 
            // textBoxRotationAngle
            // 
            this.textBoxRotationAngle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxRotationAngle.Location = new System.Drawing.Point(722, 3);
            this.textBoxRotationAngle.Name = "textBoxRotationAngle";
            this.textBoxRotationAngle.ReadOnly = true;
            this.textBoxRotationAngle.Size = new System.Drawing.Size(74, 20);
            this.textBoxRotationAngle.TabIndex = 1;
            this.textBoxRotationAngle.Text = "0";
            this.textBoxRotationAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trackBarRotationAngle
            // 
            this.trackBarRotationAngle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarRotationAngle.LargeChange = 1;
            this.trackBarRotationAngle.Location = new System.Drawing.Point(223, 3);
            this.trackBarRotationAngle.Maximum = 180;
            this.trackBarRotationAngle.Minimum = -180;
            this.trackBarRotationAngle.Name = "trackBarRotationAngle";
            this.trackBarRotationAngle.Size = new System.Drawing.Size(493, 24);
            this.trackBarRotationAngle.TabIndex = 4;
            this.trackBarRotationAngle.TickFrequency = 45;
            this.trackBarRotationAngle.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarRotationAngle.Scroll += new System.EventHandler(this.trackBarRotationAngle_Scroll);
            // 
            // buttonFixCenter
            // 
            this.buttonFixCenter.Location = new System.Drawing.Point(3, 3);
            this.buttonFixCenter.Name = "buttonFixCenter";
            this.buttonFixCenter.Size = new System.Drawing.Size(114, 23);
            this.buttonFixCenter.TabIndex = 1;
            this.buttonFixCenter.Text = "Обновить центр";
            this.buttonFixCenter.UseVisualStyleBackColor = true;
            this.buttonFixCenter.Click += new System.EventHandler(this.buttonFixCenter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Зум";
            // 
            // checkBoxFlipCoordinates
            // 
            this.checkBoxFlipCoordinates.AutoSize = true;
            this.checkBoxFlipCoordinates.Location = new System.Drawing.Point(5, 38);
            this.checkBoxFlipCoordinates.Margin = new System.Windows.Forms.Padding(5, 8, 0, 0);
            this.checkBoxFlipCoordinates.Name = "checkBoxFlipCoordinates";
            this.checkBoxFlipCoordinates.Size = new System.Drawing.Size(52, 17);
            this.checkBoxFlipCoordinates.TabIndex = 3;
            this.checkBoxFlipCoordinates.Text = "Flip X";
            this.checkBoxFlipCoordinates.UseVisualStyleBackColor = true;
            // 
            // trackBarZoom
            // 
            this.trackBarZoom.LargeChange = 1;
            this.trackBarZoom.Location = new System.Drawing.Point(223, 33);
            this.trackBarZoom.Maximum = 50;
            this.trackBarZoom.Minimum = 10;
            this.trackBarZoom.Name = "trackBarZoom";
            this.trackBarZoom.Size = new System.Drawing.Size(493, 39);
            this.trackBarZoom.TabIndex = 6;
            this.trackBarZoom.TickFrequency = 45;
            this.trackBarZoom.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarZoom.Value = 10;
            this.trackBarZoom.Scroll += new System.EventHandler(this.trackBarZoom_Scroll);
            // 
            // textBoxZoom
            // 
            this.textBoxZoom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxZoom.Location = new System.Drawing.Point(722, 33);
            this.textBoxZoom.Name = "textBoxZoom";
            this.textBoxZoom.ReadOnly = true;
            this.textBoxZoom.Size = new System.Drawing.Size(74, 20);
            this.textBoxZoom.TabIndex = 7;
            this.textBoxZoom.Text = "1";
            this.textBoxZoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AnglesDrawer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 413);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AnglesDrawer";
            this.Text = "AnglesDrawer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotationAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonFixCenter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRotationAngle;
        private System.Windows.Forms.TrackBar trackBarRotationAngle;
        private System.Windows.Forms.CheckBox checkBoxFlipCoordinates;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarZoom;
        private System.Windows.Forms.TextBox textBoxZoom;
    }
}