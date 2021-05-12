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
    }
}