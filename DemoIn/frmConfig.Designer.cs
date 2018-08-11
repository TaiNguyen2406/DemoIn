namespace DemoIn
{
    partial class frmConfig
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
            this.components = new System.ComponentModel.Container();
            this.btClose = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btTestCom = new System.Windows.Forms.Button();
            this.tbRevBThreshold = new System.Windows.Forms.NumericUpDown();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.tbStopBits = new System.Windows.Forms.NumericUpDown();
            this.tbDataBits = new System.Windows.Forms.NumericUpDown();
            this.tbParity = new System.Windows.Forms.NumericUpDown();
            this.tbBaudRate = new System.Windows.Forms.NumericUpDown();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbRevBThreshold)).BeginInit();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbStopBits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDataBits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbParity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBaudRate)).BeginInit();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(261, 202);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(67, 23);
            this.btClose.TabIndex = 7;
            this.btClose.Text = "Close";
            this.btClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSave.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSave.Location = new System.Drawing.Point(190, 202);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(65, 23);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "Save";
            this.btSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btTestCom
            // 
            this.btTestCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTestCom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTestCom.Location = new System.Drawing.Point(229, 15);
            this.btTestCom.Name = "btTestCom";
            this.btTestCom.Size = new System.Drawing.Size(84, 23);
            this.btTestCom.TabIndex = 6;
            this.btTestCom.Text = "Test";
            this.btTestCom.UseVisualStyleBackColor = true;
            this.btTestCom.Click += new System.EventHandler(this.btTestCom_Click);
            // 
            // tbRevBThreshold
            // 
            this.tbRevBThreshold.Location = new System.Drawing.Point(102, 148);
            this.tbRevBThreshold.Name = "tbRevBThreshold";
            this.tbRevBThreshold.Size = new System.Drawing.Size(120, 20);
            this.tbRevBThreshold.TabIndex = 5;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btTestCom);
            this.GroupBox2.Controls.Add(this.tbRevBThreshold);
            this.GroupBox2.Controls.Add(this.tbStopBits);
            this.GroupBox2.Controls.Add(this.tbDataBits);
            this.GroupBox2.Controls.Add(this.tbParity);
            this.GroupBox2.Controls.Add(this.tbBaudRate);
            this.GroupBox2.Controls.Add(this.cbPort);
            this.GroupBox2.Controls.Add(this.Label9);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Location = new System.Drawing.Point(12, 12);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(320, 180);
            this.GroupBox2.TabIndex = 5;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Com Config";
            // 
            // tbStopBits
            // 
            this.tbStopBits.Location = new System.Drawing.Point(102, 122);
            this.tbStopBits.Name = "tbStopBits";
            this.tbStopBits.Size = new System.Drawing.Size(120, 20);
            this.tbStopBits.TabIndex = 4;
            // 
            // tbDataBits
            // 
            this.tbDataBits.Location = new System.Drawing.Point(102, 96);
            this.tbDataBits.Name = "tbDataBits";
            this.tbDataBits.Size = new System.Drawing.Size(120, 20);
            this.tbDataBits.TabIndex = 3;
            // 
            // tbParity
            // 
            this.tbParity.Location = new System.Drawing.Point(102, 70);
            this.tbParity.Name = "tbParity";
            this.tbParity.Size = new System.Drawing.Size(120, 20);
            this.tbParity.TabIndex = 2;
            // 
            // tbBaudRate
            // 
            this.tbBaudRate.Location = new System.Drawing.Point(102, 44);
            this.tbBaudRate.Maximum = new decimal(new int[] {
            120000,
            0,
            0,
            0});
            this.tbBaudRate.Name = "tbBaudRate";
            this.tbBaudRate.Size = new System.Drawing.Size(120, 20);
            this.tbBaudRate.TabIndex = 1;
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(102, 17);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(121, 21);
            this.cbPort.TabIndex = 0;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(9, 150);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(87, 13);
            this.Label9.TabIndex = 0;
            this.Label9.Text = "Rev B Threshold";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(9, 124);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(49, 13);
            this.Label8.TabIndex = 0;
            this.Label8.Text = "Stop Bits";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(8, 98);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(50, 13);
            this.Label7.TabIndex = 0;
            this.Label7.Text = "Data Bits";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(9, 72);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(33, 13);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "Parity";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(8, 46);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(58, 13);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "Baud Rate";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(9, 20);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(26, 13);
            this.Label6.TabIndex = 0;
            this.Label6.Text = "Port";
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 237);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.GroupBox2);
            this.Name = "frmConfig";
            this.Text = "Config";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbRevBThreshold)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbStopBits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDataBits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbParity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBaudRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btClose;
        internal System.Windows.Forms.Button btSave;
        internal System.Windows.Forms.Button btTestCom;
        internal System.Windows.Forms.NumericUpDown tbRevBThreshold;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.NumericUpDown tbStopBits;
        internal System.Windows.Forms.NumericUpDown tbDataBits;
        internal System.Windows.Forms.NumericUpDown tbParity;
        internal System.Windows.Forms.NumericUpDown tbBaudRate;
        internal System.Windows.Forms.ComboBox cbPort;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        internal System.IO.Ports.SerialPort SerialPort1;
    }
}