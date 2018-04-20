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
    public partial class QLAdmin : Form
    {
        private DataGridView dgvDSAD;
        private Button btnCapPhatTK;
        private Button btnXoaTK;
        private Button btnSuaTK;
        private Label label2;
        private Label label3;
        private TextBox txtMaAdmin;
        private TextBox txtHoTen;
        private TextBox txtUserName;
        private TextBox txtPassWord;
        private DataGridViewTextBoxColumn MA;
        private DataGridViewTextBoxColumn HOTEN;
        private DataGridViewTextBoxColumn TaiKhoan;
        private DataGridViewTextBoxColumn MatKhau;
        private Button btnLuuTK;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label1;
    
        public QLAdmin()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.dgvDSAD = new System.Windows.Forms.DataGridView();
            this.MA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCapPhatTK = new System.Windows.Forms.Button();
            this.btnXoaTK = new System.Windows.Forms.Button();
            this.btnSuaTK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaAdmin = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.btnLuuTK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSAD)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSAD
            // 
            this.dgvDSAD.AllowUserToAddRows = false;
            this.dgvDSAD.AllowUserToDeleteRows = false;
            this.dgvDSAD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSAD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA,
            this.HOTEN,
            this.TaiKhoan,
            this.MatKhau});
            this.dgvDSAD.Location = new System.Drawing.Point(0, 243);
            this.dgvDSAD.Name = "dgvDSAD";
            this.dgvDSAD.ReadOnly = true;
            this.dgvDSAD.Size = new System.Drawing.Size(679, 227);
            this.dgvDSAD.TabIndex = 14;
            this.dgvDSAD.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSAD_RowEnter);
            // 
            // MA
            // 
            this.MA.DataPropertyName = "MA";
            this.MA.HeaderText = "Mã ADMIN";
            this.MA.Name = "MA";
            this.MA.ReadOnly = true;
            // 
            // HOTEN
            // 
            this.HOTEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "Họ tên";
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.ReadOnly = true;
            // 
            // TaiKhoan
            // 
            this.TaiKhoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TaiKhoan.DataPropertyName = "TaiKhoan";
            this.TaiKhoan.HeaderText = "Username";
            this.TaiKhoan.Name = "TaiKhoan";
            this.TaiKhoan.ReadOnly = true;
            // 
            // MatKhau
            // 
            this.MatKhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Password";
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.ReadOnly = true;
            // 
            // btnCapPhatTK
            // 
            this.btnCapPhatTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapPhatTK.ForeColor = System.Drawing.Color.Navy;
            this.btnCapPhatTK.Location = new System.Drawing.Point(32, 136);
            this.btnCapPhatTK.Name = "btnCapPhatTK";
            this.btnCapPhatTK.Size = new System.Drawing.Size(138, 29);
            this.btnCapPhatTK.TabIndex = 4;
            this.btnCapPhatTK.Text = "Cấp phát TK";
            this.btnCapPhatTK.UseVisualStyleBackColor = true;
            this.btnCapPhatTK.Click += new System.EventHandler(this.btnCapPhatTK_Click);
            // 
            // btnXoaTK
            // 
            this.btnXoaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTK.ForeColor = System.Drawing.Color.Navy;
            this.btnXoaTK.Location = new System.Drawing.Point(268, 136);
            this.btnXoaTK.Name = "btnXoaTK";
            this.btnXoaTK.Size = new System.Drawing.Size(138, 29);
            this.btnXoaTK.TabIndex = 5;
            this.btnXoaTK.Text = "Xóa tài khoản";
            this.btnXoaTK.UseVisualStyleBackColor = true;
            this.btnXoaTK.Click += new System.EventHandler(this.btnXoaTK_Click);
            // 
            // btnSuaTK
            // 
            this.btnSuaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTK.ForeColor = System.Drawing.Color.Navy;
            this.btnSuaTK.Location = new System.Drawing.Point(504, 136);
            this.btnSuaTK.Name = "btnSuaTK";
            this.btnSuaTK.Size = new System.Drawing.Size(138, 29);
            this.btnSuaTK.TabIndex = 6;
            this.btnSuaTK.Text = "Sửa tài khoản";
            this.btnSuaTK.UseVisualStyleBackColor = true;
            this.btnSuaTK.Click += new System.EventHandler(this.btnSuaTK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(195, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin tài khoản admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(8, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Danh sách tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Admin";
            // 
            // txtMaAdmin
            // 
            this.txtMaAdmin.Location = new System.Drawing.Point(108, 47);
            this.txtMaAdmin.Name = "txtMaAdmin";
            this.txtMaAdmin.Size = new System.Drawing.Size(207, 20);
            this.txtMaAdmin.TabIndex = 0;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(108, 85);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(207, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(437, 47);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(207, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(437, 85);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(207, 20);
            this.txtPassWord.TabIndex = 3;
            // 
            // btnLuuTK
            // 
            this.btnLuuTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuTK.ForeColor = System.Drawing.Color.Navy;
            this.btnLuuTK.Location = new System.Drawing.Point(268, 185);
            this.btnLuuTK.Name = "btnLuuTK";
            this.btnLuuTK.Size = new System.Drawing.Size(138, 29);
            this.btnLuuTK.TabIndex = 7;
            this.btnLuuTK.Text = "Lưu";
            this.btnLuuTK.UseVisualStyleBackColor = true;
            this.btnLuuTK.Click += new System.EventHandler(this.btnLuuTK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Họ tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(360, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(360, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Username";
            // 
            // QLAdmin
            // 
            this.ClientSize = new System.Drawing.Size(678, 470);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaAdmin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSuaTK);
            this.Controls.Add(this.btnLuuTK);
            this.Controls.Add(this.btnXoaTK);
            this.Controls.Add(this.btnCapPhatTK);
            this.Controls.Add(this.dgvDSAD);
            this.Name = "QLAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.QLAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSAD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        QLKTXDataContext db = new QLKTXDataContext();
        private void QLAdmin_Load(object sender, EventArgs e)
        {
            loadds();
        }

        private void loadds()
        {
            dgvDSAD.DataSource = db.NGUOIDUNGs.Where(p => p.PhanQuyen == false).Select(p => new
            {
                p.MA,
                p.HOTEN,
                p.TaiKhoan,
                p.MatKhau
            });
            btnLuuTK.Enabled = false;
            btnCapPhatTK.Enabled = true;
            btnSuaTK.Enabled = true;
            btnXoaTK.Enabled = true;
        }

        private void dgvDSAD_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvr = new DataGridViewRow();
            dgvr = dgvDSAD.Rows[e.RowIndex];
            if(e.RowIndex >= 0)
            {
                txtMaAdmin.Text = dgvr.Cells[0].Value.ToString();
                txtHoTen.Text = dgvr.Cells[1].Value.ToString();
                txtUserName.Text = dgvr.Cells[2].Value.ToString();
                txtPassWord.Text = dgvr.Cells[3].Value.ToString();
            }
        }

        private void clearText() //xóa tất cả textbox
        {
            txtMaAdmin.ResetText();
            txtHoTen.ResetText();
            txtUserName.ResetText();
            txtPassWord.ResetText();
            txtMaAdmin.Focus();
        }

        private void btnXoaTK_Click(object sender, EventArgs e) //bấm Xóa
        {
            NGUOIDUNG nd = db.NGUOIDUNGs.Where(p => p.MA == int.Parse(txtMaAdmin.Text)).SingleOrDefault();
            if(nd != null)
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                {
                    db.NGUOIDUNGs.DeleteOnSubmit(nd);
                    db.SubmitChanges();
                    loadds();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                }
            }

        }

        private void themTK() //xử lý Thêm
        {
            NGUOIDUNG _nd = new NGUOIDUNG
            {
                MA = int.Parse(txtMaAdmin.Text),
                HOTEN = txtHoTen.Text,
                TaiKhoan = txtUserName.Text,
                MatKhau = txtPassWord.Text
            };

            if(txtMaAdmin.Text == "" || txtHoTen.Text == "" || txtUserName.Text == "" || txtPassWord.Text == "")
            {
                MessageBox.Show("Một số thông tin còn thiếu. Mời ấn vào Thêm để thêm trở lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(db.NGUOIDUNGs.Where(p => p.MA == _nd.MA).SingleOrDefault() != null)
                {
                    MessageBox.Show("Mã Admin vừa tạo bị trùng! Mời nhập lại !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearText();
                }
                else
                {
                    _nd.PhanQuyen = false;
                    db.NGUOIDUNGs.InsertOnSubmit(_nd);
                    db.SubmitChanges();
                    loadds();
                    MessageBox.Show("Thêm thành công !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        bool checkInsert = false; //phân biệt Thêm vs Sửa
        private void btnCapPhatTK_Click(object sender, EventArgs e) //bấm Thêm
        {
            clearText();
            btnLuuTK.Enabled = true;
            btnXoaTK.Enabled = false;
            btnSuaTK.Enabled = false;
            btnCapPhatTK.Enabled = false;
            checkInsert = true;
        }

        private void btnSuaTK_Click(object sender, EventArgs e) //bấm Sửa
        {
            btnCapPhatTK.Enabled = false;
            btnLuuTK.Enabled = true;
            btnXoaTK.Enabled = false;
            btnSuaTK.Enabled = false;
        }

        private void suaTK() //xử lý Sửa
        {
            NGUOIDUNG nd = db.NGUOIDUNGs.Where(p => p.MA == int.Parse(txtMaAdmin.Text)).SingleOrDefault();
            if(nd != null)
            {
                nd.HOTEN = txtHoTen.Text;
                nd.TaiKhoan = txtUserName.Text;
                nd.MatKhau = txtPassWord.Text;
                db.SubmitChanges();
                loadds();
                MessageBox.Show("Sửa thông tin thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLuuTK_Click(object sender, EventArgs e)
        {
            if (checkInsert) themTK();
            else suaTK();
        }


        

        
    }
}
