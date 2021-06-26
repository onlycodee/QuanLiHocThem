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
    public partial class frmAdminCH : Form
    {
        QuanLiHocThemEntities db = new QuanLiHocThemEntities();
        CaHoc curClass = null;
        public frmAdminCH()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
        }
        private static readonly Lazy<frmAdminCH> lazy = new Lazy<frmAdminCH>(() => new frmAdminCH());
        public static frmAdminCH Instance
        {
            get
            {
                return lazy.Value;
            }
        }
        private void BoundDataSource()
        {
            dgvContent.DataSource = db.CaHocs
                .Select(ch => new
                {
                    Ma = ch.Ma,
                    Ten = ch.Ten,
                    ThoiGianBatDau = ch.ThoiGianBatDau,
                    ThoiGianKetThuc = ch.ThoiGianKetThuc,

                }).ToList();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void tbKHH_TextChanged(object sender, EventArgs e)
        {

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
        void ResetAllTextboxes()
        {
            tbTCH.Text = "";
            tbTGBD.Text = "";
            tbTGKT.Text = "";
            BoundDataSource();
        }
        private void dgvContent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvContent.RowCount) return;
            var classId = int.Parse(dgvContent.Rows[e.RowIndex].Cells[0].Value.ToString());

            curClass = db.CaHocs.Where(ch => ch.Ma == classId).FirstOrDefault();
            tbTCH.Text = curClass.Ten.ToString();
            tbTGBD.Text = curClass.ThoiGianBatDau.ToString();
            tbTGKT.Text = curClass.ThoiGianKetThuc.ToString();
        }

        private void panelControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (curClass == null)
            {
                CaHoc ch = new CaHoc()
                {
                    Ten = tbTCH.Text,
                    ThoiGianBatDau = TimeSpan.Parse(tbTGBD.Text),
                    ThoiGianKetThuc = TimeSpan.Parse(tbTGKT.Text),
                };
                db.CaHocs.Add(ch);
            }
            else
            {
                curClass.Ten = tbTCH.Text;
                curClass.ThoiGianBatDau = TimeSpan.Parse(tbTGBD.Text);
                curClass.ThoiGianKetThuc = TimeSpan.Parse(tbTGKT.Text);
            }
            db.SaveChanges();
            BoundDataSource();
            dgvContent.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (curClass != null)
            {
                //db.CaHocs.Where(ch => ch.Ma == curClass.Ma).FirstOrDefault();
                //db.CaHocs.Where(ch => ch.Ten == curClass.Ten).FirstOrDefault();
                //db.CaHocs.Where(ch => ch.ThoiGianBatDau == curClass.ThoiGianBatDau).FirstOrDefault();
               //db.CaHocs.Where(ch => ch.ThoiGianKetThuc == curClass.ThoiGianKetThuc).FirstOrDefault();
                db.CaHocs.Remove(curClass);
                db.SaveChanges();
                curClass = null;
                BoundDataSource();
            }
        }

        private void dgvContent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvContent.RowCount) return;
            var classId = int.Parse(dgvContent.Rows[e.RowIndex].Cells[0].Value.ToString());

            curClass = db.CaHocs.Where(ch => ch.Ma == classId).FirstOrDefault();
            tbTCH.Text = curClass.Ten.ToString();
            tbTGBD.Text = curClass.ThoiGianBatDau.ToString();
            tbTGKT.Text = curClass.ThoiGianKetThuc.ToString();
        }

        private void frmAdminCH_Load(object sender, EventArgs e)
        {
            dgvContent.Enabled = true;
            BoundDataSource();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
  
}
