using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiHocThem
{
    public partial class frmQuanLiLopHoc : DevExpress.XtraEditors.XtraForm
    {
        QuanLiHocThemEntities db = new QuanLiHocThemEntities();
        GiaoVien curTeacher;
        public frmQuanLiLopHoc(GiaoVien giaoVien)
        {
            InitializeComponent();
            curTeacher = giaoVien;
        }

        private void frmQuanLiLopHoc_Load(object sender, EventArgs e)
        {
            lblTeacherName.Text = curTeacher.Ten;
            List<BuoiHoc> bhs = new List<BuoiHoc>();
            foreach (var lh in curTeacher.LopHocs)
            {
                foreach (var bh in lh.BuoiHocs)
                {
                    bhs.Add(bh);
                }
            }

            dgvContent.DataSource = bhs.Select(bh => new
            {
                bh.Ma,
                bh.MaLopHoc,
                bh.NgayHoc,
                NgayHocThu = bh.SoThuTu,
                CaHoc = bh.CaHoc.Ten,
                DaKetThuc = CompareTwoDateTime(bh.NgayHoc.Value, DateTime.Now) //((bh.NgayHoc.Value < DateTime.Now) && (bh.NgayHoc.Value.DayOfYear < DateTime.Now.DayOfYear))
            }).ToList();
            //lopHocBindingSource.DataSource = db.LopHocs.Select(lh => new
            //{
            //    lh,
            //    DaKetThuc = lh.
            //};
        }

        public bool CompareTwoDateTime(DateTime d1, DateTime d2)
        {
            if (d1.Year < d2.Year) return true;
            else if (d1.Year > d2.Year) return false;
            else if (d1.Month < d2.Month) return true;
            else if (d1.Month > d2.Month) return false;
            else if (d1.Day < d2.Day) return true;
            else if (d1.Day > d2.Day) return false;
            else return false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvContent.Columns[e.ColumnIndex].Name == "ChiTiet")
            {
                //Console.WriteLine("Data: " + dgvContent.SelectedCells[0].Value.ToString());
                int maBuoiHoc = int.Parse(dgvContent.Rows[e.RowIndex].Cells[1].Value.ToString());
                frmQuanLiBuoiHoc frmQuanLiBuoiHoc = new frmQuanLiBuoiHoc(maBuoiHoc);
                frmQuanLiBuoiHoc.Show();
            }
        }
    }
}