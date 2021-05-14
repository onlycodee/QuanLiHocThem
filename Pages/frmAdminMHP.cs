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
    QuanLiHocThemEntities db = new QuanLiHocThemEntities();
    MucHocPhi curClass = null;
    public partial class frmAdminMHP : Form
    {
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
    }
}
