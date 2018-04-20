using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLogin
{

    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        public NGUOIDUNG nd = new NGUOIDUNG();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            QLKTXDataContext db = new QLKTXDataContext();
             nd = (from NGUOIDUNG in db.NGUOIDUNGs
                  where NGUOIDUNG.TaiKhoan == txtuser.Text.Trim()
                  && NGUOIDUNG.MatKhau == txtpass.Text
                  select NGUOIDUNG
                   ).SingleOrDefault();
            if (nd == null)
            {
                lblMessage.Text = "Sai mật khẫu hoặc tài khoản !";
                nd = new NGUOIDUNG();
            }
            else
            {
                this.Close();
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
