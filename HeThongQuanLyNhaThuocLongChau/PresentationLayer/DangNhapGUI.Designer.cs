
namespace HeThongQuanLyNhaThuocLongChau.PresentationLayer
{
    partial class DangNhapGUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhapGUI));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenTaiKhoan = new MetroFramework.Controls.MetroTextBox();
            this.txtMatKhau = new MetroFramework.Controls.MetroTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.errorProviderLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnDangNhap = new HeThongQuanLyNhaThuocLongChau.PresentationLayer.Custom.VBButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(522, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(545, 554);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(120)))), ((int)(((byte)(211)))));
            this.label1.Location = new System.Drawing.Point(100, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(77, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chào mừng bạn đến với  phần mền quản lý nhà thuốc";
            // 
            // txtTenTaiKhoan
            // 
            // 
            // 
            // 
            this.txtTenTaiKhoan.CustomButton.Image = null;
            this.txtTenTaiKhoan.CustomButton.Location = new System.Drawing.Point(317, 1);
            this.txtTenTaiKhoan.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenTaiKhoan.CustomButton.Name = "";
            this.txtTenTaiKhoan.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtTenTaiKhoan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTenTaiKhoan.CustomButton.TabIndex = 1;
            this.txtTenTaiKhoan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTenTaiKhoan.CustomButton.UseSelectable = true;
            this.txtTenTaiKhoan.CustomButton.Visible = false;
            this.txtTenTaiKhoan.DisplayIcon = true;
            this.txtTenTaiKhoan.Icon = ((System.Drawing.Image)(resources.GetObject("txtTenTaiKhoan.Icon")));
            this.txtTenTaiKhoan.Lines = new string[0];
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(76, 220);
            this.txtTenTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenTaiKhoan.MaxLength = 32767;
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.PasswordChar = '\0';
            this.txtTenTaiKhoan.PromptText = "Tên tài khoản";
            this.txtTenTaiKhoan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTenTaiKhoan.SelectedText = "";
            this.txtTenTaiKhoan.SelectionLength = 0;
            this.txtTenTaiKhoan.SelectionStart = 0;
            this.txtTenTaiKhoan.ShortcutsEnabled = true;
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(353, 37);
            this.txtTenTaiKhoan.TabIndex = 8;
            this.txtTenTaiKhoan.UseSelectable = true;
            this.txtTenTaiKhoan.WaterMark = "Tên tài khoản";
            this.txtTenTaiKhoan.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTenTaiKhoan.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMatKhau
            // 
            // 
            // 
            // 
            this.txtMatKhau.CustomButton.Image = null;
            this.txtMatKhau.CustomButton.Location = new System.Drawing.Point(317, 1);
            this.txtMatKhau.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.CustomButton.Name = "";
            this.txtMatKhau.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txtMatKhau.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMatKhau.CustomButton.TabIndex = 1;
            this.txtMatKhau.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMatKhau.CustomButton.UseSelectable = true;
            this.txtMatKhau.CustomButton.Visible = false;
            this.txtMatKhau.DisplayIcon = true;
            this.txtMatKhau.Icon = ((System.Drawing.Image)(resources.GetObject("txtMatKhau.Icon")));
            this.txtMatKhau.Lines = new string[0];
            this.txtMatKhau.Location = new System.Drawing.Point(76, 277);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.MaxLength = 32767;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.PromptText = "Mật khẩu";
            this.txtMatKhau.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.SelectionLength = 0;
            this.txtMatKhau.SelectionStart = 0;
            this.txtMatKhau.ShortcutsEnabled = true;
            this.txtMatKhau.Size = new System.Drawing.Size(353, 37);
            this.txtMatKhau.TabIndex = 9;
            this.txtMatKhau.UseSelectable = true;
            this.txtMatKhau.WaterMark = "Mật khẩu";
            this.txtMatKhau.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMatKhau.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // errorProviderLogin
            // 
            this.errorProviderLogin.ContainerControl = this;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(112)))), ((int)(((byte)(234)))));
            this.btnDangNhap.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(112)))), ((int)(((byte)(234)))));
            this.btnDangNhap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDangNhap.BorderRadius = 5;
            this.btnDangNhap.BorderSize = 0;
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(76, 336);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(353, 37);
            this.btnDangNhap.TabIndex = 7;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.TextColor = System.Drawing.Color.White;
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // DangNhapGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenTaiKhoan);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "DangNhapGUI";
            this.Text = "  Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Custom.VBButton btnDangNhap;
        private MetroFramework.Controls.MetroTextBox txtTenTaiKhoan;
        private MetroFramework.Controls.MetroTextBox txtMatKhau;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ErrorProvider errorProviderLogin;
    }
}