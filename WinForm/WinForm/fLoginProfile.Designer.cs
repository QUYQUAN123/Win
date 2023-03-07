namespace WinForm
{
    partial class fLoginProfile
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExti = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtReEnterPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tai Khoan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ten";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mat Khau cu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mat Khau Moi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nhap Lai Mat Khau";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(237, 250);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Cap Nhat";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExti
            // 
            this.btnExti.Location = new System.Drawing.Point(368, 250);
            this.btnExti.Name = "btnExti";
            this.btnExti.Size = new System.Drawing.Size(94, 29);
            this.btnExti.TabIndex = 6;
            this.btnExti.Text = "Exit";
            this.btnExti.UseVisualStyleBackColor = true;
            this.btnExti.Click += new System.EventHandler(this.btnExti_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(199, 29);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(285, 27);
            this.txtUserName.TabIndex = 7;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(199, 65);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(285, 27);
            this.txtDisplayName.TabIndex = 8;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(199, 106);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(285, 27);
            this.txtPassWord.TabIndex = 9;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(199, 148);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(285, 27);
            this.txtNewPass.TabIndex = 10;
            // 
            // txtReEnterPass
            // 
            this.txtReEnterPass.Location = new System.Drawing.Point(199, 191);
            this.txtReEnterPass.Name = "txtReEnterPass";
            this.txtReEnterPass.Size = new System.Drawing.Size(285, 27);
            this.txtReEnterPass.TabIndex = 11;
            // 
            // fLoginProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 296);
            this.Controls.Add(this.txtReEnterPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtDisplayName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnExti);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fLoginProfile";
            this.Text = "fLoginProfile";
            this.Load += new System.EventHandler(this.fLoginProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnUpdate;
        private Button btnExti;
        private TextBox txtUserName;
        private TextBox txtDisplayName;
        private TextBox txtPassWord;
        private TextBox txtNewPass;
        private TextBox txtReEnterPass;
    }
}