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
    public partial class frm_DSSV_TheoLop : Form
    {
        databaseDataContext db = new databaseDataContext("Data Source=DESKTOP-RDPV4HN\\GBAO;Initial Catalog=quanlysv;User ID=sa;Password=Giabao2005@;TrustServerCertificate=True");
        string _malop;
        string _tenLop;

        public frm_DSSV_TheoLop(string malop, string tenLop)
        {
            InitializeComponent();
            _malop = malop;
            _tenLop = tenLop;
        }

        private void frm_DSSV_TheoLop_Load(object sender, EventArgs e)
        {
            lbl_tieuDe.Text = "Danh sách sinh viên: " + _tenLop;

            try
            {
                var dsSV = db.tbl_sinhviens
                             .Where(sv => sv.malop == _malop)
                             .OrderBy(sv => sv.id)
                             .Select(sv => new
                             {
                                 sv.id,
                                 sv.hoten,
                                 sv.gioitinh,
                                 sv.ngaysinh,
                                 sv.malop
                             })
                             .ToList();

                dgv_DSSV.DataSource = dsSV;

                dgv_DSSV.Columns["id"].HeaderText = "Mã SV";
                dgv_DSSV.Columns["hoten"].HeaderText = "Họ tên";
                dgv_DSSV.Columns["gioitinh"].HeaderText = "Giới tính";
                dgv_DSSV.Columns["ngaysinh"].HeaderText = "Ngày sinh";
                dgv_DSSV.Columns["malop"].HeaderText = "Lớp";

                lbl_tongSo.Text = "Tổng số " + dsSV.Count + " sinh viên";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
