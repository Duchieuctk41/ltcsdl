namespace BaiTap1
{
    partial class FrmBai6
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
            this.lstMatHang = new System.Windows.Forms.ListBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstMatHang
            // 
            this.lstMatHang.FormattingEnabled = true;
            this.lstMatHang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.lstMatHang.Location = new System.Drawing.Point(37, 36);
            this.lstMatHang.Name = "lstMatHang";
            this.lstMatHang.Size = new System.Drawing.Size(120, 95);
            this.lstMatHang.TabIndex = 0;
            this.lstMatHang.SelectedIndexChanged += new System.EventHandler(this.lstMatHang_SelectedIndexChanged);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(202, 48);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(274, 20);
            this.txtKetQua.TabIndex = 1;
            // 
            // FrmBai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 261);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.lstMatHang);
            this.Name = "FrmBai6";
            this.Text = "Bài tập 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMatHang;
        private System.Windows.Forms.TextBox txtKetQua;
    }
}