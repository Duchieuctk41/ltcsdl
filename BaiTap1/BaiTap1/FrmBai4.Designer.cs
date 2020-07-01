namespace BaiTap1
{
    partial class FrmBai4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdtChuNghieng = new System.Windows.Forms.RadioButton();
            this.rdtChuDam = new System.Windows.Forms.RadioButton();
            this.rdtXuongDong = new System.Windows.Forms.RadioButton();
            this.rdtChuHoa = new System.Windows.Forms.RadioButton();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thuộc tính Multiline để làm gì?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdtChuHoa);
            this.groupBox1.Controls.Add(this.rdtXuongDong);
            this.groupBox1.Controls.Add(this.rdtChuDam);
            this.groupBox1.Controls.Add(this.rdtChuNghieng);
            this.groupBox1.Location = new System.Drawing.Point(66, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trả lời";
            // 
            // rdtChuNghieng
            // 
            this.rdtChuNghieng.AutoSize = true;
            this.rdtChuNghieng.Location = new System.Drawing.Point(34, 20);
            this.rdtChuNghieng.Name = "rdtChuNghieng";
            this.rdtChuNghieng.Size = new System.Drawing.Size(85, 17);
            this.rdtChuNghieng.TabIndex = 0;
            this.rdtChuNghieng.TabStop = true;
            this.rdtChuNghieng.Text = "Chữ nghiêng";
            this.rdtChuNghieng.UseVisualStyleBackColor = true;
            this.rdtChuNghieng.CheckedChanged += new System.EventHandler(this.rdtChuNghieng_CheckedChanged);
            // 
            // rdtChuDam
            // 
            this.rdtChuDam.AutoSize = true;
            this.rdtChuDam.Location = new System.Drawing.Point(34, 77);
            this.rdtChuDam.Name = "rdtChuDam";
            this.rdtChuDam.Size = new System.Drawing.Size(68, 17);
            this.rdtChuDam.TabIndex = 1;
            this.rdtChuDam.TabStop = true;
            this.rdtChuDam.Text = "Chữ đậm";
            this.rdtChuDam.UseVisualStyleBackColor = true;
            // 
            // rdtXuongDong
            // 
            this.rdtXuongDong.AutoSize = true;
            this.rdtXuongDong.Location = new System.Drawing.Point(227, 20);
            this.rdtXuongDong.Name = "rdtXuongDong";
            this.rdtXuongDong.Size = new System.Drawing.Size(83, 17);
            this.rdtXuongDong.TabIndex = 2;
            this.rdtXuongDong.TabStop = true;
            this.rdtXuongDong.Text = "Xuống dòng";
            this.rdtXuongDong.UseVisualStyleBackColor = true;
            this.rdtXuongDong.CheckedChanged += new System.EventHandler(this.rdtXuongDong_CheckedChanged);
            // 
            // rdtChuHoa
            // 
            this.rdtChuHoa.AutoSize = true;
            this.rdtChuHoa.Location = new System.Drawing.Point(227, 77);
            this.rdtChuHoa.Name = "rdtChuHoa";
            this.rdtChuHoa.Size = new System.Drawing.Size(65, 17);
            this.rdtChuHoa.TabIndex = 3;
            this.rdtChuHoa.TabStop = true;
            this.rdtChuHoa.Text = "Chữ hoa";
            this.rdtChuHoa.UseVisualStyleBackColor = true;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(66, 240);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(0, 13);
            this.lblKetQua.TabIndex = 2;
            // 
            // FrmBai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 280);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmBai4";
            this.Text = "Bài tập 4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdtChuHoa;
        private System.Windows.Forms.RadioButton rdtXuongDong;
        private System.Windows.Forms.RadioButton rdtChuDam;
        private System.Windows.Forms.RadioButton rdtChuNghieng;
        private System.Windows.Forms.Label lblKetQua;
    }
}