namespace DoAnThucTap
{
    partial class Frm_HDX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HDX));
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbMaHDX = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaHDX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new Guna.UI.WinForms.GunaGradientButton();
            this.btnAdd = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaPictureBox3 = new Guna.UI.WinForms.GunaPictureBox();
            this.btnUpdate = new Guna.UI.WinForms.GunaGradientButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChiTiet = new Guna.UI.WinForms.GunaCircleButton();
            this.cbTenNV = new System.Windows.Forms.ComboBox();
            this.dpNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTenSP = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTenKH = new System.Windows.Forms.ComboBox();
            this.btnCancel = new Guna.UI.WinForms.GunaGradientButton();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(317, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 43;
            this.label5.Text = "Thành Tiền:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(211, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(291, 24);
            this.label8.TabIndex = 42;
            this.label8.Text = "THÔNG TIN HÓA ĐƠN XUẤT";
            // 
            // lbMaHDX
            // 
            this.lbMaHDX.AutoSize = true;
            this.lbMaHDX.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaHDX.Location = new System.Drawing.Point(122, 63);
            this.lbMaHDX.Name = "lbMaHDX";
            this.lbMaHDX.Size = new System.Drawing.Size(86, 19);
            this.lbMaHDX.TabIndex = 38;
            this.lbMaHDX.Text = "mã hóa đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(13, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 37;
            this.label4.Text = "Ngày Xuất:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(13, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "Khách Hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(13, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "Mã Hóa Đơn:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDX,
            this.TenKH,
            this.TenNV,
            this.NgayXuat,
            this.ThanhTien});
            this.dataGridView1.Location = new System.Drawing.Point(2, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(787, 208);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MaHDX
            // 
            this.MaHDX.DataPropertyName = "MaHDX";
            this.MaHDX.HeaderText = "Hóa đơn";
            this.MaHDX.Name = "MaHDX";
            this.MaHDX.ReadOnly = true;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên nhân viên";
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // NgayXuat
            // 
            this.NgayXuat.DataPropertyName = "NgayXuat";
            this.NgayXuat.HeaderText = "Ngày Xuất";
            this.NgayXuat.Name = "NgayXuat";
            this.NgayXuat.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTienChuan";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // btnSave
            // 
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnSave.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btnSave.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = global::DoAnThucTap.Properties.Resources.luu;
            this.btnSave.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSave.Location = new System.Drawing.Point(638, 92);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnSave.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Size = new System.Drawing.Size(139, 42);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnAdd.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Image = global::DoAnThucTap.Properties.Resources.add1;
            this.btnAdd.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAdd.Location = new System.Drawing.Point(638, 44);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnAdd.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Size = new System.Drawing.Size(139, 42);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gunaPictureBox3
            // 
            this.gunaPictureBox3.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox3.Image = global::DoAnThucTap.Properties.Resources.dong;
            this.gunaPictureBox3.Location = new System.Drawing.Point(754, 3);
            this.gunaPictureBox3.Name = "gunaPictureBox3";
            this.gunaPictureBox3.Size = new System.Drawing.Size(45, 35);
            this.gunaPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox3.TabIndex = 31;
            this.gunaPictureBox3.TabStop = false;
            this.gunaPictureBox3.Click += new System.EventHandler(this.gunaPictureBox3_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AnimationHoverSpeed = 0.07F;
            this.btnUpdate.AnimationSpeed = 0.03F;
            this.btnUpdate.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnUpdate.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btnUpdate.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Image = global::DoAnThucTap.Properties.Resources.update;
            this.btnUpdate.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdate.Location = new System.Drawing.Point(638, 140);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnUpdate.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Size = new System.Drawing.Size(139, 42);
            this.btnUpdate.TabIndex = 53;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(13, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 36;
            this.label3.Text = "Nhân Viên Lập:";
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.AnimationHoverSpeed = 0.07F;
            this.btnChiTiet.AnimationSpeed = 0.03F;
            this.btnChiTiet.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnChiTiet.BorderColor = System.Drawing.Color.Black;
            this.btnChiTiet.FocusedColor = System.Drawing.Color.Empty;
            this.btnChiTiet.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChiTiet.ForeColor = System.Drawing.Color.Black;
            this.btnChiTiet.Image = null;
            this.btnChiTiet.ImageSize = new System.Drawing.Size(52, 52);
            this.btnChiTiet.Location = new System.Drawing.Point(500, 194);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnChiTiet.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnChiTiet.OnHoverForeColor = System.Drawing.Color.White;
            this.btnChiTiet.OnHoverImage = null;
            this.btnChiTiet.OnPressedColor = System.Drawing.Color.Black;
            this.btnChiTiet.Size = new System.Drawing.Size(120, 41);
            this.btnChiTiet.TabIndex = 55;
            this.btnChiTiet.Text = "Chi Tiết";
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // cbTenNV
            // 
            this.cbTenNV.FormattingEnabled = true;
            this.cbTenNV.Location = new System.Drawing.Point(133, 141);
            this.cbTenNV.Name = "cbTenNV";
            this.cbTenNV.Size = new System.Drawing.Size(121, 21);
            this.cbTenNV.TabIndex = 56;
            // 
            // dpNgayXuat
            // 
            this.dpNgayXuat.Location = new System.Drawing.Point(105, 182);
            this.dpNgayXuat.Name = "dpNgayXuat";
            this.dpNgayXuat.Size = new System.Drawing.Size(200, 20);
            this.dpNgayXuat.TabIndex = 58;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(321, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 19);
            this.label13.TabIndex = 67;
            this.label13.Text = "Đơn Giá:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(321, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 19);
            this.label7.TabIndex = 66;
            this.label7.Text = "Số Lượng:";
            // 
            // cbTenSP
            // 
            this.cbTenSP.FormattingEnabled = true;
            this.cbTenSP.Location = new System.Drawing.Point(413, 167);
            this.cbTenSP.Name = "cbTenSP";
            this.cbTenSP.Size = new System.Drawing.Size(121, 21);
            this.cbTenSP.TabIndex = 71;
            this.cbTenSP.SelectedIndexChanged += new System.EventHandler(this.cbTenSP_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(321, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 19);
            this.label6.TabIndex = 70;
            this.label6.Text = "Sản Phẩm:";
            // 
            // cbTenKH
            // 
            this.cbTenKH.FormattingEnabled = true;
            this.cbTenKH.Location = new System.Drawing.Point(126, 99);
            this.cbTenKH.Name = "cbTenKH";
            this.cbTenKH.Size = new System.Drawing.Size(121, 21);
            this.cbTenKH.TabIndex = 72;
            // 
            // btnCancel
            // 
            this.btnCancel.AnimationHoverSpeed = 0.07F;
            this.btnCancel.AnimationSpeed = 0.03F;
            this.btnCancel.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnCancel.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btnCancel.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCancel.Location = new System.Drawing.Point(638, 194);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnCancel.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCancel.OnHoverImage = null;
            this.btnCancel.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancel.Size = new System.Drawing.Size(139, 38);
            this.btnCancel.TabIndex = 73;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(413, 62);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(160, 20);
            this.txtThanhTien.TabIndex = 74;
            this.txtThanhTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThanhTien_KeyPress);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(413, 98);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(160, 20);
            this.txtSoLuong.TabIndex = 75;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(413, 139);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(160, 20);
            this.txtGia.TabIndex = 76;
            this.txtGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGia_KeyPress);
            // 
            // Frm_HDX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbTenKH);
            this.Controls.Add(this.cbTenSP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dpNgayXuat);
            this.Controls.Add(this.cbTenNV);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbMaHDX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gunaPictureBox3);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_HDX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_HDX";
            this.Load += new System.EventHandler(this.Frm_HDX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbMaHDX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaGradientButton btnSave;
        private Guna.UI.WinForms.GunaGradientButton btnAdd;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI.WinForms.GunaGradientButton btnUpdate;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaCircleButton btnChiTiet;
        private System.Windows.Forms.ComboBox cbTenNV;
        private System.Windows.Forms.DateTimePicker dpNgayXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDX;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTenSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTenKH;
        private Guna.UI.WinForms.GunaGradientButton btnCancel;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGia;
    }
}