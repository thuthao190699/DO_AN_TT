namespace DoAnThucTap
{
    partial class Frm_CTHDX
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
            this.gunaPictureBox3 = new Guna.UI.WinForms.GunaPictureBox();
            this.btnXuat = new Guna.UI.WinForms.GunaGradientButton();
            this.label13 = new System.Windows.Forms.Label();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.lbTenSP = new System.Windows.Forms.Label();
            this.lbMaHDX = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.lbNgayXuat = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPictureBox3
            // 
            this.gunaPictureBox3.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox3.Image = global::DoAnThucTap.Properties.Resources.dong;
            this.gunaPictureBox3.Location = new System.Drawing.Point(561, 3);
            this.gunaPictureBox3.Name = "gunaPictureBox3";
            this.gunaPictureBox3.Size = new System.Drawing.Size(45, 35);
            this.gunaPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox3.TabIndex = 32;
            this.gunaPictureBox3.TabStop = false;
            this.gunaPictureBox3.Click += new System.EventHandler(this.gunaPictureBox3_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.AnimationHoverSpeed = 0.07F;
            this.btnXuat.AnimationSpeed = 0.03F;
            this.btnXuat.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnXuat.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btnXuat.BorderColor = System.Drawing.Color.Black;
            this.btnXuat.FocusedColor = System.Drawing.Color.Empty;
            this.btnXuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXuat.ForeColor = System.Drawing.Color.Black;
            this.btnXuat.Image = global::DoAnThucTap.Properties.Resources.hd;
            this.btnXuat.ImageSize = new System.Drawing.Size(30, 30);
            this.btnXuat.Location = new System.Drawing.Point(368, 151);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnXuat.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnXuat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXuat.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXuat.OnHoverImage = null;
            this.btnXuat.OnPressedColor = System.Drawing.Color.Black;
            this.btnXuat.Size = new System.Drawing.Size(159, 42);
            this.btnXuat.TabIndex = 49;
            this.btnXuat.Text = "Xuất CTHDX";
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(39, 383);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 19);
            this.label13.TabIndex = 45;
            this.label13.Text = "Đơn Giá:";
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Location = new System.Drawing.Point(166, 302);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(72, 13);
            this.lbTenNV.TabIndex = 43;
            this.lbTenNV.Text = "tên nhân viên";
            // 
            // lbTenSP
            // 
            this.lbTenSP.AutoSize = true;
            this.lbTenSP.Location = new System.Drawing.Point(166, 163);
            this.lbTenSP.Name = "lbTenSP";
            this.lbTenSP.Size = new System.Drawing.Size(71, 13);
            this.lbTenSP.TabIndex = 41;
            this.lbTenSP.Text = "tên sản phẩm";
            // 
            // lbMaHDX
            // 
            this.lbMaHDX.AutoSize = true;
            this.lbMaHDX.Location = new System.Drawing.Point(184, 124);
            this.lbMaHDX.Name = "lbMaHDX";
            this.lbMaHDX.Size = new System.Drawing.Size(64, 13);
            this.lbMaHDX.TabIndex = 40;
            this.lbMaHDX.Text = "mã hóa đơn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(39, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 19);
            this.label7.TabIndex = 39;
            this.label7.Text = "Số Lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(39, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 38;
            this.label6.Text = "Nhân Viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(39, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 37;
            this.label5.Text = "Ngày Xuất:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(39, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 36;
            this.label4.Text = "Khách Hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(39, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 35;
            this.label3.Text = "Tên Sản Phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(39, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "Mã Hóa Đơn Xuất:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(219, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "CHI TIẾT HÓA ĐƠN XUẤT";
            // 
            // lbTenKH
            // 
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Location = new System.Drawing.Point(160, 217);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(82, 13);
            this.lbTenKH.TabIndex = 63;
            this.lbTenKH.Text = "tên khách hàng";
            // 
            // lbNgayXuat
            // 
            this.lbNgayXuat.AutoSize = true;
            this.lbNgayXuat.Location = new System.Drawing.Point(160, 261);
            this.lbNgayXuat.Name = "lbNgayXuat";
            this.lbNgayXuat.Size = new System.Drawing.Size(53, 13);
            this.lbNgayXuat.TabIndex = 64;
            this.lbNgayXuat.Text = "ngày xuất";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(163, 384);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(100, 20);
            this.txtGia.TabIndex = 66;
            this.txtGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGia_KeyPress);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(163, 347);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuong.TabIndex = 67;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // Frm_CTHDX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 450);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.lbNgayXuat);
            this.Controls.Add(this.lbTenKH);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbTenNV);
            this.Controls.Add(this.lbTenSP);
            this.Controls.Add(this.lbMaHDX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaPictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_CTHDX";
            this.Text = "Frm_CTHDX";
            this.Load += new System.EventHandler(this.Frm_CTHDX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox3;
        private Guna.UI.WinForms.GunaGradientButton btnXuat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.Label lbTenSP;
        private System.Windows.Forms.Label lbMaHDX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTenKH;
        private System.Windows.Forms.Label lbNgayXuat;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSoLuong;
    }
}