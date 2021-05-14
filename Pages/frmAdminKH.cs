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

namespace QuanLiHocThem.Pages
{
    public partial class frmAdminKH : Form
    {
        QuanLiHocThemEntities db = new QuanLiHocThemEntities();
        KhoaHoc curClass = null;
        public frmAdminKH()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
        }
        private static readonly Lazy<frmAdminKH> lazy = new Lazy<frmAdminKH>(() => new frmAdminKH());
        public static frmAdminKH Instance
        {
            get
            {
                return lazy.Value;
            }
        }
        private void BoundDataSource()
        {
            dgvContent.DataSource = db.KhoaHocs
               .Select(t => new
               {
                   Ma = t.Ma,
                  Ten = t.Ten,
               }).ToList();

        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (curClass == null)
            {
                KhoaHoc kh = new KhoaHoc()
                {
                    Ten = tbKHH.Text,
                };
                db.KhoaHocs.Add(kh);
            }
            else
            {
                curClass.Ten = tbKHH.Text;
            }
            db.SaveChanges();
            BoundDataSource();
            dgvContent.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (curClass != null)
            {
                //db.LopHocs.Where(lh => lh.Ma == curClass.Ma).FirstOrDefault();
                db.KhoaHocs.Remove(curClass);
                db.SaveChanges();
                curClass = null;
                BoundDataSource();
            }
        }
        void ResetAllTextboxes()
        {
            tbKHH.Text = "";
            BoundDataSource();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            dgvContent.Enabled = false;
            ResetAllTextboxes();
            curClass = null;
        }

        private void panelControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvContent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || e.RowIndex >= dgvContent.RowCount) return;
            var classId = int.Parse(dgvContent.Rows[e.RowIndex].Cells[0].Value.ToString());

            curClass = db.KhoaHocs.Where(mtt => mtt.Ma == classId).FirstOrDefault();
            tbKHH.Text = curClass.Ten.ToString();
        }

        private void frmAdminKH_Load(object sender, EventArgs e)
        {
            dgvContent.Enabled = true;
            BoundDataSource();
        }

        private void tbMtt_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
