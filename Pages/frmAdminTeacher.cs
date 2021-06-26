using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using DevExpress.XtraEditors;
using System.Data.Entity.Infrastructure;
using QuanLiHocThem.Pages;

namespace QuanLiHocThem
{
    public partial class frmAdminTeacher : DevExpress.XtraEditors.XtraForm
    {
        private frmAdminTeacher()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
        }
        private static readonly Lazy<frmAdminTeacher> lazy = new Lazy<frmAdminTeacher>(() => new frmAdminTeacher());
        public static frmAdminTeacher Instance
        {
            get
            {
                return lazy.Value;
            }
        }
        QuanLiHocThemEntities db = new QuanLiHocThemEntities();
        DateTimePicker dtp;

        private void frmAdminTeacher_Load(object sender, EventArgs e)
        {
            db.GiaoViens.Load();
            db.MonHocs.Load();
            db.MucThanhToans.Load();
            giaoVienBS.DataSource = db.GiaoViens.Local;//.GiaoViens.ToList();
            monHocBS.DataSource = db.MonHocs.Local;     //.MonHocs.ToList();
            mucThanhToanBS.DataSource = db.MucThanhToans.Local; //db.MucThanhToans.ToList();
        }
        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex > 9) return;
            var subjectCBO = 
                dgvGiaoVien.Rows[e.RowIndex].Cells[8] as System.Windows.Forms.DataGridViewComboBoxCell;
            tbSubject.Text = db.MonHocs.Where(mh => mh.Ma.ToString() == subjectCBO.Value.ToString()).FirstOrDefault().Ten;
            if (dtp != null) dtp.Visible = false;
            if (e.ColumnIndex >= 0 && dgvGiaoVien.Columns[e.ColumnIndex].DataPropertyName == nameof(GiaoVien.NgaySinh))
            {
                // initialize DateTimePicker
                dtp = new DateTimePicker();
                dtp.Format = DateTimePickerFormat.Short;
                dtp.Visible = true;
                if (dgvGiaoVien.CurrentCell.Value != null)
                {
                    dtp.Value = DateTime.Parse(dgvGiaoVien.CurrentCell.Value.ToString());
                }

                // set size and location
                var rect = dgvGiaoVien.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dtp.Size = new Size(rect.Width, rect.Height);
                dtp.Location = new Point(rect.X, rect.Y);

                // attach events
                dtp.CloseUp += new EventHandler(dtp_CloseUp);
                dtp.TextChanged += new EventHandler(dtp_OnTextChange);

                dgvGiaoVien.Controls.Add(dtp);
            }
        }
        // on text change of dtp, assign back to cell
        private void dtp_OnTextChange(object sender, EventArgs e)
        {
            dgvGiaoVien.CurrentCell.Value = dtp.Text.ToString();
        }

        // on close of cell, hide dtp
        void dtp_CloseUp(object sender, EventArgs e)
        {
            dtp.Visible = false;
        }

        private void barDockControlTop_Click(object sender, EventArgs e)
        {

        }

        private void barDockControlBottom_Click(object sender, EventArgs e)
        {

        }

        private void barDockControlLeft_Click(object sender, EventArgs e)
        {

        }

        private void barDockControlRight_Click(object sender, EventArgs e)
        {

        }

        private void dgvGiaoVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textEdit7_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barDockControl1_Click(object sender, EventArgs e)
        {

        }

        private void barDockControl2_Click(object sender, EventArgs e)
        {

        }

        private void barDockControl3_Click(object sender, EventArgs e)
        {

        }

        private void barDockControl4_Click(object sender, EventArgs e)
        {

        }

        private void giaoVienBS_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void monHocBS_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void mucThanhToanBS_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            giaoVienBS.AddNew();
        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            giaoVienBS.AddNew();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            HashSet<string> userNameSet = new HashSet<string>();
            foreach (var curTeacher in db.GiaoViens.ToList())
            {
                Console.WriteLine("Ten dang nhap: " + curTeacher.TenDangNhap);
                if (userNameSet.Contains(curTeacher.TenDangNhap))
                {
                    XtraMessageBox.Show("Ten dang nhap: \"" + curTeacher.TenDangNhap + "\" da ton tai!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                } else
                {
                    userNameSet.Add(curTeacher.TenDangNhap);
                }
            }
            db.SaveChanges();
            XtraMessageBox.Show("Luu thay doi thanh cong", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa dữ liệu hiện tại không?", "Message", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                giaoVienBS.RemoveCurrent();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
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
            giaoVienBS.ResetBindings(false);
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}