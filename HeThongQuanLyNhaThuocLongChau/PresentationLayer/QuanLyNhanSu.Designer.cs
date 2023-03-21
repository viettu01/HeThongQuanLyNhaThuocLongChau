
namespace HeThongQuanLyNhaThuocLongChau.PresentationLayer
{
    partial class QuanLyNhanSu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyNhanSu));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbChucVu = new System.Windows.Forms.ComboBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnKhoaNV = new System.Windows.Forms.Button();
            this.btnLamMoiNV = new System.Windows.Forms.Button();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnTimKiemNV = new System.Windows.Forms.Button();
            this.label38 = new System.Windows.Forms.Label();
            this.txtCCCDNV = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHoTenNV = new System.Windows.Forms.MaskedTextBox();
            this.txtSDTNV = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.dtpNgaySinhNV = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.label34 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTenTaiKhoan = new System.Windows.Forms.MaskedTextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbQuyen = new System.Windows.Forms.ComboBox();
            this.errorProviderNV = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNV)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(5, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1060, 551);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.tableLayoutPanel5);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1052, 522);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nhân viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.dgvNV);
            this.groupBox5.Location = new System.Drawing.Point(-5, 215);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(1060, 304);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách nhân viên";
            // 
            // dgvNV
            // 
            this.dgvNV.AllowUserToAddRows = false;
            this.dgvNV.AllowUserToDeleteRows = false;
            this.dgvNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNV.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNV.Location = new System.Drawing.Point(5, 21);
            this.dgvNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNV.Name = "dgvNV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNV.RowHeadersVisible = false;
            this.dgvNV.RowHeadersWidth = 51;
            this.dgvNV.RowTemplate.Height = 24;
            this.dgvNV.Size = new System.Drawing.Size(1048, 278);
            this.dgvNV.TabIndex = 7;
            this.dgvNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNV_CellClick);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 6;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.cmbChucVu, 5, 1);
            this.tableLayoutPanel5.Controls.Add(this.panel10, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.label38, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.txtCCCDNV, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtHoTenNV, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtSDTNV, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.label8, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.label39, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.dtpNgaySinhNV, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.label10, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.dtpNgayVaoLam, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.label34, 4, 1);
            this.tableLayoutPanel5.Controls.Add(this.label17, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.txtTenTaiKhoan, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.label35, 2, 2);
            this.tableLayoutPanel5.Controls.Add(this.txtMatKhau, 3, 2);
            this.tableLayoutPanel5.Controls.Add(this.label18, 4, 2);
            this.tableLayoutPanel5.Controls.Add(this.cmbQuyen, 5, 2);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(-5, 4);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1053, 206);
            this.tableLayoutPanel5.TabIndex = 9;
            // 
            // cmbChucVu
            // 
            this.cmbChucVu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChucVu.FormattingEnabled = true;
            this.cmbChucVu.Location = new System.Drawing.Point(811, 64);
            this.cmbChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 20, 2);
            this.cmbChucVu.Name = "cmbChucVu";
            this.cmbChucVu.Size = new System.Drawing.Size(222, 24);
            this.cmbChucVu.TabIndex = 36;
            this.cmbChucVu.Click += new System.EventHandler(this.cmbChucVu_Click);
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.SetColumnSpan(this.panel10, 6);
            this.panel10.Controls.Add(this.btnKhoaNV);
            this.panel10.Controls.Add(this.btnLamMoiNV);
            this.panel10.Controls.Add(this.btnSuaNV);
            this.panel10.Controls.Add(this.btnThemNV);
            this.panel10.Controls.Add(this.btnTimKiemNV);
            this.panel10.Location = new System.Drawing.Point(3, 155);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1047, 49);
            this.panel10.TabIndex = 19;
            // 
            // btnKhoaNV
            // 
            this.btnKhoaNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKhoaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(112)))), ((int)(((byte)(234)))));
            this.btnKhoaNV.Enabled = false;
            this.btnKhoaNV.FlatAppearance.BorderSize = 0;
            this.btnKhoaNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoaNV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKhoaNV.Location = new System.Drawing.Point(620, 5);
            this.btnKhoaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKhoaNV.Name = "btnKhoaNV";
            this.btnKhoaNV.Size = new System.Drawing.Size(107, 37);
            this.btnKhoaNV.TabIndex = 14;
            this.btnKhoaNV.Text = "Khóa";
            this.btnKhoaNV.UseVisualStyleBackColor = false;
            this.btnKhoaNV.Click += new System.EventHandler(this.btnKhoaNV_Click);
            // 
            // btnLamMoiNV
            // 
            this.btnLamMoiNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLamMoiNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(112)))), ((int)(((byte)(234)))));
            this.btnLamMoiNV.Enabled = false;
            this.btnLamMoiNV.FlatAppearance.BorderSize = 0;
            this.btnLamMoiNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoiNV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLamMoiNV.Location = new System.Drawing.Point(763, 5);
            this.btnLamMoiNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoiNV.Name = "btnLamMoiNV";
            this.btnLamMoiNV.Size = new System.Drawing.Size(107, 37);
            this.btnLamMoiNV.TabIndex = 13;
            this.btnLamMoiNV.Text = "Làm mới";
            this.btnLamMoiNV.UseVisualStyleBackColor = false;
            this.btnLamMoiNV.Click += new System.EventHandler(this.btnLamMoiNV_Click);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSuaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(112)))), ((int)(((byte)(234)))));
            this.btnSuaNV.Enabled = false;
            this.btnSuaNV.FlatAppearance.BorderSize = 0;
            this.btnSuaNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaNV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSuaNV.Location = new System.Drawing.Point(478, 5);
            this.btnSuaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(107, 37);
            this.btnSuaNV.TabIndex = 10;
            this.btnSuaNV.Text = "Sửa";
            this.btnSuaNV.UseVisualStyleBackColor = false;
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(112)))), ((int)(((byte)(234)))));
            this.btnThemNV.FlatAppearance.BorderSize = 0;
            this.btnThemNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThemNV.Location = new System.Drawing.Point(335, 5);
            this.btnThemNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(107, 37);
            this.btnThemNV.TabIndex = 9;
            this.btnThemNV.Text = "Thêm mới";
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // btnTimKiemNV
            // 
            this.btnTimKiemNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimKiemNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(112)))), ((int)(((byte)(234)))));
            this.btnTimKiemNV.FlatAppearance.BorderSize = 0;
            this.btnTimKiemNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemNV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTimKiemNV.Location = new System.Drawing.Point(192, 5);
            this.btnTimKiemNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiemNV.Name = "btnTimKiemNV";
            this.btnTimKiemNV.Size = new System.Drawing.Size(107, 37);
            this.btnTimKiemNV.TabIndex = 8;
            this.btnTimKiemNV.Text = "Tìm kiếm";
            this.btnTimKiemNV.UseVisualStyleBackColor = false;
            this.btnTimKiemNV.Click += new System.EventHandler(this.btnTimKiemNV_Click);
            // 
            // label38
            // 
            this.label38.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(11, 68);
            this.label38.Margin = new System.Windows.Forms.Padding(11, 0, 3, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(66, 17);
            this.label38.TabIndex = 15;
            this.label38.Text = "Số CCCD";
            // 
            // txtCCCDNV
            // 
            this.txtCCCDNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCCCDNV.Location = new System.Drawing.Point(112, 65);
            this.txtCCCDNV.Margin = new System.Windows.Forms.Padding(3, 2, 20, 2);
            this.txtCCCDNV.Name = "txtCCCDNV";
            this.txtCCCDNV.Size = new System.Drawing.Size(220, 22);
            this.txtCCCDNV.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(11, 0, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Họ và tên";
            // 
            // txtHoTenNV
            // 
            this.txtHoTenNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHoTenNV.Location = new System.Drawing.Point(112, 14);
            this.txtHoTenNV.Margin = new System.Windows.Forms.Padding(3, 2, 20, 2);
            this.txtHoTenNV.Name = "txtHoTenNV";
            this.txtHoTenNV.Size = new System.Drawing.Size(220, 22);
            this.txtHoTenNV.TabIndex = 2;
            // 
            // txtSDTNV
            // 
            this.txtSDTNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSDTNV.Location = new System.Drawing.Point(811, 14);
            this.txtSDTNV.Margin = new System.Windows.Forms.Padding(3, 2, 20, 2);
            this.txtSDTNV.Name = "txtSDTNV";
            this.txtSDTNV.Size = new System.Drawing.Size(222, 22);
            this.txtSDTNV.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(714, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(11, 0, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Số điện thoại";
            // 
            // label39
            // 
            this.label39.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(363, 17);
            this.label39.Margin = new System.Windows.Forms.Padding(11, 0, 3, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(71, 17);
            this.label39.TabIndex = 17;
            this.label39.Text = "Ngày sinh";
            // 
            // dtpNgaySinhNV
            // 
            this.dtpNgaySinhNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgaySinhNV.CustomFormat = " ";
            this.dtpNgaySinhNV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinhNV.Location = new System.Drawing.Point(463, 14);
            this.dtpNgaySinhNV.Margin = new System.Windows.Forms.Padding(3, 2, 20, 2);
            this.dtpNgaySinhNV.Name = "dtpNgaySinhNV";
            this.dtpNgaySinhNV.Size = new System.Drawing.Size(220, 22);
            this.dtpNgaySinhNV.TabIndex = 24;
            this.dtpNgaySinhNV.ValueChanged += new System.EventHandler(this.dtpNgaySinhNV_ValueChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(363, 68);
            this.label10.Margin = new System.Windows.Forms.Padding(11, 0, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Ngày vào làm";
            // 
            // dtpNgayVaoLam
            // 
            this.dtpNgayVaoLam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayVaoLam.CustomFormat = " ";
            this.dtpNgayVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayVaoLam.Location = new System.Drawing.Point(463, 65);
            this.dtpNgayVaoLam.Margin = new System.Windows.Forms.Padding(3, 2, 20, 2);
            this.dtpNgayVaoLam.Name = "dtpNgayVaoLam";
            this.dtpNgayVaoLam.Size = new System.Drawing.Size(220, 22);
            this.dtpNgayVaoLam.TabIndex = 26;
            this.dtpNgayVaoLam.ValueChanged += new System.EventHandler(this.dtpNgayVaoLam_ValueChanged);
            // 
            // label34
            // 
            this.label34.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(714, 68);
            this.label34.Margin = new System.Windows.Forms.Padding(11, 0, 3, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(59, 17);
            this.label34.TabIndex = 27;
            this.label34.Text = "Chức vụ";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 119);
            this.label17.Margin = new System.Windows.Forms.Padding(11, 0, 3, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 17);
            this.label17.TabIndex = 31;
            this.label17.Text = "Tên tài khoản";
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(112, 116);
            this.txtTenTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 20, 2);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(220, 22);
            this.txtTenTaiKhoan.TabIndex = 30;
            // 
            // label35
            // 
            this.label35.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(363, 119);
            this.label35.Margin = new System.Windows.Forms.Padding(11, 0, 3, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(66, 17);
            this.label35.TabIndex = 29;
            this.label35.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatKhau.Location = new System.Drawing.Point(463, 116);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 20, 2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(220, 22);
            this.txtMatKhau.TabIndex = 32;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(714, 119);
            this.label18.Margin = new System.Windows.Forms.Padding(11, 0, 3, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 17);
            this.label18.TabIndex = 33;
            this.label18.Text = "Quyền";
            // 
            // cmbQuyen
            // 
            this.cmbQuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuyen.FormattingEnabled = true;
            this.cmbQuyen.Location = new System.Drawing.Point(811, 115);
            this.cmbQuyen.Margin = new System.Windows.Forms.Padding(3, 2, 20, 2);
            this.cmbQuyen.Name = "cmbQuyen";
            this.cmbQuyen.Size = new System.Drawing.Size(222, 24);
            this.cmbQuyen.TabIndex = 34;
            this.cmbQuyen.Click += new System.EventHandler(this.cmbQuyen_Click);
            // 
            // errorProviderNV
            // 
            this.errorProviderNV.ContainerControl = this;
            // 
            // QuanLyNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyNhanSu";
            this.Text = "Quản lý nhân sự";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuanLyNhanSu_FormClosing);
            this.Load += new System.EventHandler(this.QuanLyNhanSu_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ComboBox cmbChucVu;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnKhoaNV;
        private System.Windows.Forms.Button btnLamMoiNV;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnTimKiemNV;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.MaskedTextBox txtCCCDNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtHoTenNV;
        private System.Windows.Forms.MaskedTextBox txtSDTNV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhNV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpNgayVaoLam;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox txtTenTaiKhoan;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.MaskedTextBox txtMatKhau;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbQuyen;
        private System.Windows.Forms.ErrorProvider errorProviderNV;
    }
}