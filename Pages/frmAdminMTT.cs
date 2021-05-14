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
    public partial class frmAdminMTT : Form
    {
        QuanLiHocThemEntities db = new QuanLiHocThemEntities();
        MucThanhToan curClass = null;
        public frmAdminMTT()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
        }
        private static readonly Lazy<frmAdminMTT> lazy = new Lazy<frmAdminMTT>(() => new frmAdminMTT());
        public static frmAdminMTT Instance
        {
            get
            {
                return lazy.Value;
            }
        }
        private void BoundDataSource()
        {
            dgvContent.DataSource = db.MucThanhToans
                .Select(mtt => new
                {
                    Ma = mtt.Ma,
                    TiLePhanTram = mtt.TiLePhanTram,
                }).ToList();


        }
        void ResetAllTextboxes()
        {
            tbMtt.Text = "";
            BoundDataSource();
        }

        private void tbMtt_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (curClass == null)
            {
                MucThanhToan mtt = new MucThanhToan()
                {
                    TiLePhanTram = int.Parse(tbMtt.Text),
                };
                db.MucThanhToans.Add(mtt);
            }
            else
            {
                curClass.TiLePhanTram = int.Parse(tbMtt.Text);
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
                db.MucThanhToans.Remove(curClass);
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
        }
        private void dgvContent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvContent.RowCount) return;
            var classId = int.Parse(dgvContent.Rows[e.RowIndex].Cells[0].Value.ToString());

            curClass = db.MucThanhToans.Where(mtt => mtt.Ma == classId).FirstOrDefault();
            tbMtt.Text = curClass.TiLePhanTram.ToString();
        }

        private void frmAdminMTT_Load(object sender, EventArgs e)
        {
            dgvContent.Enabled = true;
            BoundDataSource();
        }

        private void dgvContent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmAdminMTT_Load_1(object sender, EventArgs e)
        {
            dgvContent.Enabled = true;
            BoundDataSource();
        }
    }
}
