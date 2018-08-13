namespace Autobot
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
            this.label1 = new System.Windows.Forms.Label();
            this.TName = new System.Windows.Forms.TextBox();
            this.LStatus1 = new System.Windows.Forms.Label();
            this.BStop = new System.Windows.Forms.Button();
            this.BStart = new System.Windows.Forms.Button();
            this.LStatus = new System.Windows.Forms.Label();
            this.BGWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GBox1 = new System.Windows.Forms.GroupBox();
            this.LB2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.GBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "ชื่อเครื่อง :";
            // 
            // TName
            // 
            this.TName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TName.BackColor = System.Drawing.SystemColors.Info;
            this.TName.Location = new System.Drawing.Point(98, 91);
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(94, 20);
            this.TName.TabIndex = 9;
            // 
            // LStatus1
            // 
            this.LStatus1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LStatus1.AutoSize = true;
            this.LStatus1.BackColor = System.Drawing.Color.White;
            this.LStatus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.LStatus1.ForeColor = System.Drawing.Color.Pink;
            this.LStatus1.Location = new System.Drawing.Point(11, 54);
            this.LStatus1.Name = "LStatus1";
            this.LStatus1.Size = new System.Drawing.Size(0, 24);
            this.LStatus1.TabIndex = 11;
            // 
            // BStop
            // 
            this.BStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BStop.Location = new System.Drawing.Point(115, 128);
            this.BStop.Name = "BStop";
            this.BStop.Size = new System.Drawing.Size(75, 23);
            this.BStop.TabIndex = 8;
            this.BStop.Text = "หยุดทำงาน";
            this.BStop.UseVisualStyleBackColor = true;
            this.BStop.Click += new System.EventHandler(this.BStop_Click);
            // 
            // BStart
            // 
            this.BStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BStart.Location = new System.Drawing.Point(12, 128);
            this.BStart.Name = "BStart";
            this.BStart.Size = new System.Drawing.Size(75, 23);
            this.BStart.TabIndex = 7;
            this.BStart.Text = "เริ่มทำงาน";
            this.BStart.UseVisualStyleBackColor = true;
            this.BStart.Click += new System.EventHandler(this.BStart_Click);
            // 
            // LStatus
            // 
            this.LStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LStatus.AutoSize = true;
            this.LStatus.BackColor = System.Drawing.Color.LavenderBlush;
            this.LStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.LStatus.Location = new System.Drawing.Point(11, 18);
            this.LStatus.Name = "LStatus";
            this.LStatus.Size = new System.Drawing.Size(92, 26);
            this.LStatus.TabIndex = 6;
            this.LStatus.Text = "Status : ";
            // 
            // BGWorker1
            // 
            this.BGWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker1_DoWork);
            // 
            // GBox1
            // 
            this.GBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.GBox1.Controls.Add(this.radioButton2);
            this.GBox1.Controls.Add(this.radioButton1);
            this.GBox1.Controls.Add(this.LB2);
            this.GBox1.Location = new System.Drawing.Point(203, 17);
            this.GBox1.Name = "GBox1";
            this.GBox1.Size = new System.Drawing.Size(131, 148);
            this.GBox1.TabIndex = 12;
            this.GBox1.TabStop = false;
            // 
            // LB2
            // 
            this.LB2.AutoSize = true;
            this.LB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)), true);
            this.LB2.Location = new System.Drawing.Point(20, 16);
            this.LB2.Name = "LB2";
            this.LB2.Size = new System.Drawing.Size(0, 15);
            this.LB2.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 101);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(9, 120);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 170);
            this.Controls.Add(this.GBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TName);
            this.Controls.Add(this.LStatus1);
            this.Controls.Add(this.BStop);
            this.Controls.Add(this.BStart);
            this.Controls.Add(this.LStatus);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.GBox1.ResumeLayout(false);
            this.GBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TName;
        private System.Windows.Forms.Label LStatus1;
        private System.Windows.Forms.Button BStop;
        private System.Windows.Forms.Button BStart;
        private System.Windows.Forms.Label LStatus;
        private System.ComponentModel.BackgroundWorker BGWorker1;
        private System.Windows.Forms.GroupBox GBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label LB2;
    }
}

