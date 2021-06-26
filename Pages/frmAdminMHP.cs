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
    
    public partial class frmAdminMHP : Form
    {
        QuanLiHocThemEntities db = new QuanLiHocThemEntities();
        MucHocPhi curClass = null;
        public frmAdminMHP()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
        }
        private static readonly Lazy<frmAdminMHP> lazy = new Lazy<frmAdminMHP>(() => new frmAdminMHP());
        public static frmAdminMHP Instance
        {
            get
            {
                return lazy.Value;
            }
        }
        private void BoundDataSource()
        {
            dgvContent.DataSource = db.MucHocPhis
                .Select(mhp => new
                {
                    Ma = mhp.Ma,
                    Sohocphi = mhp.SoHocPhi,

                }).ToList();
        }

        private void tbMhp_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (curClass == null)
            {
                MucHocPhi mhp = new MucHocPhi()
                {
                    SoHocPhi = int.Parse(tbMhp.Text),
                };
                db.MucHocPhis.Add(mhp);
            }
            else
            {
                curClass.SoHocPhi = int.Parse(tbMhp.Text);
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
                db.MucHocPhis.Remove(curClass);
                db.SaveChanges();
                curClass = null;
                BoundDataSource();
            }
        }

        private void frmAdminMHP_Load(object sender, EventArgs e)
        {
            BoundDataSource();
        }
        void ResetAllTextboxes()
        {
            tbMhp.Text = "";
            BoundDataSource();
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

        private void dgvContent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvContent.RowCount) return;
            var classId = int.Parse(dgvContent.Rows[e.RowIndex].Cells[0].Value.ToString());

            curClass = db.MucHocPhis.Where(mhp => mhp.Ma == classId).FirstOrDefault();
            tbMhp.Text = curClass.SoHocPhi.ToString();
        }
        private void dgvContent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvContent.RowCount) return;
            var classId = int.Parse(dgvContent.Rows[e.RowIndex].Cells[0].Value.ToString());

            curClass = db.MucHocPhis.Where(mhp => mhp.Ma == classId).FirstOrDefault();
            tbMhp.Text = curClass.SoHocPhi.ToString();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void mucHocPhiBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void giaoVienBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void khoaHocBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void monHocBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
