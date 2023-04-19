namespace QLNganHang
{
    partial class fNewAccount
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
            this.btnDangKi = new System.Windows.Forms.Button();
            this.txtNAccount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNPass = new System.Windows.Forms.TextBox();
            this.txtNrPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnCCCD = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDangKi
            // 
            this.btnDangKi.Location = new System.Drawing.Point(132, 237);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(133, 23);
            this.btnDangKi.TabIndex = 0;
            this.btnDangKi.Text = "Dang Ki";
            this.btnDangKi.UseVisualStyleBackColor = true;
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // txtNAccount
            // 
            this.txtNAccount.Location = new System.Drawing.Point(216, 72);
            this.txtNAccount.Name = "txtNAccount";
            this.txtNAccount.Size = new System.Drawing.Size(196, 22);
            this.txtNAccount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhap tai khoan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhap mat khau";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhap Lai mat khau";
            // 
            // txtNPass
            // 
            this.txtNPass.Location = new System.Drawing.Point(216, 131);
            this.txtNPass.Name = "txtNPass";
            this.txtNPass.Size = new System.Drawing.Size(196, 22);
            this.txtNPass.TabIndex = 5;
            // 
            // txtNrPass
            // 
            this.txtNrPass.Location = new System.Drawing.Point(216, 175);
            this.txtNrPass.Name = "txtNrPass";
            this.txtNrPass.Size = new System.Drawing.Size(196, 22);
            this.txtNrPass.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nhap CCCD";
            // 
            // txtnCCCD
            // 
            this.txtnCCCD.Location = new System.Drawing.Point(216, 33);
            this.txtnCCCD.Name = "txtnCCCD";
            this.txtnCCCD.Size = new System.Drawing.Size(196, 22);
            this.txtnCCCD.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thoat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 288);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtnCCCD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNrPass);
            this.Controls.Add(this.txtNPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNAccount);
            this.Controls.Add(this.btnDangKi);
            this.Name = "fNewAccount";
            this.Text = "fNewAccount";
            this.Load += new System.EventHandler(this.fNewAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDangKi;
        private System.Windows.Forms.TextBox txtNAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNPass;
        private System.Windows.Forms.TextBox txtNrPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnCCCD;
        private System.Windows.Forms.Button button1;
    }
}