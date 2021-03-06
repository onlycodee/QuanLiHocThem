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
using QuanLiHocThem.Pages;

namespace QuanLiHocThem
{
    public partial class frmMainAdmin : DevExpress.XtraEditors.XtraForm
    {
        QuanLiHocThemEntities db;
        public frmMainAdmin()
        {
            InitializeComponent();
        }

        private void frmMainAdmin_Load(object sender, EventArgs e)
        {
            db = new QuanLiHocThemEntities();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(frmAdminStudent.Instance);
            frmAdminStudent.Instance.Show();
        }
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(frmAdminTeacher.Instance);
            frmAdminTeacher.Instance.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnlContent.Controls.Clear();
            frmAdminClass.Instance.TopLevel = false;
            pnlContent.Controls.Add(frmAdminClass.Instance);
            frmAdminClass.Instance.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnlContent.Controls.Clear();
            frmAdminMTT.Instance.TopLevel = false;
            pnlContent.Controls.Add(frmAdminMTT.Instance);
            frmAdminMTT.Instance.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnlContent.Controls.Clear();
            frmAdminMHP.Instance.TopLevel = false;
            pnlContent.Controls.Add(frmAdminMHP.Instance);
            frmAdminMHP.Instance.Show();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnlContent.Controls.Clear();
            frmAdminKH.Instance.TopLevel = false;
            pnlContent.Controls.Add(frmAdminKH.Instance);
            frmAdminKH.Instance.Show();
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnlContent.Controls.Clear();
            frmAdminCH.Instance.TopLevel = false;
            pnlContent.Controls.Add(frmAdminCH.Instance);
            frmAdminCH.Instance.Show();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnlContent.Controls.Clear();
            frmAdminMH.Instance.TopLevel = false;
            pnlContent.Controls.Add(frmAdminMH.Instance);
            frmAdminMH.Instance.Show();
        }
    }
}