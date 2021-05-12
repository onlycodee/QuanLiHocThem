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
    public partial class frmAdminClassDetail : DevExpress.XtraEditors.XtraForm
    {
        QuanLiHocThemEntities db = new QuanLiHocThemEntities();
        int curClassId;
        LopHoc curClass;
        public frmAdminClassDetail(int classId)
        {
            InitializeComponent();
            curClassId = classId;
            curClass = db.LopHocs.Find(curClassId);
        }

        private void frmAdminClassDetail_Load(object sender, EventArgs e)
        {
            //List<HocSinh> hsInClass = db.BienLaiThuHocPhis.Where(bl => bl.MaLopHoc == curClassId).Select(bl => bl.HocSinh).ToList(
            RebindBindingSources();
            caHocBindingSource.DataSource = db.CaHocs.ToList();
            //Console.WriteLine("Buoi hoc: " + curClass.BuoiHocs.Count);
            if (curClass.BuoiHocs.Count > 0)
            {
                ShowLearnDate();
            }
        }

        private void ShowLearnDate()
        {
            panel2.Visible = false;
            dgvLearnDate.Dock = DockStyle.Fill;
            dgvLearnDate.DataSource = db.BuoiHocs.Select(bh => new
            {
                bh.Ma,
                bh.MaLopHoc,
                bh.CaHoc.Ten,
                bh.NgayHoc,
                bh.SoThuTu
            }).Where(bh => bh.MaLopHoc == curClassId).ToList();
        }

        void RebindBindingSources()
        {
            hocSinhBindingSource.DataSource = db.HocSinhs
                .Where(hs => !db.BienLaiThuHocPhis.Where(bl => bl.MaLopHoc == curClassId).Select(bl => bl.HocSinh).ToList().Any(hsIn => hsIn.Ma == hs.Ma)).ToList();
            hocSinhBindingSource1.DataSource = db.BienLaiThuHocPhis
                .Where(bl => bl.MaLopHoc == curClassId)
                .Select(bl => bl.HocSinh).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int maHocSinh = int.Parse(lueHocSinh.EditValue.ToString());
            BienLaiThuHocPhi bienLai = new BienLaiThuHocPhi()
            {
                TongSoBuoi = 0,
                TongTien = 0,
                NgayThu = DateTime.Now,
                MaHocSinh = maHocSinh,
                MaLopHoc = curClassId
            };
            db.BienLaiThuHocPhis.Add(bienLai);
            db.SaveChanges();
            RebindBindingSources();
        }

        private void dgvHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvHocSinh.RowCount) return;
            if (dgvHocSinh.Columns[e.ColumnIndex].Name == "ChucNang")
            {
                //Console.WriteLine("Hoc sinh: " + dgvContent.Rows[e.RowIndex].Cells[2].Value.ToString());
                int maHocSinh = int.Parse(dgvHocSinh.Rows[e.RowIndex].Cells[0].Value.ToString());
                BienLaiThuHocPhi bienLai = db.BienLaiThuHocPhis.Where(bl => bl.MaHocSinh == maHocSinh && bl.MaLopHoc == curClassId).FirstOrDefault();
                db.BienLaiThuHocPhis.Remove(bienLai);
                db.SaveChanges();
                RebindBindingSources();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            List<DayOfWeek> dayOfWeeks = new List<DayOfWeek>();
            foreach (var item in lbDaysInWeek.SelectedItems)
            {
                dayOfWeeks.Add(ConvertToDayOfWeek(item.ToString().Trim()));
            }
            int totalDays = curClass.TongSoBuoi.Value;
            DateTime startDate = cboStartDate.DateTime;
            int cnt = 0;
            List<DateTime> targetDateTimes = new List<DateTime>();
            while (cnt < totalDays)
            {
                if (dayOfWeeks.Contains(startDate.DayOfWeek))
                {
                    targetDateTimes.Add(startDate);
                    cnt++;
                }
                startDate = startDate.AddDays(1);
            }
            //Console.WriteLine("TOTAL DATE: " + totalDays);
            int maCaHoc = int.Parse(cboCaHoc.SelectedValue.ToString());
            int stt = 1;
            List<HocSinh> listHs = db.BienLaiThuHocPhis.Where(bl => bl.MaLopHoc == curClassId).Select(bl => bl.HocSinh).Distinct().ToList();
            foreach (var curDate in targetDateTimes)
            {
                BuoiHoc newBh = new BuoiHoc()
                {
                    MaLopHoc = curClassId,
                    MaCaHoc = maCaHoc,
                    NgayHoc = curDate,
                    SoThuTu = stt
                };
                db.BuoiHocs.Add(newBh);
                stt++;
            }
            db.SaveChanges();
            Console.WriteLine("So buoi hoc: " + db.BuoiHocs.Where(bh => bh.MaLopHoc == curClassId).ToList().Count);
            foreach (var bh in db.BuoiHocs.Where(bh => bh.MaLopHoc == curClassId).ToList())
            {
                foreach (var hs in listHs)
                {
                    DiemDanh dd = new DiemDanh()
                    {
                        MaBuoiHoc = bh.Ma,
                        MaHocSinh = hs.Ma,
                        DaDiemDanh = false
                    };
                    db.DiemDanhs.Add(dd);
                }
            }
            db.SaveChanges();
            ShowLearnDate();
        }


        public DayOfWeek ConvertToDayOfWeek(string dowStr)
        {
            Console.WriteLine("DOW: " + dowStr.ToString());
            if (dowStr == "Thu hai") return DayOfWeek.Monday;
            else if (dowStr == "Thu ba") return DayOfWeek.Tuesday;
            else if (dowStr == "Thu tu") return DayOfWeek.Wednesday;
            else if (dowStr == "Thu nam") return DayOfWeek.Thursday;
            else if (dowStr == "Thu sau") return DayOfWeek.Friday;
            else if (dowStr == "Thu bay") return DayOfWeek.Saturday;
            else return DayOfWeek.Sunday;
        }
    }
}