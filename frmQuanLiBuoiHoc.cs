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

namespace QuanLiHocThem
{
    public partial class frmQuanLiBuoiHoc : DevExpress.XtraEditors.XtraForm
    {
        QuanLiHocThemEntities db = new QuanLiHocThemEntities();
        int _maBuoiHoc;
        public frmQuanLiBuoiHoc(int maBuoiHoc)
        {
            InitializeComponent();
            _maBuoiHoc = maBuoiHoc;
        }

        private void frmQuanLiBuoiHoc_Load(object sender, EventArgs e)
        {
            //Console.WriteLine("sal;fjsll");
            //bindingSource1.DataSource = db.DiemDanhs.Where(dd => dd.MaBuoiHoc == _maBuoiHoc)
            //    .Select(bh => new
            //    {
            //        bh.HocSinh.Ten,
            //        bh.HocSinh.NgaySinh,
            //        bh.HocSinh.GioiTinh,
            //        bh.HocSinh.SoDienThoai,
            //        DiemDanh = bh.DaDiemDanh,
            //        bh.BuoiHoc.NgayHoc
            //    }).ToList();
            hocSinhBindingSource.DataSource = db.HocSinhs.ToList();
        }
    }
}