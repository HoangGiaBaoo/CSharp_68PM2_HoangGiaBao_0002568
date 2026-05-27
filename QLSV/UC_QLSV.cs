using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class UC_QLSV : UserControl
    {
        databaseDataContext db = new databaseDataContext("Data Source=DESKTOP-RDPV4HN\\GBAO;Initial Catalog=quanlysv;User ID=sa;Password=Giabao2005@;TrustServerCertificate=True");
        public UC_QLSV()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UC_QLSV_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadDSLH4CBX();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mSSV = txt_maID.Text;
            string hoTen = txt_hoTen.Text;
            string gioiTinh = cbo_gioiTinh.Text;

            tbl_sinhvien sinhvien = new tbl_sinhvien();
            sinhvien.id = mSSV;
            sinhvien.hoten = hoTen;
            sinhvien.gioitinh = gioiTinh;
            sinhvien.ngaysinh = ngaySinh.Value.Date;
            sinhvien.malop = cbo_lop.SelectedValue.ToString();

            try
            {
                db.tbl_sinhviens.InsertOnSubmit(sinhvien);
                db.SubmitChanges();
                MessageBox.Show("Thêm mới sinh viên thành công");
                LoadData();
            } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        public void LoadData()
        {
            List<tbl_sinhvien> dSSV = db.tbl_sinhviens.ToList();
            dgv_DSSV.DataSource = dSSV;
        }
        public void LoadDSLH4CBX()
        {
            List<tbl_lophoc> dSLH = db.tbl_lophocs.ToList();
            cbo_lop.DataSource = dSLH;
            cbo_lop.DisplayMember = "tenlop";
            cbo_lop.ValueMember = "malop";
        }
    }
}
