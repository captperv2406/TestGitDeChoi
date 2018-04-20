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
    public partial class frmSinhvien : Form
    {
        public frmSinhvien()
        {
            InitializeComponent();
        }
        QLKTXDataContext db = new QLKTXDataContext();
        private void frmSinhvien_Load(object sender, EventArgs e)
        {
            cboMaHD.DataSource = db.HOPDONGs;
            cboMaHD.DisplayMember = "TENHD";
            cboMaHD.ValueMember = "MAHD";
            
            cboPhong.DataSource = db.PHONGs;
            cboPhong.DisplayMember = "TENPHONG";
            cboPhong.ValueMember = "MAPHONG";

            cboPhong.SelectedIndex = 1;
            btnLuu.Enabled = false;
            LoadDSSV();
        }

        private void LoadDSSV()
        {
            if(cboPhong.SelectedIndex == 0)
            {

                dgvDSSV.DataSource = db.SINHVIENs.OrderBy(p => p.PHONG).Select(p => new
                {
                    p.MASV,
                    p.TENSV,
                    p.GIOITINH,
                    p.CMND,
                    p.NGAYSINH,
                    p.DIACHI,
                    p.NGAYVAOKTX,
                    p.NGAYRAKTX,
                    p.MAHD
                }); 
            }
            else
            dgvDSSV.DataSource = db.SINHVIENs.Where(p => p.PHONG == cboPhong.SelectedValue.ToString()).Select(p => new
            {
                  p.MASV,
                  p.TENSV,
                  p.GIOITINH,
                  p.CMND,
                  p.NGAYSINH,
                  p.DIACHI,
                  p.NGAYVAOKTX,
                  p.NGAYRAKTX,
                  p.MAHD
            });
        }

        private void btnTailai_Click(object sender, EventArgs e)
        {
            
            LoadDSSV();
        }

        private void dgvDSSV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = new DataGridViewRow();
            dr = dgvDSSV.Rows[e.RowIndex];
            if (e.RowIndex >= 0)
            {
                txtMasv.Text = dr.Cells[0].Value.ToString();
                txtTenSV.Text = dr.Cells[1].Value.ToString();
                cboGioitinh.Text = dr.Cells[2].Value.ToString();
                txtCMND.Text = dr.Cells[3].Value.ToString();
                dtpNgaySinh.Value =DateTime.Parse(dr.Cells[4].Value.ToString());
                txtDiaChi.Text = dr.Cells[5].Value.ToString();
                dtpNgayvao.Value =DateTime.Parse( dr.Cells[6].Value.ToString());
                dtpNgayRa.Value = DateTime.Parse(dr.Cells[7].Value.ToString());
                cboMaHD.Text = dr.Cells[8].Value.ToString();
            }        
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SINHVIEN sv = db.SINHVIENs.SingleOrDefault(p => p.MASV == txtMasv.Text);
            if (sv != null)
            {
                db.SINHVIENs.DeleteOnSubmit(sv);
                db.SubmitChanges();
                LoadDSSV();
                MessageBox.Show("Xóa thông tin thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        bool chkInsert = false;
        private void btnSua_Click(object sender, EventArgs e)
        {
            cboPhong.Enabled = false ;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            chkInsert = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void SuaSV()
        {
            SINHVIEN sv = db.SINHVIENs.SingleOrDefault(p => p.MASV == txtMasv.Text);
            if (sv != null)
            {
                sv.TENSV = txtTenSV.Text;
                sv.NGAYSINH = dtpNgaySinh.Value.Date;
                sv.NGAYVAOKTX = dtpNgayvao.Value.Date;
                sv.NGAYRAKTX = dtpNgayRa.Value.Date;
                sv.PHONG = cboPhong.SelectedValue.ToString();
                sv.MAHD = cboMaHD.SelectedValue.ToString();
                sv.GIOITINH = cboGioitinh.SelectedItem.ToString();
                sv.DIACHI = txtDiaChi.Text;
                db.SubmitChanges();
                LoadDSSV();
                MessageBox.Show("Sửa thông tin thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void clearText()
        {
            txtMasv.Text = "";
            txtTenSV.Text = "";
            txtCMND.Text = "";
            txtDiaChi.Text = "";
            cboGioitinh.Text = "";
            cboPhong.Enabled = false;
            cboMaHD.Text = "";
        }
        bool clearT = false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (clearT == true)
            {
                cboPhong.Enabled = false;
                cboPhong.SelectedIndex = 0;
                btnLuu.Enabled = true;
                btnSua.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                chkInsert = true;
            }
            else
            {
                clearText();
                cboPhong.Enabled = false;
                cboPhong.SelectedIndex = 0;
                btnLuu.Enabled = true;
                btnSua.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                chkInsert = true;
            }
        }
        
        private void ThemSV()
        {
            SINHVIEN  _sv = new SINHVIEN
            {
                TENSV = txtTenSV.Text,
                MASV = txtMasv.Text,
                GIOITINH = cboGioitinh.SelectedItem.ToString(),
                NGAYSINH = dtpNgaySinh.Value,
                CMND = txtCMND.Text,
                PHONG = cboPhong.SelectedValue.ToString(),
                DIACHI = txtDiaChi.Text,
                NGAYVAOKTX = dtpNgayvao.Value,
                NGAYRAKTX = dtpNgayRa.Value,
                MAHD = cboMaHD.SelectedValue.ToString()
            };
                if (db.SINHVIENs.Where(p=> p.MASV == _sv.MASV).SingleOrDefault() != null)
                {
                    MessageBox.Show("Mã sinh viên vừa tạo bị trùng! Mời nhập lại !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearT = true;
     
                }
                else
                {
                    if (_sv.TENSV == "" || _sv.CMND == "" || _sv.DIACHI == "" || _sv.GIOITINH == "" || _sv.MAHD == "")
                    {
                        MessageBox.Show("Một số thông tin còn thiếu. Mời ấn vào Thêm để thêm trở lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        clearT = true;
                    }
                    else
                    {
                        db.SINHVIENs.InsertOnSubmit(_sv);
                        db.SubmitChanges();
                        LoadDSSV();
                        MessageBox.Show("Thêm thành công !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            
        }
       
        private void btnLuu_Click(object sender, EventArgs e)
        {     
                if (chkInsert)
                {
                    ThemSV();
                }
                else
                    SuaSV();
                btnLuu.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
        }
    }
}
