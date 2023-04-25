namespace QLNganHang
{
    partial class fMoTaiKhoancs
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
            this.txbSoTk = new System.Windows.Forms.TextBox();
            this.txbCCCD = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnMoTK = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbSoTk
            // 
            this.txbSoTk.Location = new System.Drawing.Point(6, 81);
            this.txbSoTk.Name = "txbSoTk";
            this.txbSoTk.Size = new System.Drawing.Size(198, 22);
            this.txbSoTk.TabIndex = 1;
            // 
            // txbCCCD
            // 
            this.txbCCCD.Location = new System.Drawing.Point(6, 37);
            this.txbCCCD.Name = "txbCCCD";
            this.txbCCCD.Size = new System.Drawing.Size(198, 22);
            this.txbCCCD.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btnMoTK);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txbCCCD);
            this.panel1.Controls.Add(this.txbSoTk);
            this.panel1.Location = new System.Drawing.Point(56, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 132);
            this.panel1.TabIndex = 6;
            // 
            // btn2
            // 
            this.btn2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn2.FillColor = System.Drawing.Color.Salmon;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn2.ForeColor = System.Drawing.Color.Black;
            this.btn2.Location = new System.Drawing.Point(233, 81);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(94, 30);
            this.btn2.TabIndex = 43;
            this.btn2.Text = "Thoat";
            this.btn2.Click += new System.EventHandler(this.btn2_Click_1);
            // 
            // btnMoTK
            // 
            this.btnMoTK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMoTK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMoTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMoTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMoTK.FillColor = System.Drawing.Color.Salmon;
            this.btnMoTK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMoTK.ForeColor = System.Drawing.Color.Black;
            this.btnMoTK.Location = new System.Drawing.Point(233, 18);
            this.btnMoTK.Name = "btnMoTK";
            this.btnMoTK.Size = new System.Drawing.Size(102, 56);
            this.btnMoTK.TabIndex = 42;
            this.btnMoTK.Text = "Mo tai khoan";
            this.btnMoTK.Click += new System.EventHandler(this.btnMoTK_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(3, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nhap so tai khoan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(3, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Nhap Cccd";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this.btnMoTK;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            this.guna2Elipse2.TargetControl = this.btn2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Lime;
            this.label12.Location = new System.Drawing.Point(116, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(203, 38);
            this.label12.TabIndex = 39;
            this.label12.Text = "Mo tai khoan";
            // 
            // fMoTaiKhoancs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(481, 245);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Name = "fMoTaiKhoancs";
            this.Text = "fMoTaiKhoancs";
            this.Load += new System.EventHandler(this.fMoTaiKhoancs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbSoTk;
        private System.Windows.Forms.TextBox txbCCCD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnMoTK;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btn2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Label label12;
    }
}