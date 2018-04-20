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

namespace FrmLogin
{
    #region dataSource
    public partial class Chinhsach_baomat : Form
    {
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnhuy;
        private TextBox txtmkcu;
        private TextBox txtnmkm;
        private TextBox txtmkm;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private TextBox txtuser;
        private Label label4;
        private Button btnluu;

        public Chinhsach_baomat()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnhuy = new System.Windows.Forms.Button();
            this.txtmkcu = new System.Windows.Forms.TextBox();
            this.txtnmkm = new System.Windows.Forms.TextBox();
            this.txtmkm = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnluu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu cũ";
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(299, 201);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(106, 37);
            this.btnhuy.TabIndex = 1;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // txtmkcu
            // 
            this.txtmkcu.Location = new System.Drawing.Point(216, 59);
            this.txtmkcu.Name = "txtmkcu";
            this.txtmkcu.Size = new System.Drawing.Size(217, 24);
            this.txtmkcu.TabIndex = 2;
            // 
            // txtnmkm
            // 
            this.txtnmkm.Location = new System.Drawing.Point(216, 137);
            this.txtnmkm.Name = "txtnmkm";
            this.txtnmkm.Size = new System.Drawing.Size(217, 24);
            this.txtnmkm.TabIndex = 2;
            this.txtnmkm.UseSystemPasswordChar = true;
            // 
            // txtmkm
            // 
            this.txtmkm.Location = new System.Drawing.Point(216, 100);
            this.txtmkm.Name = "txtmkm";
            this.txtmkm.Size = new System.Drawing.Size(217, 24);
            this.txtmkm.TabIndex = 2;
            this.txtmkm.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtuser);
            this.groupBox1.Controls.Add(this.txtmkm);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnhuy);
            this.groupBox1.Controls.Add(this.txtmkcu);
            this.groupBox1.Controls.Add(this.btnluu);
            this.groupBox1.Controls.Add(this.txtnmkm);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 257);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cá nhân";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(216, 24);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(217, 24);
            this.txtuser.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nhập lại mật khẩu mới";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tài khoản";
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(70, 201);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(106, 37);
            this.btnluu.TabIndex = 1;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // Chinhsach_baomat
            // 
            this.ClientSize = new System.Drawing.Size(513, 281);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Chinhsach_baomat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    #endregion
        QLKTXDataContext db = new QLKTXDataContext();
        private void btnluu_Click(object sender, EventArgs e)
        {
            NGUOIDUNG nd = db.NGUOIDUNGs.SingleOrDefault(p => p.TaiKhoan == txtuser.Text);
            if (nd != null)
            {
                if (nd.MatKhau == txtmkcu.Text)
                {
                    nd.MatKhau = txtmkm.Text;
                    db.SubmitChanges();
                    MessageBox.Show("Thay đổi  mật khẩu thành công !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Mật khẩu cũ không đúng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("Người dùng không tồn tại ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

       
    }
}
