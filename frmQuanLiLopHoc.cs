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
        public frmQuanLiLopHoc()
        {
            InitializeComponent();
        }

        private void frmQuanLiLopHoc_Load(object sender, EventArgs e)
        {
            db.CaHocs.Load();
            db.BuoiHocs.Load();
            db.LopHocs.Load();
            caHocBindingSource.DataSource = db.CaHocs.Local;
            buoiHocBindingSource.DataSource = db.BuoiHocs.Local;
            lopHocBindingSource.DataSource = db.LopHocs.Local;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvContent.Columns[e.ColumnIndex].Name == "ChiTiet")
            {
                //Console.WriteLine("Data: " + dgvContent.SelectedCells[0].Value.ToString());
                int maBuoiHoc = int.Parse(dgvContent.Rows[e.RowIndex].Cells[0].Value.ToString());
                frmQuanLiBuoiHoc frmQuanLiBuoiHoc = new frmQuanLiBuoiHoc(maBuoiHoc);
                frmQuanLiBuoiHoc.Show();
            }
        }
    }
}