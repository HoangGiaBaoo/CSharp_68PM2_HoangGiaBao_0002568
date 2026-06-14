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
        string _selectedMaSV;
        List<tbl_sinhvien> _allData;
        int _currentPage = 1;
        int _pageSize = 3;
        int _totalPages = 1;
        public UC_QLSV()
        {
            InitializeComponent();
        }

        private void UC_QLSV_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadDSLH4CBX();
        }

        private void btn_them_Click(object sender, EventArgs e)
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
            try
            {
                _allData = db.tbl_sinhviens
                             .OrderBy(sv => sv.id)
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

            dgv_DSSV.DataSource = _allData
                .Skip((_currentPage - 1) * _pageSize)
                .Take(_pageSize)
                .Select(sv => new
                {
                    sv.id,
                    sv.hoten,
                    sv.gioitinh,
                    sv.ngaysinh,
                    sv.malop
                })
                .ToList();

            lb_trang.Text = _currentPage + "/" + _totalPages;
            lb_soBanGhi.Text = _allData.Count + " bản ghi";
        }

        private void LoadSinhVienTheoTu(string tuKhoa)
        {
            string tk = tuKhoa.Trim();
            _allData = db.tbl_sinhviens
                          .Where(sv =>
                              sv.id.Contains(tk) ||
                              sv.hoten.Contains(tk) ||
                              sv.malop.Contains(tk))
                          .OrderBy(sv => sv.id)
                          .ToList();
            _currentPage = 1;
            ApplyPaging();
        }
        public void LoadDSLH4CBX()
        {
            List<tbl_lophoc> dSLH = db.tbl_lophocs.ToList();
            cbo_lop.DataSource = dSLH;
            cbo_lop.DisplayMember = "tenlop";
            cbo_lop.ValueMember = "malop";
        }

        private void ClearForm()
        {
            txt_maID.Clear();
            txt_hoTen.Clear();
            ngaySinh.Value = DateTime.Now;
            cbo_gioiTinh.SelectedIndex = -1;
            cbo_lop.SelectedIndex = -1;

            _selectedMaSV = "";
            txt_hoTen.Focus();
        }

        private void dgv_DSSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) {
                return;
            }
            var row = dgv_DSSV.Rows[e.RowIndex];

            _selectedMaSV = row.Cells["id"].Value.ToString();
            txt_maID.Text = _selectedMaSV;
            txt_hoTen.Text = row.Cells["hoten"].Value.ToString();
            cbo_gioiTinh.Text = row.Cells["gioitinh"].Value.ToString();

            txt_maID.Enabled = false;

            string malop = row.Cells["malop"].Value?.ToString().Trim();
            if (!string.IsNullOrEmpty(malop))
                cbo_lop.SelectedValue = malop;
            else if (cbo_lop.Items.Count > 0)
                cbo_lop.SelectedIndex = 0;

            if (row.Cells["ngaysinh"].Value is DateTime dt)
                ngaySinh.Value = dt;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedMaSV))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var sv = db.tbl_sinhviens.FirstOrDefault(x => x.id == _selectedMaSV);
            if (sv == null) { MessageBox.Show("Không tìm thấy sinh viên!"); return; }

            sv.hoten = txt_hoTen.Text.Trim();
            sv.ngaysinh = ngaySinh.Value.Date;
            sv.gioitinh = cbo_gioiTinh.Text;
            sv.malop = cbo_lop.SelectedValue?.ToString()?.Trim();

            try
            {
                db.SubmitChanges();
                MessageBox.Show("Cập nhật thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearForm();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedMaSV))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show(
                "Bạn có chắc muốn xóa sinh viên '" + txt_hoTen.Text + "'?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            var sv = db.tbl_sinhviens.FirstOrDefault(x => x.id == _selectedMaSV);
            if (sv == null) { MessageBox.Show("Không tìm thấy sinh viên!"); return; }

            try
            {
                db.tbl_sinhviens.DeleteOnSubmit(sv);
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
            LoadSinhVienTheoTu(txt_timKiem.Text);
        }
    }
}
