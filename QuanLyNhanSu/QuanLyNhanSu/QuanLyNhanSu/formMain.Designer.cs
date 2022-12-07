namespace QuanLyNhanSu
{
    partial class formMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.smHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.smTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.smDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smThemNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.smXoaNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.smDanhSach = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaNhânViênToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmPhòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchPhòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bảngChấmCôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bảngLươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbPhongBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btTimKiemNV = new System.Windows.Forms.Button();
            this.tbMnv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvMain = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smHeThong,
            this.quảnLýToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1052, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // smHeThong
            // 
            this.smHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smTaiKhoan,
            this.smDangXuat});
            this.smHeThong.Name = "smHeThong";
            this.smHeThong.Size = new System.Drawing.Size(93, 24);
            this.smHeThong.Text = "Hệ thống";
            // 
            // smTaiKhoan
            // 
            this.smTaiKhoan.Name = "smTaiKhoan";
            this.smTaiKhoan.Size = new System.Drawing.Size(174, 26);
            this.smTaiKhoan.Text = "Tài khoản";
            this.smTaiKhoan.Click += new System.EventHandler(this.smTaiKhoan_Click);
            // 
            // smDangXuat
            // 
            this.smDangXuat.Name = "smDangXuat";
            this.smDangXuat.Size = new System.Drawing.Size(174, 26);
            this.smDangXuat.Text = "Đăng xuất";
            this.smDangXuat.Click += new System.EventHandler(this.smDangXuat_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhânViênToolStripMenuItem,
            this.phòngBanToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smThemNhanVien,
            this.smXoaNhanVien,
            this.smDanhSach,
            this.sửaNhânViênToolStripMenuItem1});
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            // 
            // smThemNhanVien
            // 
            this.smThemNhanVien.Name = "smThemNhanVien";
            this.smThemNhanVien.Size = new System.Drawing.Size(256, 26);
            this.smThemNhanVien.Text = "Thêm nhân viên";
            this.smThemNhanVien.Click += new System.EventHandler(this.smThemNhanVien_Click);
            // 
            // smXoaNhanVien
            // 
            this.smXoaNhanVien.Name = "smXoaNhanVien";
            this.smXoaNhanVien.Size = new System.Drawing.Size(256, 26);
            this.smXoaNhanVien.Text = "Xóa nhân viên";
            this.smXoaNhanVien.Click += new System.EventHandler(this.smXoaNhanVien_Click);
            // 
            // smDanhSach
            // 
            this.smDanhSach.Name = "smDanhSach";
            this.smDanhSach.Size = new System.Drawing.Size(256, 26);
            this.smDanhSach.Text = "Danh sách nhân viên";
            this.smDanhSach.Click += new System.EventHandler(this.smDanhSach_Click);
            // 
            // sửaNhânViênToolStripMenuItem1
            // 
            this.sửaNhânViênToolStripMenuItem1.Name = "sửaNhânViênToolStripMenuItem1";
            this.sửaNhânViênToolStripMenuItem1.Size = new System.Drawing.Size(256, 26);
            this.sửaNhânViênToolStripMenuItem1.Text = "Sửa nhân viên";
            this.sửaNhânViênToolStripMenuItem1.Click += new System.EventHandler(this.sửaNhânViênToolStripMenuItem1_Click);
            // 
            // phòngBanToolStripMenuItem
            // 
            this.phòngBanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmPhòngBanToolStripMenuItem,
            this.danhSáchPhòngBanToolStripMenuItem});
            this.phòngBanToolStripMenuItem.Name = "phòngBanToolStripMenuItem";
            this.phòngBanToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.phòngBanToolStripMenuItem.Text = "Phòng ban";
            // 
            // thêmPhòngBanToolStripMenuItem
            // 
            this.thêmPhòngBanToolStripMenuItem.Name = "thêmPhòngBanToolStripMenuItem";
            this.thêmPhòngBanToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.thêmPhòngBanToolStripMenuItem.Text = "Thêm,xóa phòng ban";
            this.thêmPhòngBanToolStripMenuItem.Click += new System.EventHandler(this.ThemXoaPhongBan);
            // 
            // danhSáchPhòngBanToolStripMenuItem
            // 
            this.danhSáchPhòngBanToolStripMenuItem.Name = "danhSáchPhòngBanToolStripMenuItem";
            this.danhSáchPhòngBanToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.danhSáchPhòngBanToolStripMenuItem.Text = "Danh sách phòng ban";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bảngChấmCôngToolStripMenuItem,
            this.bảngLươngToolStripMenuItem});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // bảngChấmCôngToolStripMenuItem
            // 
            this.bảngChấmCôngToolStripMenuItem.Name = "bảngChấmCôngToolStripMenuItem";
            this.bảngChấmCôngToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.bảngChấmCôngToolStripMenuItem.Text = "Bảng chấm công";
            // 
            // bảngLươngToolStripMenuItem
            // 
            this.bảngLươngToolStripMenuItem.Name = "bảngLươngToolStripMenuItem";
            this.bảngLươngToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.bảngLươngToolStripMenuItem.Text = "Bảng lương";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbPhongBan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbHoTen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btTimKiemNV);
            this.groupBox1.Controls.Add(this.tbMnv);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(32, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(991, 217);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(805, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbPhongBan
            // 
            this.tbPhongBan.Location = new System.Drawing.Point(521, 86);
            this.tbPhongBan.Name = "tbPhongBan";
            this.tbPhongBan.Size = new System.Drawing.Size(208, 27);
            this.tbPhongBan.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phòng ban";
            // 
            // tbHoTen
            // 
            this.tbHoTen.Location = new System.Drawing.Point(160, 127);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(208, 27);
            this.tbHoTen.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ tên";
            // 
            // btTimKiemNV
            // 
            this.btTimKiemNV.Location = new System.Drawing.Point(805, 37);
            this.btTimKiemNV.Name = "btTimKiemNV";
            this.btTimKiemNV.Size = new System.Drawing.Size(131, 38);
            this.btTimKiemNV.TabIndex = 2;
            this.btTimKiemNV.Text = " Tìm kiếm";
            this.btTimKiemNV.UseVisualStyleBackColor = true;
            this.btTimKiemNV.Click += new System.EventHandler(this.btTimKiemNV_Click);
            // 
            // tbMnv
            // 
            this.tbMnv.Location = new System.Drawing.Point(160, 37);
            this.tbMnv.Name = "tbMnv";
            this.tbMnv.Size = new System.Drawing.Size(208, 27);
            this.tbMnv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // dtgvMain
            // 
            this.dtgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMain.Location = new System.Drawing.Point(83, 308);
            this.dtgvMain.Name = "dtgvMain";
            this.dtgvMain.RowHeadersWidth = 51;
            this.dtgvMain.RowTemplate.Height = 24;
            this.dtgvMain.Size = new System.Drawing.Size(892, 247);
            this.dtgvMain.TabIndex = 2;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1052, 605);
            this.Controls.Add(this.dtgvMain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formMain";
            this.Text = "Quản lý nhân viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formMain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem smHeThong;
        private System.Windows.Forms.ToolStripMenuItem smTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem smDangXuat;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btTimKiemNV;
        private System.Windows.Forms.TextBox tbMnv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPhongBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem smThemNhanVien;
        private System.Windows.Forms.ToolStripMenuItem smXoaNhanVien;
        private System.Windows.Forms.ToolStripMenuItem smDanhSach;
        private System.Windows.Forms.ToolStripMenuItem thêmPhòngBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchPhòngBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảngChấmCôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảngLươngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaNhânViênToolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgvMain;
    }
}