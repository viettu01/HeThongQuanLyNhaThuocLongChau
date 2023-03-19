﻿
namespace HeThongQuanLyNhaThuocLongChau.PresentationLayer
{
    partial class TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuanLyKho = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuanLyBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKếToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânSựToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(788, 266);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 87);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhà thuốc LONG CHÂU đạt chuẩn GPP. Nơi được người dân cả nước tin dùng với sản ph" +
    "ẩm chất lượng, uy tín";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiQuanLy,
            this.tsmiBanHang,
            this.thốngKêToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1196, 36);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiQuanLy
            // 
            this.tsmiQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiQuanLyKho,
            this.tsmiQuanLyBanHang,
            this.quảnLýKếToánToolStripMenuItem,
            this.quảnLýNhânSựToolStripMenuItem});
            this.tsmiQuanLy.Image = ((System.Drawing.Image)(resources.GetObject("tsmiQuanLy.Image")));
            this.tsmiQuanLy.Name = "tsmiQuanLy";
            this.tsmiQuanLy.Size = new System.Drawing.Size(113, 32);
            this.tsmiQuanLy.Text = "Quản lý";
            // 
            // tsmiQuanLyKho
            // 
            this.tsmiQuanLyKho.Name = "tsmiQuanLyKho";
            this.tsmiQuanLyKho.Size = new System.Drawing.Size(252, 32);
            this.tsmiQuanLyKho.Text = "Quản lý kho";
            this.tsmiQuanLyKho.Click += new System.EventHandler(this.tsmiQuanLyKho_Click);
            // 
            // tsmiQuanLyBanHang
            // 
            this.tsmiQuanLyBanHang.Name = "tsmiQuanLyBanHang";
            this.tsmiQuanLyBanHang.Size = new System.Drawing.Size(252, 32);
            this.tsmiQuanLyBanHang.Text = "Quản lý bán hàng";
            // 
            // quảnLýKếToánToolStripMenuItem
            // 
            this.quảnLýKếToánToolStripMenuItem.Name = "quảnLýKếToánToolStripMenuItem";
            this.quảnLýKếToánToolStripMenuItem.Size = new System.Drawing.Size(252, 32);
            this.quảnLýKếToánToolStripMenuItem.Text = "Quản lý kế toán";
            // 
            // quảnLýNhânSựToolStripMenuItem
            // 
            this.quảnLýNhânSựToolStripMenuItem.Name = "quảnLýNhânSựToolStripMenuItem";
            this.quảnLýNhânSựToolStripMenuItem.Size = new System.Drawing.Size(252, 32);
            this.quảnLýNhânSựToolStripMenuItem.Text = "Quản lý nhân sự";
            // 
            // tsmiBanHang
            // 
            this.tsmiBanHang.Image = ((System.Drawing.Image)(resources.GetObject("tsmiBanHang.Image")));
            this.tsmiBanHang.Name = "tsmiBanHang";
            this.tsmiBanHang.Size = new System.Drawing.Size(127, 32);
            this.tsmiBanHang.Text = "Bán hàng";
            this.tsmiBanHang.Click += new System.EventHandler(this.tsmiBanHang_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.thốngKêToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thốngKêToolStripMenuItem.Image")));
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(115, 32);
            this.thốngKêToolStripMenuItem.Text = "Báo cáo";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDangXuat,
            this.tsmiDoiMatKhau});
            this.tàiKhoảnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tàiKhoảnToolStripMenuItem.Image")));
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(128, 32);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // tsmiDangXuat
            // 
            this.tsmiDangXuat.Name = "tsmiDangXuat";
            this.tsmiDangXuat.Size = new System.Drawing.Size(224, 32);
            this.tsmiDangXuat.Text = "Đăng xuất";
            this.tsmiDangXuat.Click += new System.EventHandler(this.tsmiDangXuat_Click);
            // 
            // tsmiDoiMatKhau
            // 
            this.tsmiDoiMatKhau.Name = "tsmiDoiMatKhau";
            this.tsmiDoiMatKhau.Size = new System.Drawing.Size(224, 32);
            this.tsmiDoiMatKhau.Text = "Đổi mật khẩu";
            this.tsmiDoiMatKhau.Click += new System.EventHandler(this.tsmiDoiMatKhau_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(817, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "LONG CHÂU";
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1196, 649);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TrangChu";
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.TrangChu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuanLy;
        private System.Windows.Forms.ToolStripMenuItem tsmiBanHang;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuanLyKho;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuanLyBanHang;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKếToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânSựToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiDangXuat;
        private System.Windows.Forms.ToolStripMenuItem tsmiDoiMatKhau;
    }
}