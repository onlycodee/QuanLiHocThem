using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiHocThem
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        QuanLiHocThemEntities db = new QuanLiHocThemEntities();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtNotify.Visible = false; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = tbUserName.Text;
            string password = tbPassword.Text;
            GiaoVien giaoVien =  db.GiaoViens.Where(gv => gv.TenDangNhap == userName && gv.MatKhau == password).FirstOrDefault();  
            if (giaoVien!= null)
            {
                txtNotify.Visible = false;
                this.Hide();
                Form frmQLLH = new frmQuanLiLopHoc(giaoVien);
                frmQLLH.Show();
                //frmQLLH.FormClosed += (sender, e) => this.Close();
                //this.Close();
                //ShowDialog()
            } else
            {
                txtNotify.Visible = true; 
                //Console.WriteLine("Ten dang nhap hoac mat khau khong dung");
            }
        }
    }
}