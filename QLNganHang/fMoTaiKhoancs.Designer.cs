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
            this.btnMoTK = new System.Windows.Forms.Button();
            this.txbSoTk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCCCD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMoTK
            // 
            this.btnMoTK.Location = new System.Drawing.Point(79, 145);
            this.btnMoTK.Name = "btnMoTK";
            this.btnMoTK.Size = new System.Drawing.Size(115, 38);
            this.btnMoTK.TabIndex = 0;
            this.btnMoTK.Text = "Mo Tai Khoan";
            this.btnMoTK.UseVisualStyleBackColor = true;
            this.btnMoTK.Click += new System.EventHandler(this.btnMoTK_Click);
            // 
            // txbSoTk
            // 
            this.txbSoTk.Location = new System.Drawing.Point(216, 72);
            this.txbSoTk.Name = "txbSoTk";
            this.txbSoTk.Size = new System.Drawing.Size(198, 22);
            this.txbSoTk.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhap So Tai Khoan";
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(258, 145);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(115, 38);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "Thoat";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhap CCCD";
            // 
            // txbCCCD
            // 
            this.txbCCCD.Location = new System.Drawing.Point(216, 33);
            this.txbCCCD.Name = "txbCCCD";
            this.txbCCCD.Size = new System.Drawing.Size(198, 22);
            this.txbCCCD.TabIndex = 5;
            // 
            // fMoTaiKhoancs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 341);
            this.Controls.Add(this.txbCCCD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbSoTk);
            this.Controls.Add(this.btnMoTK);
            this.Name = "fMoTaiKhoancs";
            this.Text = "fMoTaiKhoancs";
            this.Load += new System.EventHandler(this.fMoTaiKhoancs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMoTK;
        private System.Windows.Forms.TextBox txbSoTk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCCCD;
    }
}