using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
    public class ChucVu_DAO
    {
        private static ChucVu_DAO instance;

        public static ChucVu_DAO Instance
        {
            get { if (instance == null) instance = new ChucVu_DAO(); return ChucVu_DAO.instance; }
            private set { ChucVu_DAO.instance = value; }
        }

        private ChucVu_DAO() { }// mấy cái bên trên giải thích dài dòng. ae cứ copy rồi đổi tên class cho nhanh

        //Thêm, Sửa ,Xóa như nhau ae cũng coppy rồi đổi
        //Mấy câu query thì check bên sql đúng rồi hãy paste lại cho đỡ lỗi

        //Kiem tra mã chức vụ đã tồn tại trong hệ thống hay chưa
        public bool kiemTraMaChucVuTrungNhau(String MaChucVu)
        {
            bool tontai = false;
            string query = string.Format("SELECT COUNT(*)  FROM tbl_ChucVu where MaChucVu=N'{0}' ", MaChucVu);
            DataTable data = DataProVider.Instance.ExecuteQuery(query);
            if (data.Rows[0][0].ToString() == "1")
            {
                tontai = true;
            }
            return tontai;

        }
        public bool ThemChucvu(string MaChucVu,string ChucVu)
        {
            string query = string.Format("INSERT tbl_ChucVu(MaChucVu,ChucVu)VALUES(N'{0}', N'{1}')", MaChucVu,ChucVu);//{0},{1} là index trong string.format bắt đầu từ 0
            int result = DataProVider.Instance.ExecuteNonquery(query);
            return result > 0;
        }
        public bool SuaChucVu(string MaChucVu, string ChucVu)
        {
            string query = string.Format("UPDATE tbl_ChucVu set ChucVu=N'{0}' where MaChucVu=N'{1}'",ChucVu,MaChucVu);
            int result = DataProVider.Instance.ExecuteNonquery(query);
            return result > 0;
        }
        public bool XoaChucvu(string MaChucVu)
        {
            
            string query = string.Format("DELETE tbl_ChucVu where MaChucVu=N'{0}' ", MaChucVu);
            int result = DataProVider.Instance.ExecuteNonquery(query);
            return result > 0;
        }

        public List<ChucVu_DTO> HienThiDanhSachChucVu() //Lấy danh sách ChucVu
        {
            List<ChucVu_DTO> list = new List<ChucVu_DTO>();
            string query = string.Format("Select * from tbl_ChucVu order by MaChucVu");

            System.Data.DataTable data = DataProVider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ChucVu_DTO dssp = new ChucVu_DTO(item);
                list.Add(dssp);
            }
            return list;
        }
        public List<ChucVu_DTO> TimKiemTheoTenChucVu(string TenChucVu)
        {
            List<ChucVu_DTO> list = new List<ChucVu_DTO>();

            string query = string.Format("SELECT * FROM tbl_ChucVu WHERE dbo.TimKiem(ChucVu) LIKE N'%' + dbo.TimKiem(N'{0}') + '%'", TenChucVu);

            DataTable table = DataProVider.Instance.ExecuteQuery(query);

            foreach (DataRow item in table.Rows)
            {
                ChucVu_DTO TDV = new ChucVu_DTO(item);
                list.Add(TDV);
            }
            return list;
        }

    }
}
