using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
    public class TaiKhoan_DAO
    {
        private static TaiKhoan_DAO instance;

        public static TaiKhoan_DAO Instance
        {
            get { if (instance == null) instance = new TaiKhoan_DAO(); return TaiKhoan_DAO.instance; }
            private set { TaiKhoan_DAO.instance = value; }
        }
        private TaiKhoan_DAO() { }

        public bool Login(string tenTaiKhoan, string matKhau)
        {
            //byte[] temp = ASCIIEncoding.ASCII.GetBytes(matKhau);
            //byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            //string hasPass = "";
            //foreach (byte item in hasData)
            //{
            //    hasPass += item;
            //} //Bảo mật đăng nhập


            bool tontai = false;
            string query = string.Format("exec PROC_Login N'{0}' , N'{1}' ", tenTaiKhoan,matKhau);

            DataTable result = DataProVider.Instance.ExecuteQuery(query);
            if (result.Rows[0][0].ToString() == "1")
            {
                tontai = true;
            }

            return tontai;
        }
        public bool KiemTraTenTaiKhoanTonTai(int id,string tentaikhoan)
        {
            bool tontai= false;
            string query = string.Format("SELECT COUNT(*)  FROM tbl_TaiKhoan where id={0} and TenTaiKhoan=N'{1}' ", id,tentaikhoan);

            DataTable result = DataProVider.Instance.ExecuteQuery(query);
            if (result.Rows[0][0].ToString() == "1")
            {
                tontai = true;
            }

            return tontai;
        }
        public TaiKhoan_DTO LayTaiKhoanBoiTenDangNhap(string tenTaiKhoan)
        {
            DataTable data = DataProVider.Instance.ExecuteQuery("SELECT * FROM dbo.tbl_TaiKhoan WHERE TenTaiKhoan = '" + tenTaiKhoan + "'");
            foreach (DataRow item in data.Rows)
            {
                return new TaiKhoan_DTO(item);
            }
            return null;
        }
        public List<TaiKhoan_DTO> HienThiDanhSachTaiKhoan()
        {
            List<TaiKhoan_DTO> list = new List<TaiKhoan_DTO>();
            string query = string.Format("Select * from tbl_TaiKhoan order by id ");

            System.Data.DataTable data = DataProVider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                TaiKhoan_DTO dstk = new TaiKhoan_DTO(item);
                list.Add(dstk);
            }
            return list;
        }
        public bool ThemTaiKhoan(string TenTaiKhoan, string TenHienThi, string MatKhau, int CapDoTaiKhoan)
        {
            string query = string.Format("INSERT dbo.tbl_TaiKhoan(TenTaiKhoan,TenHienThi,MatKhau,capDoTaiKhoan )VALUES( N'{0}' ,N'{1}',N'{2}',{3})", TenTaiKhoan, TenHienThi, MatKhau, CapDoTaiKhoan);
            int result = DataProVider.Instance.ExecuteNonquery(query);
            return result > 0;
        }
        public bool SuaTaiKhoan(string TenHienThi, int CapDoTaiKhoan, string MatKhau,string TenTaiKhoan, int id)
        {
            string query = string.Format("UPDATE dbo.tbl_TaiKhoan SET TenHienThi =N'{0}',capDoTaiKhoan ={1},TenTaiKhoan=N'{2}',MatKhau=N'{3}' WHERE id={4}", TenHienThi, CapDoTaiKhoan, MatKhau,TenTaiKhoan , id);
            int result = DataProVider.Instance.ExecuteNonquery(query);
            return result > 0;
        }
        public bool XoaTaiKhoan(int id)
        {
            string query = string.Format("DELETE dbo.tbl_TaiKhoan WHERE id ={0}", id);
            int result = DataProVider.Instance.ExecuteNonquery(query);
            return result > 0;
        }
        public List<TaiKhoan_DTO> TimKiemTheoTenTaiKhoan(string TenTaiKhoan)
        {
            List<TaiKhoan_DTO> list = new List<TaiKhoan_DTO>();

            string query = string.Format("SELECT * FROM tbl_TaiKhoan WHERE dbo.TimKiem(TenTaiKhoan) LIKE N'%' + dbo.TimKiem(N'{0}') + '%'", TenTaiKhoan);

            DataTable table = DataProVider.Instance.ExecuteQuery(query);

            foreach (DataRow item in table.Rows)
            {
                TaiKhoan_DTO TK = new TaiKhoan_DTO(item);
                list.Add(TK);
            }
            return list;
        }
    }
}
