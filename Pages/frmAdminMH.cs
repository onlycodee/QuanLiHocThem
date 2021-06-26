using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiHocThem.Pages
{
    public partial class frmAdminMH : Form
    {
       
        QuanLiHocThemEntities db = new QuanLiHocThemEntities();
        MonHoc curClass = null;
        public frmAdminMH()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
        }
        private static readonly Lazy<frmAdminMH> lazy = new Lazy<frmAdminMH>(() => new frmAdminMH());
        public static frmAdminMH Instance
        {
            get
            {
                return lazy.Value;
            }
        }
        private void BoundDataSource()
        {
            dgvContent.DataSource = db.MonHocs
                .Select(mh => new
                {
                    Ma = mh.Ma,
                    Ten = mh.Ten,
                    SoLuongGiaoVien = mh.SoLuongGiaoVien,
                    
                }).ToList();
        }
        void ResetAllTextboxes()
        {
            tbTMH.Text = "";
            tbSLGV.Text = "";
     
            BoundDataSource();
        }

        private void tbTMH_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (curClass == null)
            {
                MonHoc mh = new MonHoc()
                {
                    Ten = tbTMH.Text,
                    SoLuongGiaoVien = int.Parse(tbSLGV.Text),

                };
                db.MonHocs.Add(mh);
            }
            else
            {
                curClass.Ten = tbTMH.Text;
                curClass.SoLuongGiaoVien = int.Parse(tbSLGV.Text);
            }
            db.SaveChanges();
            BoundDataSource();
            dgvContent.Enabled = true;
        }
      

        private void panelControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (curClass != null)
            {
                //db.LopHocs.Where(lh => lh.Ma == curClass.Ma).FirstOrDefault();
                db.MonHocs.Remove(curClass);
                db.SaveChanges();
                curClass = null;
                BoundDataSource();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            dgvContent.Enabled = false;
            ResetAllTextboxes();
            curClass = null;
            db.SaveChanges();
            BoundDataSource();
            dgvContent.Enabled = true;
        }

        private void frmAdminMH_Load(object sender, EventArgs e)
        {
            dgvContent.Enabled = true;
            BoundDataSource();
        }

        private void dgvContent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvContent.RowCount) return;
            var classId = int.Parse(dgvContent.Rows[e.RowIndex].Cells[0].Value.ToString());

            curClass = db.MonHocs.Where(mtt => mtt.Ma == classId).FirstOrDefault();
             tbTMH.Text = curClass.Ten.ToString();
            tbSLGV.Text = curClass.SoLuongGiaoVien.ToString();
        }

        private void tbTMH_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }
    }
}
