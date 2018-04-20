using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrmLogin;
namespace FrmLogin
{

    public partial class frmMain : Form
    {
       
        public frmMain()
        {
            InitializeComponent();
        }
        NGUOIDUNG nd = new NGUOIDUNG();
        public frmMain(NGUOIDUNG _nd)
        {
            InitializeComponent();
            nd = _nd;
            chkPhanQuyen();
        }

        private void chkPhanQuyen()
        {
            if (nd.PhanQuyen == null)
            {
                danhMucTrươngPhongToolStripMenuItem.Enabled = false;
                pnlChucnang.Enabled = false;
                lblten.Text = "Bạn chưa đăng nhập !!";
                return;
            }

            if (nd.PhanQuyen == false)
            {
                danhMucTrươngPhongToolStripMenuItem.Enabled = false;
                pnlChucnang.Enabled = true; 
            }
            else
            {
                danhMucTrươngPhongToolStripMenuItem.Enabled = true;
                pnlChucnang.Enabled = true;
            }
            lblten.Text = "Xin chào : " + nd.TaiKhoan; 
        }

        QLKTXDataContext db = new QLKTXDataContext();
        
        private void trơLaiĐăngNhâpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin log = new FrmLogin();
            log.ShowDialog();
            nd = log.nd;
            chkPhanQuyen();
        }

        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void đôiMâtKhâuToolStripMenuItem_Click(object sender, EventArgs e)
        {
  
            Chinhsach_baomat frmDMK = new Chinhsach_baomat();
            frmDMK.ShowDialog();
        }


        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            
            frmSinhvien sv = new frmSinhvien();
            sv.ShowDialog();
        }

        private void btnDayPhong_Click(object sender, EventArgs e)
        {
            frmDayPhong ph = new frmDayPhong();
            ph.ShowDialog();
        }

        private void danhMucTrươngPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLAdmin ad = new QLAdmin();
            ad.ShowDialog();     
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            //danhMucTrươngPhongToolStripMenuItem.Enabled = false;
            //pnlChucnang.Enabled = false;
            richTextBox1.LoadFile("About.rtf", RichTextBoxStreamType.RichText);
        }      
    }
}
