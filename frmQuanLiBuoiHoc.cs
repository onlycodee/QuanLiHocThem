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
            BoundDataSource();
            //hocSinhBindingSource.DataSource = db.HocSinhs.ToList();
        }

        private void BoundDataSource()
        {
            dgvContent.DataSource = db.DiemDanhs.Where(dd => dd.MaBuoiHoc == _maBuoiHoc)
                .Select(bh => new
                {
                    MaBuoiHoc = bh.BuoiHoc.Ma,
                    MaHocSinh = bh.HocSinh.Ma,
                    TenHocSinh = bh.HocSinh.Ten,
                    DaDiemDanh = bh.DaDiemDanh,
                    NgayHoc = bh.BuoiHoc.NgayHoc,
                    CaHoc = bh.BuoiHoc.CaHoc.Ten,
                    BuoiHocThu = bh.BuoiHoc.SoThuTu,
                    TenMonHoc = bh.BuoiHoc.LopHoc.MonHoc.Ten,
                    NgaySinh = bh.HocSinh.NgaySinh,
                    DiaChi = bh.HocSinh.DiaChi
                }).ToList();
        }

        private void dgvContent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvContent.Columns[e.ColumnIndex].Name == "DiemDanh")
            {
                //Console.WriteLine("Hoc sinh: " + dgvContent.Rows[e.RowIndex].Cells[2].Value.ToString());
                int maHocSinh = int.Parse(dgvContent.Rows[e.RowIndex].Cells[2].Value.ToString());
                DiemDanh diemDanh = db.DiemDanhs.Where(dd => dd.MaBuoiHoc == _maBuoiHoc && dd.MaHocSinh == maHocSinh).FirstOrDefault();
                diemDanh.DaDiemDanh = !diemDanh.DaDiemDanh;
                db.SaveChanges();
                BoundDataSource();
            }
        }

        private void btnDiemDanhTatCa_Click(object sender, EventArgs e)
        {
            SetDiemDanhState(true);
        }

        private void SetDiemDanhState(bool state)
        {
            List<DiemDanh> diemDanhs =
                db.DiemDanhs.Where(dd => dd.MaBuoiHoc == _maBuoiHoc).ToList();
            for (int i = 0; i < diemDanhs.Count; i++)
            {
                diemDanhs[i].DaDiemDanh = state;
            }
            db.SaveChanges();
            BoundDataSource();
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            SetDiemDanhState(false);
        }
    }
}