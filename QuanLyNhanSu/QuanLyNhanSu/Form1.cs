using QuanLyNhanSu.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class Form1 : Form
    {
        BindingSource DSCV = new BindingSource(); //DSCV : danh sách chức vụ
        public Form1()
        {
            InitializeComponent();
            load();
        }

        void load()
        {
            dtgvDanhSachChucVu.DataSource = DSCV;
            loadDSCV();
            BindingChucVu();
        }
        #region Method
        void loadDSCV()
        {
            DSCV.DataSource = ChucVu_DAO.Instance.HienThiDanhSachChucVu();

        }
        void KiemTraLoi()
        {
            if (string.IsNullOrEmpty(txtMaChucVu.Text))
            {
                MessageBox.Show("Mời bạn điền mã chức vụ");
                return;
            }
            if (string.IsNullOrEmpty(txtTenChucVu.Text))
            {
                MessageBox.Show("Mời bạn điền tên chức vụ");
                return;
            }
        }
        void Clear()
        {
            txtTenChucVu.Text = "";
            txtMaChucVu.Text = "";
        }
        void BindingChucVu()
        {
            txtMaChucVu.DataBindings.Clear();
            txtTenChucVu.DataBindings.Clear();
            txtMaChucVu.DataBindings.Add(new Binding("Text", dtgvDanhSachChucVu.DataSource, "MaChucVu", true, DataSourceUpdateMode.Never)); //"MaChucVu" tên cột dữ liệu k được phép sai
            txtTenChucVu.DataBindings.Add(new Binding("Text", dtgvDanhSachChucVu.DataSource, "ChucVu", true, DataSourceUpdateMode.Never));
            
        }
        
        #endregion

        #region Event Handle
        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có đồng ý muốn Thêm dịch vụ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    KiemTraLoi();
                    
                    string machucvu = txtMaChucVu.Text;
                    string tenchucvu = txtTenChucVu.Text;
                   
                    if (ChucVu_DAO.Instance.ThemChucvu(machucvu,tenchucvu))
                    {
                        MessageBox.Show("Thêm dịch vụ thành công");
                        loadDSCV();
                    }
                    else
                    {
                        MessageBox.Show("Thêm dịch vụ không thành công");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
        

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có đồng ý sửa chức vụ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    KiemTraLoi();

                    string machucvu = txtMaChucVu.Text;
                    string tenchucvu = txtTenChucVu.Text;

                    if (ChucVu_DAO.Instance.SuaChucVu(machucvu, tenchucvu))
                    {
                        MessageBox.Show("Sửa Chức vụ thành công");
                        loadDSCV();
                    }
                    else
                    {
                        MessageBox.Show("Sửa Chức vụ không thành công");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có đồng ý xóa chức vụ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    KiemTraLoi();

                    string machucvu = txtMaChucVu.Text;
                   

                    if (ChucVu_DAO.Instance.XoaChucvu(machucvu))
                    {
                        MessageBox.Show("Xóa Chức vụ thành công");
                        loadDSCV();

                    }
                    else
                    {
                        MessageBox.Show("Xóa Chức vụ không thành công");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNoiDungTimKiem.Text))
            {
                MessageBox.Show("Mời bạn nhập tên chức vụ muốn tìm");
                return;
            }
            string tenchucvu = txtNoiDungTimKiem.Text;

            dtgvDanhSachChucVu.DataSource = ChucVu_DAO.Instance.TimKiemTheoTenChucVu(tenchucvu);
            loadDSCV();
        }
        private void dtgvDanhSachChucVu_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BindingChucVu();
        }

        #endregion


    }
}
