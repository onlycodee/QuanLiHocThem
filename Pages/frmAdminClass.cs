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
        LopHoc curClass = null;
        public frmAdminClass()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
        }
        private static readonly Lazy<frmAdminClass> lazy = new Lazy<frmAdminClass>(() => new frmAdminClass());
        public static frmAdminClass Instance
        {
            get
            {
                return lazy.Value;
            }
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
            if (e.RowIndex < 0 || e.RowIndex >= dgvContent.RowCount) return;
            int classId = int.Parse(dgvContent.Rows[e.RowIndex].Cells[1].Value.ToString());
            if (dgvContent.Columns[e.ColumnIndex].Name == "ChiTiet")
            {
                new frmAdminClassDetail(classId).Show();
            }
            curClass = db.LopHocs.Where(lh => lh.Ma == classId).FirstOrDefault();
            tbSoHocSinh.Text = curClass.SoLuongHocSinh.ToString();
            tbHocPhi1Buoi.Text = curClass.HocPhiMotBuoi.ToString();
            cbTrangThai.Checked = curClass.DaKetThuc.Value;

            Console.WriteLine("Da ket thuc: " + curClass.DaKetThuc.Value);

            cboKhoaHoc.SelectedValue = curClass.KhoaHoc.Ma;
            cboMonHoc.SelectedValue = curClass.MonHoc.Ma;
            cboGiaoVien.SelectedValue = curClass.GiaoVien.Ma;
            cboMucHocPhi.SelectedValue = curClass.MucHocPhi.Ma;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            dgvContent.Enabled = false;
            ResetAllTextboxes();
            curClass = null;
        }
        void ResetAllTextboxes()
        {
            tbSoHocSinh.Text = "";
            tbHocPhi1Buoi.Text = "";
            cbTrangThai.Checked = false;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (curClass == null)
            {
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
                db.LopHocs.Add(lopHoc);
            } else
            {
                curClass.SoLuongHocSinh = int.Parse(tbSoHocSinh.Text);
                curClass.HocPhiMotBuoi = int.Parse(tbHocPhi1Buoi.Text);
                curClass.MaKhoaHoc = int.Parse(cboKhoaHoc.SelectedValue.ToString());
                curClass.MaGiaoVien = int.Parse(cboGiaoVien.SelectedValue.ToString());
                curClass.MaMonHoc = int.Parse(cboMonHoc.SelectedValue.ToString());
                curClass.MaMucHocPhi = int.Parse(cboMucHocPhi.SelectedValue.ToString());
                curClass.DaKetThuc = cbTrangThai.Checked;
            }
            db.SaveChanges();
            BoundDataSource();
            dgvContent.Enabled = true;
        }
        private void DataGridView_EnabledChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (!dgv.Enabled)
            {
                dgv.DefaultCellStyle.BackColor = SystemColors.Control;
                dgv.DefaultCellStyle.ForeColor = SystemColors.GrayText;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.GrayText;
                dgv.CurrentCell = null;
                dgv.ReadOnly = true;
                dgv.EnableHeadersVisualStyles = false;
            }
            else
            {
                dgv.DefaultCellStyle.BackColor = SystemColors.Window;
                dgv.DefaultCellStyle.ForeColor = SystemColors.ControlText;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Window;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = SystemColors.ControlText;
                dgv.ReadOnly = false;
                dgv.EnableHeadersVisualStyles = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (curClass != null)
            {
                //db.LopHocs.Where(lh => lh.Ma == curClass.Ma).FirstOrDefault();
                db.LopHocs.Remove(curClass);
                db.SaveChanges();
                curClass = null;
                BoundDataSource();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            dgvContent.Enabled = true;
        }
    }
}