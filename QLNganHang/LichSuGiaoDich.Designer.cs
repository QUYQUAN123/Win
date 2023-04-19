namespace QLNganHang
{
    partial class LichSuGiaoDich
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
            this.gvLSGD = new System.Windows.Forms.DataGridView();
            this.tbnTim = new System.Windows.Forms.Button();
            this.txbSoTK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvLSGD)).BeginInit();
            this.SuspendLayout();
            // 
            // gvLSGD
            // 
            this.gvLSGD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLSGD.Location = new System.Drawing.Point(34, 48);
            this.gvLSGD.Name = "gvLSGD";
            this.gvLSGD.RowHeadersWidth = 51;
            this.gvLSGD.RowTemplate.Height = 24;
            this.gvLSGD.Size = new System.Drawing.Size(727, 223);
            this.gvLSGD.TabIndex = 0;
            // 
            // tbnTim
            // 
            this.tbnTim.Location = new System.Drawing.Point(400, 316);
            this.tbnTim.Name = "tbnTim";
            this.tbnTim.Size = new System.Drawing.Size(75, 23);
            this.tbnTim.TabIndex = 1;
            this.tbnTim.Text = "Tim";
            this.tbnTim.UseVisualStyleBackColor = true;
            this.tbnTim.Click += new System.EventHandler(this.tbnTim_Click);
            // 
            // txbSoTK
            // 
            this.txbSoTK.Location = new System.Drawing.Point(251, 316);
            this.txbSoTK.Name = "txbSoTK";
            this.txbSoTK.Size = new System.Drawing.Size(100, 22);
            this.txbSoTK.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhap Tai khoan Tra Cuu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thoat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LichSuGiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbSoTK);
            this.Controls.Add(this.tbnTim);
            this.Controls.Add(this.gvLSGD);
            this.Name = "LichSuGiaoDich";
            this.Text = "LichSuGiaoDich";
            this.Load += new System.EventHandler(this.LichSuGiaoDich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvLSGD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvLSGD;
        private System.Windows.Forms.Button tbnTim;
        private System.Windows.Forms.TextBox txbSoTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}