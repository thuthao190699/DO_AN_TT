namespace DoAnThucTap
{
    partial class Frm_SanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SanPham));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoLuongSP = new System.Windows.Forms.TextBox();
            this.txtGiaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.cbLoaiSP = new System.Windows.Forms.ComboBox();
            this.btnLoaiSP = new Guna.UI.WinForms.GunaGradientButton();
            this.txtMaSP = new Guna.UI.WinForms.GunaLineTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimTenSP = new Guna.UI.WinForms.GunaLineTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.OpenFileImage = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXoa = new Guna.UI.WinForms.GunaGradientButton();
            this.btnHetHang = new Guna.UI.WinForms.GunaGradientButton();
            this.btnRefresh = new Guna.UI.WinForms.GunaGradientButton();
            this.btnSave = new Guna.UI.WinForms.GunaGradientButton();
            this.btnUpdate = new Guna.UI.WinForms.GunaGradientButton();
            this.btnAdd = new Guna.UI.WinForms.GunaGradientButton();
            this.pic_AnhSach = new System.Windows.Forms.PictureBox();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AnhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoLuongSP);
            this.groupBox1.Controls.Add(this.txtGiaSP);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.cbLoaiSP);
            this.groupBox1.Controls.Add(this.btnLoaiSP);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(198, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtSoLuongSP
            // 
            this.txtSoLuongSP.Location = new System.Drawing.Point(375, 66);
            this.txtSoLuongSP.Name = "txtSoLuongSP";
            this.txtSoLuongSP.Size = new System.Drawing.Size(133, 20);
            this.txtSoLuongSP.TabIndex = 41;
            this.txtSoLuongSP.Text = "0";
            this.txtSoLuongSP.TextChanged += new System.EventHandler(this.gunaLineTextBox5_TextChanged);
            this.txtSoLuongSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaSP_KeyPress);
            // 
            // txtGiaSP
            // 
            this.txtGiaSP.Location = new System.Drawing.Point(375, 28);
            this.txtGiaSP.Name = "txtGiaSP";
            this.txtGiaSP.Size = new System.Drawing.Size(133, 20);
            this.txtGiaSP.TabIndex = 40;
            this.txtGiaSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaSP_KeyPress);
            this.txtGiaSP.Leave += new System.EventHandler(this.txtGiaSP_Leave);
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(131, 66);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(133, 20);
            this.txtTenSP.TabIndex = 39;
            // 
            // cbLoaiSP
            // 
            this.cbLoaiSP.FormattingEnabled = true;
            this.cbLoaiSP.Location = new System.Drawing.Point(131, 105);
            this.cbLoaiSP.Name = "cbLoaiSP";
            this.cbLoaiSP.Size = new System.Drawing.Size(133, 21);
            this.cbLoaiSP.TabIndex = 38;
            // 
            // btnLoaiSP
            // 
            this.btnLoaiSP.AnimationHoverSpeed = 0.07F;
            this.btnLoaiSP.AnimationSpeed = 0.03F;
            this.btnLoaiSP.BaseColor1 = System.Drawing.Color.Lavender;
            this.btnLoaiSP.BaseColor2 = System.Drawing.Color.Lavender;
            this.btnLoaiSP.BorderColor = System.Drawing.Color.Black;
            this.btnLoaiSP.FocusedColor = System.Drawing.Color.Empty;
            this.btnLoaiSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoaiSP.ForeColor = System.Drawing.Color.White;
            this.btnLoaiSP.Image = global::DoAnThucTap.Properties.Resources.add;
            this.btnLoaiSP.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLoaiSP.Location = new System.Drawing.Point(281, 99);
            this.btnLoaiSP.Name = "btnLoaiSP";
            this.btnLoaiSP.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnLoaiSP.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnLoaiSP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLoaiSP.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLoaiSP.OnHoverImage = null;
            this.btnLoaiSP.OnPressedColor = System.Drawing.Color.Black;
            this.btnLoaiSP.Size = new System.Drawing.Size(47, 33);
            this.btnLoaiSP.TabIndex = 37;
            this.btnLoaiSP.Click += new System.EventHandler(this.btnLoaiSP_Click);
            // 
            // txtMaSP
            // 
            this.txtMaSP.BackColor = System.Drawing.Color.White;
            this.txtMaSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaSP.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMaSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaSP.LineColor = System.Drawing.Color.Gainsboro;
            this.txtMaSP.Location = new System.Drawing.Point(131, 19);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.PasswordChar = '\0';
            this.txtMaSP.Size = new System.Drawing.Size(133, 26);
            this.txtMaSP.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(293, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Số Lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(293, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(19, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Mã Sản Phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(19, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên Sản Phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(21, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Loại Sản Phẩm:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.Gia,
            this.SoLuongTon,
            this.MaTL});
            this.dataGridView1.Location = new System.Drawing.Point(25, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(709, 173);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã";
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // SoLuongTon
            // 
            this.SoLuongTon.DataPropertyName = "SoLuongTon";
            this.SoLuongTon.HeaderText = "Số Lượng Tồn";
            this.SoLuongTon.Name = "SoLuongTon";
            this.SoLuongTon.ReadOnly = true;
            // 
            // MaTL
            // 
            this.MaTL.DataPropertyName = "MaTL";
            this.MaTL.HeaderText = "Loại sản phẩm";
            this.MaTL.Name = "MaTL";
            this.MaTL.ReadOnly = true;
            // 
            // txtTimTenSP
            // 
            this.txtTimTenSP.BackColor = System.Drawing.Color.White;
            this.txtTimTenSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimTenSP.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTimTenSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimTenSP.LineColor = System.Drawing.Color.Gainsboro;
            this.txtTimTenSP.Location = new System.Drawing.Point(292, 217);
            this.txtTimTenSP.Name = "txtTimTenSP";
            this.txtTimTenSP.PasswordChar = '\0';
            this.txtTimTenSP.Size = new System.Drawing.Size(328, 26);
            this.txtTimTenSP.TabIndex = 5;
            this.txtTimTenSP.TextChanged += new System.EventHandler(this.txtTimTenSP_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Chọn Ảnh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OpenFileImage
            // 
            this.OpenFileImage.FileName = "openFileDialog1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(193, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tìm Kiếm:";
            // 
            // btnXoa
            // 
            this.btnXoa.AnimationHoverSpeed = 0.07F;
            this.btnXoa.AnimationSpeed = 0.03F;
            this.btnXoa.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnXoa.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btnXoa.BorderColor = System.Drawing.Color.Black;
            this.btnXoa.FocusedColor = System.Drawing.Color.Empty;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = global::DoAnThucTap.Properties.Resources.xoa;
            this.btnXoa.ImageSize = new System.Drawing.Size(30, 30);
            this.btnXoa.Location = new System.Drawing.Point(741, 282);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnXoa.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnXoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoa.OnHoverImage = null;
            this.btnXoa.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoa.Size = new System.Drawing.Size(139, 42);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Delete";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHetHang
            // 
            this.btnHetHang.AnimationHoverSpeed = 0.07F;
            this.btnHetHang.AnimationSpeed = 0.03F;
            this.btnHetHang.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnHetHang.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btnHetHang.BorderColor = System.Drawing.Color.Black;
            this.btnHetHang.FocusedColor = System.Drawing.Color.Empty;
            this.btnHetHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHetHang.ForeColor = System.Drawing.Color.Black;
            this.btnHetHang.Image = ((System.Drawing.Image)(resources.GetObject("btnHetHang.Image")));
            this.btnHetHang.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHetHang.Location = new System.Drawing.Point(740, 330);
            this.btnHetHang.Name = "btnHetHang";
            this.btnHetHang.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnHetHang.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnHetHang.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHetHang.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHetHang.OnHoverImage = null;
            this.btnHetHang.OnPressedColor = System.Drawing.Color.Black;
            this.btnHetHang.Size = new System.Drawing.Size(140, 42);
            this.btnHetHang.TabIndex = 11;
            this.btnHetHang.Text = "SP Hết Hàng";
            this.btnHetHang.Click += new System.EventHandler(this.btnHetHang_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AnimationHoverSpeed = 0.07F;
            this.btnRefresh.AnimationSpeed = 0.03F;
            this.btnRefresh.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnRefresh.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btnRefresh.BorderColor = System.Drawing.Color.Black;
            this.btnRefresh.FocusedColor = System.Drawing.Color.Empty;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Image = global::DoAnThucTap.Properties.Resources.lammoi;
            this.btnRefresh.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRefresh.Location = new System.Drawing.Point(741, 224);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnRefresh.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnRefresh.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRefresh.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRefresh.OnHoverImage = null;
            this.btnRefresh.OnPressedColor = System.Drawing.Color.Black;
            this.btnRefresh.Size = new System.Drawing.Size(139, 42);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            this.btnSave.Location = new System.Drawing.Point(741, 165);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnSave.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Size = new System.Drawing.Size(139, 42);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(741, 107);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnUpdate.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Size = new System.Drawing.Size(139, 42);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnAdd.Location = new System.Drawing.Point(741, 55);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnAdd.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Size = new System.Drawing.Size(139, 42);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pic_AnhSach
            // 
            this.pic_AnhSach.Location = new System.Drawing.Point(26, 61);
            this.pic_AnhSach.Name = "pic_AnhSach";
            this.pic_AnhSach.Size = new System.Drawing.Size(166, 146);
            this.pic_AnhSach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_AnhSach.TabIndex = 3;
            this.pic_AnhSach.TabStop = false;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = global::DoAnThucTap.Properties.Resources.dong;
            this.gunaPictureBox2.Location = new System.Drawing.Point(848, 2);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(45, 35);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox2.TabIndex = 2;
            this.gunaPictureBox2.TabStop = false;
            this.gunaPictureBox2.Click += new System.EventHandler(this.gunaPictureBox2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(284, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(280, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "THÔNG TIN SẢN PHẨM";
            // 
            // Frm_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(913, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHetHang);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTimTenSP);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pic_AnhSach);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_SanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_SanPham";
            this.Load += new System.EventHandler(this.Frm_SanPham_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AnhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaLineTextBox txtMaSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private System.Windows.Forms.PictureBox pic_AnhSach;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI.WinForms.GunaLineTextBox txtTimTenSP;
        private Guna.UI.WinForms.GunaGradientButton btnAdd;
        private Guna.UI.WinForms.GunaGradientButton btnUpdate;
        private Guna.UI.WinForms.GunaGradientButton btnSave;
        private Guna.UI.WinForms.GunaGradientButton btnRefresh;
        private Guna.UI.WinForms.GunaGradientButton btnHetHang;
        private Guna.UI.WinForms.GunaGradientButton btnXoa;
        private Guna.UI.WinForms.GunaGradientButton btnLoaiSP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog OpenFileImage;
        private System.Windows.Forms.ComboBox cbLoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtGiaSP;
        private System.Windows.Forms.TextBox txtSoLuongSP;
        private System.Windows.Forms.Label label7;
    }
}