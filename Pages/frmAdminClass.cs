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
    public partial class frmAdminClass : DevExpress.XtraEditors.XtraForm
    {
        QuanLiHocThemEntities db = new QuanLiHocThemEntities();
        public frmAdminClass()
        {
            InitializeComponent();
        }
        private void BoundDataSource()
        {
            dgvContent.DataSource = db.LopHocs
                .Select(lh => new
                {
                    Ma = lh.Ma,
                    DaKetThuc = lh.DaKetThuc,
                    SoLuongHocSinh = lh.SoLuongHocSinh,
                    MonHoc = lh.MonHoc.Ten,
                    KhoaHoc = lh.KhoaHoc.Ten,
                    GiaoVien = lh.GiaoVien.Ten,
                    HocPhiMotBuoi = lh.HocPhiMotBuoi, 
                    MucHocPhi = lh.MucHocPhi.SoHocPhi 
                }).ToList();
        }

        private void frmAdminClass_Load(object sender, EventArgs e)
        {
            BoundDataSource();
        }
    }
}