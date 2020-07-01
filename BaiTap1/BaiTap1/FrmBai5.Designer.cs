namespace BaiTap1
{
    partial class FrmBai5
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
            this.grpCaSi = new System.Windows.Forms.GroupBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.chkSonTung = new System.Windows.Forms.CheckBox();
            this.chkSoobinHoangSon = new System.Windows.Forms.CheckBox();
            this.chkJackJ97 = new System.Windows.Forms.CheckBox();
            this.chkDucPhuc = new System.Windows.Forms.CheckBox();
            this.chkMrSiro = new System.Windows.Forms.CheckBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.grpCaSi.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCaSi
            // 
            this.grpCaSi.Controls.Add(this.chkMrSiro);
            this.grpCaSi.Controls.Add(this.chkDucPhuc);
            this.grpCaSi.Controls.Add(this.chkJackJ97);
            this.grpCaSi.Controls.Add(this.chkSoobinHoangSon);
            this.grpCaSi.Controls.Add(this.chkSonTung);
            this.grpCaSi.Location = new System.Drawing.Point(5, 13);
            this.grpCaSi.Name = "grpCaSi";
            this.grpCaSi.Size = new System.Drawing.Size(473, 100);
            this.grpCaSi.TabIndex = 0;
            this.grpCaSi.TabStop = false;
            this.grpCaSi.Text = "Chọn ca sĩ Việt Nam";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(40, 188);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 0;
            this.btnXem.Text = "&Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // chkSonTung
            // 
            this.chkSonTung.AutoSize = true;
            this.chkSonTung.Location = new System.Drawing.Point(73, 35);
            this.chkSonTung.Name = "chkSonTung";
            this.chkSonTung.Size = new System.Drawing.Size(73, 17);
            this.chkSonTung.TabIndex = 0;
            this.chkSonTung.Text = "Sơn Tùng";
            this.chkSonTung.UseVisualStyleBackColor = true;
            // 
            // chkSoobinHoangSon
            // 
            this.chkSoobinHoangSon.AutoSize = true;
            this.chkSoobinHoangSon.Location = new System.Drawing.Point(73, 77);
            this.chkSoobinHoangSon.Name = "chkSoobinHoangSon";
            this.chkSoobinHoangSon.Size = new System.Drawing.Size(116, 17);
            this.chkSoobinHoangSon.TabIndex = 1;
            this.chkSoobinHoangSon.Text = "Soobin Hoàng Sơn";
            this.chkSoobinHoangSon.UseVisualStyleBackColor = true;
            // 
            // chkJackJ97
            // 
            this.chkJackJ97.AutoSize = true;
            this.chkJackJ97.Location = new System.Drawing.Point(215, 35);
            this.chkJackJ97.Name = "chkJackJ97";
            this.chkJackJ97.Size = new System.Drawing.Size(75, 17);
            this.chkJackJ97.TabIndex = 2;
            this.chkJackJ97.Text = "Jack - J97";
            this.chkJackJ97.UseVisualStyleBackColor = true;
            // 
            // chkDucPhuc
            // 
            this.chkDucPhuc.AutoSize = true;
            this.chkDucPhuc.Location = new System.Drawing.Point(215, 77);
            this.chkDucPhuc.Name = "chkDucPhuc";
            this.chkDucPhuc.Size = new System.Drawing.Size(74, 17);
            this.chkDucPhuc.TabIndex = 3;
            this.chkDucPhuc.Text = "Đức Phúc";
            this.chkDucPhuc.UseVisualStyleBackColor = true;
            // 
            // chkMrSiro
            // 
            this.chkMrSiro.AutoSize = true;
            this.chkMrSiro.Location = new System.Drawing.Point(348, 35);
            this.chkMrSiro.Name = "chkMrSiro";
            this.chkMrSiro.Size = new System.Drawing.Size(62, 17);
            this.chkMrSiro.TabIndex = 4;
            this.chkMrSiro.Text = "Mr. Siro";
            this.chkMrSiro.UseVisualStyleBackColor = true;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(235, 188);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(0, 13);
            this.lblKetQua.TabIndex = 1;
            // 
            // FrmBai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 359);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.grpCaSi);
            this.Name = "FrmBai5";
            this.Text = "FrmBai5";
            this.grpCaSi.ResumeLayout(false);
            this.grpCaSi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCaSi;
        private System.Windows.Forms.CheckBox chkMrSiro;
        private System.Windows.Forms.CheckBox chkDucPhuc;
        private System.Windows.Forms.CheckBox chkJackJ97;
        private System.Windows.Forms.CheckBox chkSoobinHoangSon;
        private System.Windows.Forms.CheckBox chkSonTung;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label lblKetQua;
    }
}