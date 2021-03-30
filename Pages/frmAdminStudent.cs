using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using DevExpress.XtraEditors;
using System.Data.Entity.Infrastructure;

namespace QuanLiHocThem
{
    public partial class frmAdminStudent : DevExpress.XtraEditors.XtraForm
    {
        private frmAdminStudent()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
        }
        private static readonly Lazy<frmAdminStudent> lazy = new Lazy<frmAdminStudent>(() => new frmAdminStudent());
        public static frmAdminStudent Instance
        {
            get
            {
                return lazy.Value;
            }
        }
        QuanLiHocThemEntities db = new QuanLiHocThemEntities();
        //public frmMain()
        //{
        //}

        private void frmMain_Load(object sender, EventArgs e)
        {
            db.HocSinhs.Load();
            hocSinhBindingSource.DataSource = db.HocSinhs.Local;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            hocSinhBindingSource.AddNew();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Ban co muon xoa item hien tai khong?", "Message", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                hocSinhBindingSource.RemoveCurrent();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            db.SaveChanges();
            XtraMessageBox.Show("Luu thay doi thanh cong", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var changeStatus = db.ChangeTracker.Entries().Where(x => x.State != EntityState.Unchanged).ToList();
            for (int i = 0; i < changeStatus.Count; i++)
            {
                DbEntityEntry curEntry = changeStatus[i];
                switch (curEntry.State)
                {
                    case EntityState.Modified:
                        curEntry.CurrentValues.SetValues(curEntry.OriginalValues);
                        curEntry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        curEntry.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:
                        curEntry.State = EntityState.Unchanged;
                        break;

                }
            }
            hocSinhBindingSource.ResetBindings(false);
        }
    }
}
