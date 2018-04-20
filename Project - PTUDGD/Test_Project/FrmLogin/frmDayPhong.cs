using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLogin
{
    public partial class frmDayPhong : Form
    {
        private GroupBox groupBox1;
        private Panel panel2;
        private ComboBox cboDayPhong;
        private Button btnTaiphong;
        private Label label2;
        private Label label1;
        private DataGridView dgvDanhSachP;
        private Panel panel1;
        private Button btnThemVaoPhong;
        private Button btnTim;
        private Label label3;
        private TextBox txtTKiem;
        private DataGridView dgvDSSV_chuacophong;
        private Label label5;
        private Button btnXoakhoiPhong;
        private Button btnHienThi;
        private TextBox txtslNguoi;
        private TextBox txtTinhTrang;
        private Label label6;
        private Label label8;
        private Label label7;
        private DataGridViewTextBoxColumn TENPHONG;
        private DataGridViewTextBoxColumn Soluong;
        private ComboBox cboPhong;
        private ComboBox cboPhongChon;
        private DataGridViewTextBoxColumn MASV;
        private DataGridViewTextBoxColumn TENSV;
        private DataGridViewTextBoxColumn GIOITINH;
        private DataGridViewTextBoxColumn CMND;
        private DataGridViewTextBoxColumn PHONG;
        private ComboBox cboPchuaXD;
        private TextBox txtMASVChon;
        private Label label4;
        private Button btnprinter;
        private DataGridView dgvDSSV_of_phong;
    
        public frmDayPhong()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.txtslNguoi = new System.Windows.Forms.TextBox();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.cboDayPhong = new System.Windows.Forms.ComboBox();
            this.btnTaiphong = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDanhSachP = new System.Windows.Forms.DataGridView();
            this.TENPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboPchuaXD = new System.Windows.Forms.ComboBox();
            this.cboPhongChon = new System.Windows.Forms.ComboBox();
            this.btnXoakhoiPhong = new System.Windows.Forms.Button();
            this.btnThemVaoPhong = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTKiem = new System.Windows.Forms.TextBox();
            this.dgvDSSV_chuacophong = new System.Windows.Forms.DataGridView();
            this.MASV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDSSV_of_phong = new System.Windows.Forms.DataGridView();
            this.txtMASVChon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnprinter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachP)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV_chuacophong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV_of_phong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1065, 536);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "QUẢN LÝ DÃY PHÒNG";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboPhong);
            this.panel2.Controls.Add(this.btnHienThi);
            this.panel2.Controls.Add(this.txtslNguoi);
            this.panel2.Controls.Add(this.txtTinhTrang);
            this.panel2.Controls.Add(this.cboDayPhong);
            this.panel2.Controls.Add(this.btnTaiphong);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dgvDanhSachP);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(7, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 509);
            this.panel2.TabIndex = 1;
            // 
            // cboPhong
            // 
            this.cboPhong.Enabled = false;
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(123, 61);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(143, 26);
            this.cboPhong.TabIndex = 6;
            // 
            // btnHienThi
            // 
            this.btnHienThi.ForeColor = System.Drawing.Color.Olive;
            this.btnHienThi.Location = new System.Drawing.Point(25, 187);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(224, 47);
            this.btnHienThi.TabIndex = 5;
            this.btnHienThi.Text = "Hiển thị danh sách\r\n";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // txtslNguoi
            // 
            this.txtslNguoi.Location = new System.Drawing.Point(123, 140);
            this.txtslNguoi.Name = "txtslNguoi";
            this.txtslNguoi.Size = new System.Drawing.Size(147, 24);
            this.txtslNguoi.TabIndex = 4;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(123, 100);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(143, 24);
            this.txtTinhTrang.TabIndex = 4;
            // 
            // cboDayPhong
            // 
            this.cboDayPhong.FormattingEnabled = true;
            this.cboDayPhong.Location = new System.Drawing.Point(56, 14);
            this.cboDayPhong.Name = "cboDayPhong";
            this.cboDayPhong.Size = new System.Drawing.Size(103, 26);
            this.cboDayPhong.TabIndex = 3;
            // 
            // btnTaiphong
            // 
            this.btnTaiphong.ForeColor = System.Drawing.Color.Olive;
            this.btnTaiphong.Location = new System.Drawing.Point(165, 12);
            this.btnTaiphong.Name = "btnTaiphong";
            this.btnTaiphong.Size = new System.Drawing.Size(101, 28);
            this.btnTaiphong.TabIndex = 2;
            this.btnTaiphong.Text = "Tải phòng";
            this.btnTaiphong.UseVisualStyleBackColor = true;
            this.btnTaiphong.Click += new System.EventHandler(this.btnTaiphong_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Số lượng người";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tình trạng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên phòng :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dãy :";
            // 
            // dgvDanhSachP
            // 
            this.dgvDanhSachP.AllowUserToAddRows = false;
            this.dgvDanhSachP.AllowUserToDeleteRows = false;
            this.dgvDanhSachP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TENPHONG,
            this.Soluong});
            this.dgvDanhSachP.Location = new System.Drawing.Point(7, 253);
            this.dgvDanhSachP.Name = "dgvDanhSachP";
            this.dgvDanhSachP.ReadOnly = true;
            this.dgvDanhSachP.Size = new System.Drawing.Size(260, 256);
            this.dgvDanhSachP.TabIndex = 0;
            this.dgvDanhSachP.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachP_RowEnter);
            // 
            // TENPHONG
            // 
            this.TENPHONG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENPHONG.DataPropertyName = "TENPHONG";
            this.TENPHONG.HeaderText = "Tên phòng";
            this.TENPHONG.Name = "TENPHONG";
            this.TENPHONG.ReadOnly = true;
            // 
            // Soluong
            // 
            this.Soluong.DataPropertyName = "Soluong";
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.Name = "Soluong";
            this.Soluong.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnprinter);
            this.panel1.Controls.Add(this.txtMASVChon);
            this.panel1.Controls.Add(this.cboPchuaXD);
            this.panel1.Controls.Add(this.cboPhongChon);
            this.panel1.Controls.Add(this.btnXoakhoiPhong);
            this.panel1.Controls.Add(this.btnThemVaoPhong);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTKiem);
            this.panel1.Controls.Add(this.dgvDSSV_chuacophong);
            this.panel1.Controls.Add(this.dgvDSSV_of_phong);
            this.panel1.Location = new System.Drawing.Point(283, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 510);
            this.panel1.TabIndex = 0;
            // 
            // cboPchuaXD
            // 
            this.cboPchuaXD.FormattingEnabled = true;
            this.cboPchuaXD.Location = new System.Drawing.Point(417, 49);
            this.cboPchuaXD.Name = "cboPchuaXD";
            this.cboPchuaXD.Size = new System.Drawing.Size(121, 28);
            this.cboPchuaXD.TabIndex = 6;
            // 
            // cboPhongChon
            // 
            this.cboPhongChon.FormattingEnabled = true;
            this.cboPhongChon.Location = new System.Drawing.Point(413, 254);
            this.cboPhongChon.Name = "cboPhongChon";
            this.cboPhongChon.Size = new System.Drawing.Size(141, 28);
            this.cboPhongChon.TabIndex = 5;
            // 
            // btnXoakhoiPhong
            // 
            this.btnXoakhoiPhong.ForeColor = System.Drawing.Color.Olive;
            this.btnXoakhoiPhong.Location = new System.Drawing.Point(571, 371);
            this.btnXoakhoiPhong.Name = "btnXoakhoiPhong";
            this.btnXoakhoiPhong.Size = new System.Drawing.Size(173, 50);
            this.btnXoakhoiPhong.TabIndex = 4;
            this.btnXoakhoiPhong.Text = "Xóa khỏi phòng";
            this.btnXoakhoiPhong.UseVisualStyleBackColor = true;
            this.btnXoakhoiPhong.Click += new System.EventHandler(this.btnXoakhoiPhong_Click);
            // 
            // btnThemVaoPhong
            // 
            this.btnThemVaoPhong.ForeColor = System.Drawing.Color.Olive;
            this.btnThemVaoPhong.Location = new System.Drawing.Point(571, 202);
            this.btnThemVaoPhong.Name = "btnThemVaoPhong";
            this.btnThemVaoPhong.Size = new System.Drawing.Size(173, 45);
            this.btnThemVaoPhong.TabIndex = 4;
            this.btnThemVaoPhong.Text = "Thêm vào phòng";
            this.btnThemVaoPhong.UseVisualStyleBackColor = true;
            this.btnThemVaoPhong.Click += new System.EventHandler(this.btnThemVaoPhong_Click);
            // 
            // btnTim
            // 
            this.btnTim.ForeColor = System.Drawing.Color.Olive;
            this.btnTim.Location = new System.Drawing.Point(369, 12);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(99, 27);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(387, 22);
            this.label8.TabIndex = 3;
            this.label8.Text = "DANH SÁCH SINH VIÊN THUỘC PHÒNG ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(401, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "DANH SÁCH SINH VIÊN CHƯA CÓ PHÒNG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tìm kiếm :";
            // 
            // txtTKiem
            // 
            this.txtTKiem.Location = new System.Drawing.Point(130, 13);
            this.txtTKiem.Name = "txtTKiem";
            this.txtTKiem.Size = new System.Drawing.Size(235, 27);
            this.txtTKiem.TabIndex = 2;
            // 
            // dgvDSSV_chuacophong
            // 
            this.dgvDSSV_chuacophong.AllowUserToAddRows = false;
            this.dgvDSSV_chuacophong.AllowUserToDeleteRows = false;
            this.dgvDSSV_chuacophong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSV_chuacophong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASV,
            this.TENSV,
            this.GIOITINH,
            this.CMND,
            this.PHONG});
            this.dgvDSSV_chuacophong.Location = new System.Drawing.Point(14, 79);
            this.dgvDSSV_chuacophong.Name = "dgvDSSV_chuacophong";
            this.dgvDSSV_chuacophong.ReadOnly = true;
            this.dgvDSSV_chuacophong.Size = new System.Drawing.Size(540, 168);
            this.dgvDSSV_chuacophong.TabIndex = 1;
            this.dgvDSSV_chuacophong.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSV_chuacophong_RowEnter);
            // 
            // MASV
            // 
            this.MASV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MASV.DataPropertyName = "MASV";
            this.MASV.HeaderText = "Mã sinh viên";
            this.MASV.Name = "MASV";
            this.MASV.ReadOnly = true;
            // 
            // TENSV
            // 
            this.TENSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENSV.DataPropertyName = "TENSV";
            this.TENSV.HeaderText = "Tên sinh viên";
            this.TENSV.Name = "TENSV";
            this.TENSV.ReadOnly = true;
            // 
            // GIOITINH
            // 
            this.GIOITINH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GIOITINH.DataPropertyName = "GIOITINH";
            this.GIOITINH.HeaderText = "Giới tính";
            this.GIOITINH.Name = "GIOITINH";
            this.GIOITINH.ReadOnly = true;
            // 
            // CMND
            // 
            this.CMND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "CMND";
            this.CMND.Name = "CMND";
            this.CMND.ReadOnly = true;
            // 
            // PHONG
            // 
            this.PHONG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PHONG.DataPropertyName = "PHONG";
            this.PHONG.HeaderText = "Phòng";
            this.PHONG.Name = "PHONG";
            this.PHONG.ReadOnly = true;
            // 
            // dgvDSSV_of_phong
            // 
            this.dgvDSSV_of_phong.AllowUserToAddRows = false;
            this.dgvDSSV_of_phong.AllowUserToDeleteRows = false;
            this.dgvDSSV_of_phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSV_of_phong.Location = new System.Drawing.Point(14, 287);
            this.dgvDSSV_of_phong.Name = "dgvDSSV_of_phong";
            this.dgvDSSV_of_phong.ReadOnly = true;
            this.dgvDSSV_of_phong.Size = new System.Drawing.Size(540, 214);
            this.dgvDSSV_of_phong.TabIndex = 1;
            this.dgvDSSV_of_phong.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSV_of_phong_RowEnter);
            // 
            // txtMASVChon
            // 
            this.txtMASVChon.Location = new System.Drawing.Point(572, 144);
            this.txtMASVChon.Name = "txtMASVChon";
            this.txtMASVChon.Size = new System.Drawing.Size(172, 27);
            this.txtMASVChon.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(568, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã sinh viên đã chọn";
            // 
            // btnprinter
            // 
            this.btnprinter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnprinter.Location = new System.Drawing.Point(572, 427);
            this.btnprinter.Name = "btnprinter";
            this.btnprinter.Size = new System.Drawing.Size(144, 74);
            this.btnprinter.TabIndex = 8;
            this.btnprinter.Text = "In danh sách";
            this.btnprinter.UseVisualStyleBackColor = true;
           // this.btnprinter.Click += new System.EventHandler(this.btnprinter_Click);
            // 
            // frmDayPhong
            // 
            this.ClientSize = new System.Drawing.Size(1077, 551);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDayPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDayPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV_chuacophong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV_of_phong)).EndInit();
            this.ResumeLayout(false);

        }
        QLKTXDataContext db = new QLKTXDataContext();
        private void frmDayPhong_Load(object sender, EventArgs e)
        {
            cboDayPhong.DataSource = db.DAYPHONGs;
            cboDayPhong.DisplayMember = "TENDAY";
            cboDayPhong.ValueMember = "MADAY";

            cboPhong.DataSource = db.PHONGs;
            cboPhong.DisplayMember = "TENPHONG";
            cboPhong.ValueMember = "MAPHONG";

            cboPhongChon.DataSource = db.PHONGs;
            cboPhongChon.DisplayMember = "TENPHONG";
            cboPhongChon.ValueMember = "MAPHONG";

            //cboPchuaXD.DataSource = db.PHONGs;
            //cboPchuaXD.DisplayMember = "TENPHONG";
            //cboPchuaXD.ValueMember = "MAPHONG";

            loadDS();
        }

        private void loadDS()
        {
            dgvDanhSachP.DataSource = db.vThongtinPhonggs.OrderBy(p=>p.TENPHONG).Select(p => new
            {
               p.TENPHONG,
               p.Soluong
            });
        }

        private void btnTaiphong_Click(object sender, EventArgs e)
        {
            dgvDanhSachP.DataSource = db.vThongtinPhonggs.Where(p => p.MADAY == cboDayPhong.SelectedValue.ToString() || p.TENPHONG == "Chờ xếp phòng").Select(p => new { 
               p.TENPHONG,
               p.Soluong
            });

        }

        private void dgvDanhSachP_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = new DataGridViewRow();
            dr = dgvDanhSachP.Rows[e.RowIndex];
            cboPhong.Text = dr.Cells[0].Value.ToString();
            txtslNguoi.Text = dr.Cells[1].Value.ToString();
            if (int.Parse(txtslNguoi.Text) < 8)
                txtTinhTrang.Text = txtslNguoi.Text + "/8";
            else txtTinhTrang.Text = "Đã đầy";
        }



        private void btnHienThi_Click(object sender, EventArgs e)
        {
            if (cboPhong.SelectedIndex == 0)
                DisplayDS_chuacophong();
            else
                display_Dacophong();
        }

        private void display_Dacophong()
        {
            dgvDSSV_of_phong.DataSource = db.SINHVIENs.Where(p => p.PHONG == cboPhong.SelectedValue.ToString()).Select(p => new
            {
                p.MASV,
                p.TENSV,
                p.GIOITINH,
                p.CMND,
                p.PHONG
            });
        }

        private void DisplayDS_chuacophong()
        {
            dgvDSSV_chuacophong.DataSource = db.SINHVIENs.Where(p => p.PHONG == cboPhong.SelectedValue.ToString()).Select(p =>
                new
                {
                    p.MASV,
                    p.TENSV,
                    p.GIOITINH,
                    p.CMND,
                    p.PHONG
                });
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dgvDSSV_chuacophong.DataSource = db.SINHVIENs.Where(p => p.MASV == txtTKiem.Text).Select(p => new
            {
                p.MASV,
                p.TENSV,
                p.GIOITINH,
                p.CMND,
                p.PHONG
            });
            if(txtTKiem.Text == "")
            {
                DisplayDS_chuacophong();
            }
        }

        private void btnThemVaoPhong_Click(object sender, EventArgs e)
        {
            SINHVIEN sv = db.SINHVIENs.SingleOrDefault(p => p.MASV == txtMASVChon.Text);
            if (sv != null)
            {
                sv.PHONG = cboPhongChon.SelectedValue.ToString();
                db.SubmitChanges();
                display_Dacophong();
                MessageBox.Show("Thêm sinh viên vào phòng thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoakhoiPhong_Click(object sender, EventArgs e)
        {
         
            
        }

        private void dgvDSSV_chuacophong_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgvDSSV_chuacophong.Rows[e.RowIndex];
            cboPchuaXD.Text = dr.Cells[4].Value.ToString();
            txtMASVChon.Text = dr.Cells[0].Value.ToString();
        }

        private void dgvDSSV_of_phong_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgvDSSV_of_phong.Rows[e.RowIndex];
            cboPhongChon.Text = dr.Cells[4].Value.ToString();
        }

        private void btnHTSV_Click(object sender, EventArgs e)
        {
            display_Dacophong();
        }

       
      
    }
}
