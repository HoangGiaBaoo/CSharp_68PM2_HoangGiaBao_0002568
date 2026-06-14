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
    public partial class UC_QLLH : UserControl
    {
        databaseDataContext db = new databaseDataContext("Data Source=DESKTOP-RDPV4HN\\GBAO;Initial Catalog=quanlysv;User ID=sa;Password=Giabao2005@;TrustServerCertificate=True");
        int _selectedId = 0;
        List<tbl_lophoc> _allData;
        int _currentPage = 1;
        int _pageSize = 3;
        int _totalPages = 1;

        public UC_QLLH()
        {
            InitializeComponent();
        }

        private void UC_QLLH_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                _allData = db.tbl_lophocs
                             .OrderBy(lh => lh.malop)
                             .ToList();
                ApplyPaging();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyPaging()
        {
            _totalPages = Math.Max(1, (int)Math.Ceiling(_allData.Count / (double)_pageSize));
            if (_currentPage < 1) _currentPage = 1;
            if (_currentPage > _totalPages) _currentPage = _totalPages;

            dgv_DSLH.DataSource = _allData
                .Skip((_currentPage - 1) * _pageSize)
                .Take(_pageSize)
                .Select(lh => new
                {
                    lh.id,
                    lh.malop,
                    lh.tenlop,
                    lh.ghichu
                })
                .ToList();

            lb_trang.Text = _currentPage + "/" + _totalPages;
            lb_soBanGhi.Text = _allData.Count + " bản ghi";
        }

        private void LoadLopHocTheoTu(string tuKhoa)
        {
            string tk = tuKhoa.Trim();
            _allData = db.tbl_lophocs
                          .Where(lh =>
                              lh.id.ToString().Contains(tk) ||
                              lh.malop.Contains(tk) ||
                              lh.tenlop.Contains(tk))
                          .OrderBy(lh => lh.malop)
                          .ToList();
            _currentPage = 1;
            ApplyPaging();
        }

        private void ClearForm()
        {
            txt_maID.Clear();
            txt_maLop.Clear();
            txt_tenLop.Clear();
            txt_ghiChu.Clear();

            _selectedId = 0;
            txt_maLop.Focus();
        }

        private void dgv_DSLH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            var row = dgv_DSLH.Rows[e.RowIndex];

            _selectedId = Convert.ToInt32(row.Cells["id"].Value);
            txt_maID.Text = _selectedId.ToString();
            txt_maLop.Text = row.Cells["malop"].Value?.ToString();
            txt_tenLop.Text = row.Cells["tenlop"].Value?.ToString();
            txt_ghiChu.Text = row.Cells["ghichu"].Value?.ToString();

            txt_maID.Enabled = false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            tbl_lophoc lophoc = new tbl_lophoc();
            lophoc.malop = txt_maLop.Text.Trim();
            lophoc.tenlop = txt_tenLop.Text.Trim();
            lophoc.ghichu = txt_ghiChu.Text.Trim();

            try
            {
                db.tbl_lophocs.InsertOnSubmit(lophoc);
                db.SubmitChanges();
                MessageBox.Show("Thêm mới lớp học thành công");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            {
                MessageBox.Show("Vui lòng chọn lớp học cần sửa!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var lh = db.tbl_lophocs.FirstOrDefault(x => x.id == _selectedId);
            if (lh == null) { MessageBox.Show("Không tìm thấy lớp học!"); return; }

            lh.malop = txt_maLop.Text.Trim();
            lh.tenlop = txt_tenLop.Text.Trim();
            lh.ghichu = txt_ghiChu.Text.Trim();

            try
            {
                db.SubmitChanges();
                MessageBox.Show("Cập nhật thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            {
                MessageBox.Show("Vui lòng chọn lớp học cần xóa!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show(
                "Bạn có chắc muốn xóa lớp học '" + txt_tenLop.Text + "'?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            var lh = db.tbl_lophocs.FirstOrDefault(x => x.id == _selectedId);
            if (lh == null) { MessageBox.Show("Không tìm thấy lớp học!"); return; }

            try
            {
                db.tbl_lophocs.DeleteOnSubmit(lh);
                db.SubmitChanges();
                MessageBox.Show("Xóa thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btn_trangDau_Click(object sender, EventArgs e)
        {
            _currentPage = 1;
            ApplyPaging();
        }

        private void btn_trangTruoc_Click(object sender, EventArgs e)
        {
            _currentPage--;
            ApplyPaging();
        }

        private void btn_trangSau_Click(object sender, EventArgs e)
        {
            _currentPage++;
            ApplyPaging();
        }

        private void btn_trangCuoi_Click(object sender, EventArgs e)
        {
            _currentPage = _totalPages;
            ApplyPaging();
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            LoadLopHocTheoTu(txt_timKiem.Text);
        }

        private void btn_xemDanhSach_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            {
                MessageBox.Show("Vui lòng chọn lớp!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string malop = txt_maLop.Text.Trim();
            string tenLop = txt_tenLop.Text.Trim();

            frm_DSSV_TheoLop frm = new frm_DSSV_TheoLop(malop, tenLop);
            frm.ShowDialog();
        }
    }
}
