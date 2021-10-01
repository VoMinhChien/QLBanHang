
namespace asmduanmau
{
    partial class formmain
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
            this.menustriphethong = new System.Windows.Forms.ToolStripMenuItem();
            this.menustripdangnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.menustripdangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.profilenv = new System.Windows.Forms.ToolStripMenuItem();
            this.itemthoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menustripdanhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.menustripsanpham = new System.Windows.Forms.ToolStripMenuItem();
            this.menustripnhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.menustripkhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.menustripthongke = new System.Windows.Forms.ToolStripMenuItem();
            this.itemthongke = new System.Windows.Forms.ToolStripMenuItem();
            this.menustriphuongdan = new System.Windows.Forms.ToolStripMenuItem();
            this.itemhuongdan = new System.Windows.Forms.ToolStripMenuItem();
            this.itemgioithieu = new System.Windows.Forms.ToolStripMenuItem();
            this.lbchao = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menustriphethong,
            this.menustripdanhmuc,
            this.menustripthongke,
            this.menustriphuongdan});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1258, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menustriphethong
            // 
            this.menustriphethong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menustriphethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menustripdangnhap,
            this.menustripdangxuat,
            this.profilenv,
            this.itemthoat});
            this.menustriphethong.Name = "menustriphethong";
            this.menustriphethong.Size = new System.Drawing.Size(85, 24);
            this.menustriphethong.Text = "Hệ thống";
            // 
            // menustripdangnhap
            // 
            this.menustripdangnhap.Image = global::asmduanmau.Properties.Resources.dangnhap;
            this.menustripdangnhap.Name = "menustripdangnhap";
            this.menustripdangnhap.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.menustripdangnhap.Size = new System.Drawing.Size(251, 26);
            this.menustripdangnhap.Text = "Đăng nhập";
            this.menustripdangnhap.Click += new System.EventHandler(this.menustripdangnhap_Click);
            // 
            // menustripdangxuat
            // 
            this.menustripdangxuat.Image = global::asmduanmau.Properties.Resources.dangxuat;
            this.menustripdangxuat.Name = "menustripdangxuat";
            this.menustripdangxuat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menustripdangxuat.Size = new System.Drawing.Size(251, 26);
            this.menustripdangxuat.Text = "Đăng xuất";
            // 
            // profilenv
            // 
            this.profilenv.Image = global::asmduanmau.Properties.Resources.hosonhanvien;
            this.profilenv.Name = "profilenv";
            this.profilenv.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.profilenv.Size = new System.Drawing.Size(251, 26);
            this.profilenv.Text = "Hồ sơ nhân viên";
            this.profilenv.Click += new System.EventHandler(this.profilenv_Click);
            // 
            // itemthoat
            // 
            this.itemthoat.Image = global::asmduanmau.Properties.Resources.thoat;
            this.itemthoat.Name = "itemthoat";
            this.itemthoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.itemthoat.Size = new System.Drawing.Size(251, 26);
            this.itemthoat.Text = "Thoát";
            this.itemthoat.Click += new System.EventHandler(this.itemthoat_Click);
            // 
            // menustripdanhmuc
            // 
            this.menustripdanhmuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menustripdanhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menustripsanpham,
            this.menustripnhanvien,
            this.menustripkhachhang});
            this.menustripdanhmuc.Name = "menustripdanhmuc";
            this.menustripdanhmuc.Size = new System.Drawing.Size(90, 24);
            this.menustripdanhmuc.Text = "Danh mục";
            // 
            // menustripsanpham
            // 
            this.menustripsanpham.Image = global::asmduanmau.Properties.Resources.sanpham;
            this.menustripsanpham.Name = "menustripsanpham";
            this.menustripsanpham.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.menustripsanpham.Size = new System.Drawing.Size(224, 26);
            this.menustripsanpham.Text = "Sản Phẩm";
            // 
            // menustripnhanvien
            // 
            this.menustripnhanvien.Image = global::asmduanmau.Properties.Resources.nhanvien;
            this.menustripnhanvien.Name = "menustripnhanvien";
            this.menustripnhanvien.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.menustripnhanvien.Size = new System.Drawing.Size(224, 26);
            this.menustripnhanvien.Text = "Nhân viên";
            this.menustripnhanvien.Click += new System.EventHandler(this.menustripnhanvien_Click);
            // 
            // menustripkhachhang
            // 
            this.menustripkhachhang.Image = global::asmduanmau.Properties.Resources.khachhang;
            this.menustripkhachhang.Name = "menustripkhachhang";
            this.menustripkhachhang.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.menustripkhachhang.Size = new System.Drawing.Size(224, 26);
            this.menustripkhachhang.Text = "Khách hàng";
            this.menustripkhachhang.Click += new System.EventHandler(this.menustripkhachhang_Click);
            // 
            // menustripthongke
            // 
            this.menustripthongke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menustripthongke.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemthongke});
            this.menustripthongke.Name = "menustripthongke";
            this.menustripthongke.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.menustripthongke.Size = new System.Drawing.Size(84, 24);
            this.menustripthongke.Text = "Thống kê";
            // 
            // itemthongke
            // 
            this.itemthongke.Image = global::asmduanmau.Properties.Resources.thongke;
            this.itemthongke.Name = "itemthongke";
            this.itemthongke.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.itemthongke.Size = new System.Drawing.Size(219, 26);
            this.itemthongke.Text = "Thống kê SP";
            // 
            // menustriphuongdan
            // 
            this.menustriphuongdan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menustriphuongdan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemhuongdan,
            this.itemgioithieu});
            this.menustriphuongdan.Name = "menustriphuongdan";
            this.menustriphuongdan.Size = new System.Drawing.Size(98, 24);
            this.menustriphuongdan.Text = "Hướng dẫn";
            // 
            // itemhuongdan
            // 
            this.itemhuongdan.Image = global::asmduanmau.Properties.Resources.huongdan;
            this.itemhuongdan.Name = "itemhuongdan";
            this.itemhuongdan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.itemhuongdan.Size = new System.Drawing.Size(279, 26);
            this.itemhuongdan.Text = "Hướng dẫn sử dụng";
            this.itemhuongdan.Click += new System.EventHandler(this.hướngDẫnSửDụngToolStripMenuItem1_Click);
            // 
            // itemgioithieu
            // 
            this.itemgioithieu.Image = global::asmduanmau.Properties.Resources.gioithieu;
            this.itemgioithieu.Name = "itemgioithieu";
            this.itemgioithieu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.itemgioithieu.Size = new System.Drawing.Size(279, 26);
            this.itemgioithieu.Text = "Giới thiệu phần mềm";
            this.itemgioithieu.Click += new System.EventHandler(this.itemgioithieu_Click);
            // 
            // lbchao
            // 
            this.lbchao.AutoSize = true;
            this.lbchao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbchao.Location = new System.Drawing.Point(1090, 11);
            this.lbchao.Name = "lbchao";
            this.lbchao.Size = new System.Drawing.Size(153, 17);
            this.lbchao.TabIndex = 3;
            this.lbchao.Text = "Chúc một ngày tốt lành";
            // 
            // formmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::asmduanmau.Properties.Resources.nen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1258, 585);
            this.Controls.Add(this.lbchao);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formmain";
            this.Text = "Formmain";
            this.Load += new System.EventHandler(this.formquantri_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menustriphethong;
        private System.Windows.Forms.ToolStripMenuItem menustripdangnhap;
        private System.Windows.Forms.ToolStripMenuItem menustripdangxuat;
        private System.Windows.Forms.ToolStripMenuItem profilenv;
        private System.Windows.Forms.ToolStripMenuItem itemthoat;
        private System.Windows.Forms.ToolStripMenuItem menustripdanhmuc;
        private System.Windows.Forms.ToolStripMenuItem menustripsanpham;
        private System.Windows.Forms.ToolStripMenuItem menustripnhanvien;
        private System.Windows.Forms.ToolStripMenuItem menustripkhachhang;
        private System.Windows.Forms.ToolStripMenuItem menustripthongke;
        private System.Windows.Forms.ToolStripMenuItem itemthongke;
        private System.Windows.Forms.ToolStripMenuItem menustriphuongdan;
        private System.Windows.Forms.ToolStripMenuItem itemhuongdan;
        private System.Windows.Forms.ToolStripMenuItem itemgioithieu;
        private System.Windows.Forms.Label lbchao;
    }
}