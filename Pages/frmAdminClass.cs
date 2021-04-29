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
            khoaHocBindingSource.DataSource = db.KhoaHocs.ToList();
            giaoVienBindingSource.DataSource = db.GiaoViens.ToList();
            monHocBindingSource.DataSource = db.MonHocs.ToList();
            mucHocPhiBindingSource.DataSource = db.MucHocPhis.ToList();
        }

        private void dgvContent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int classId = int.Parse(dgvContent.Rows[e.RowIndex].Cells[0].Value.ToString());
            LopHoc curClass = db.LopHocs.Where(lh => lh.Ma == classId).FirstOrDefault();
            tbMa.Text = curClass.Ma.ToString();
            tbSoHocSinh.Text = curClass.SoLuongHocSinh.ToString();
            tbHocPhi1Buoi.Text = curClass.HocPhiMotBuoi.ToString();
            cbTrangThai.Checked = curClass.DaKetThuc.Value;
            cboKhoaHoc.SelectedValue = curClass.KhoaHoc.Ma;
            cboMonHoc.SelectedValue = curClass.MonHoc.Ma;
            cboGiaoVien.SelectedValue = curClass.GiaoVien.Ma;
            cboMucHocPhi.SelectedValue = curClass.MucHocPhi.Ma;
            Console.WriteLine("Muc hoc phi: " + curClass.MucHocPhi.Ma);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            dgvContent.Enabled = false;
            ResetAllTextboxes();
        }
        void ResetAllTextboxes()
        {
            tbSoHocSinh.Text = "";
            cbTrangThai.Checked = false;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int maLopHoc = int.Parse(tbMa.Text);
            LopHoc lopHoc = new LopHoc()
            {
                SoLuongHocSinh = int.Parse(tbSoHocSinh.Text),
                HocPhiMotBuoi = int.Parse(tbHocPhi1Buoi.Text),
                MaKhoaHoc = int.Parse(cboKhoaHoc.SelectedValue.ToString()),
                MaGiaoVien = int.Parse(cboGiaoVien.SelectedValue.ToString()),
                MaMonHoc = int.Parse(cboMonHoc.SelectedValue.ToString()),
                MaMucHocPhi = int.Parse(cboMucHocPhi.SelectedValue.ToString()),
                DaKetThuc = cbTrangThai.Checked
            };
        }
    }
}