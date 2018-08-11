namespace DemoIn
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudTu = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudDen = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.pbQRcode = new System.Windows.Forms.PictureBox();
            this.comboPaperSource = new System.Windows.Forms.ComboBox();
            this.lblSTT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRcode)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMa
            // 
            this.txtMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Location = new System.Drawing.Point(84, 12);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(245, 26);
            this.txtMa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã";
            // 
            // nudTu
            // 
            this.nudTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTu.Location = new System.Drawing.Point(84, 44);
            this.nudTu.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudTu.Name = "nudTu";
            this.nudTu.Size = new System.Drawing.Size(100, 26);
            this.nudTu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "STT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "--->";
            // 
            // nudDen
            // 
            this.nudDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDen.Location = new System.Drawing.Point(229, 44);
            this.nudDen.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudDen.Name = "nudDen";
            this.nudDen.Size = new System.Drawing.Size(100, 26);
            this.nudDen.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(31, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "IN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbQRcode
            // 
            this.pbQRcode.BackColor = System.Drawing.Color.White;
            this.pbQRcode.Location = new System.Drawing.Point(84, 116);
            this.pbQRcode.Name = "pbQRcode";
            this.pbQRcode.Size = new System.Drawing.Size(200, 200);
            this.pbQRcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQRcode.TabIndex = 7;
            this.pbQRcode.TabStop = false;
            // 
            // comboPaperSource
            // 
            this.comboPaperSource.FormattingEnabled = true;
            this.comboPaperSource.Location = new System.Drawing.Point(5, 149);
            this.comboPaperSource.Name = "comboPaperSource";
            this.comboPaperSource.Size = new System.Drawing.Size(73, 21);
            this.comboPaperSource.TabIndex = 9;
            this.comboPaperSource.Visible = false;
            // 
            // lblSTT
            // 
            this.lblSTT.AutoSize = true;
            this.lblSTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTT.Location = new System.Drawing.Point(12, 116);
            this.lblSTT.Name = "lblSTT";
            this.lblSTT.Size = new System.Drawing.Size(29, 15);
            this.lblSTT.TabIndex = 8;
            this.lblSTT.Text = "STT";
            this.lblSTT.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 322);
            this.Controls.Add(this.comboPaperSource);
            this.Controls.Add(this.lblSTT);
            this.Controls.Add(this.pbQRcode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nudDen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudTu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Demo ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudTu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudDen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbQRcode;
        private System.Windows.Forms.ComboBox comboPaperSource;
        private System.Windows.Forms.Label lblSTT;
    }
}

