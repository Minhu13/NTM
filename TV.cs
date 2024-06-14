using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTM
{
    public class TV
    {
        DataClasses1DataContext db = new DataClasses1DataContext(@"Data Source=.\SQLEXPRESS;Initial Catalog=test;Integrated Security=True");

        // Lấy danh sách sản phẩm
        public IEnumerable<Hang> GetHangs()
        {
            return db.Hangs.ToList();
        }

        // Thêm sản phẩm mới
        public void ThemHang(Hang hang)
        {
            db.Hangs.InsertOnSubmit(hang);
            db.SubmitChanges();
        }

        // Sửa sản phẩm
        public void SuaHang(int id, Hang hangMoi)
        {
            Hang hangCu = db.Hangs.SingleOrDefault(h => h.Id == id);
            if (hangCu != null)
            {
                hangCu.Sanpham = hangMoi.Sanpham;
                hangCu.Soluong = hangMoi.Soluong;
                hangCu.Hoadon = hangMoi.Hoadon;
                // Thêm các trường khác nếu cần

                db.SubmitChanges();
            }
        }

        // Xóa sản phẩm
        public void XoaHang(int id)
        {
            Hang hang = db.Hangs.SingleOrDefault(h => h.Id == id);
            if (hang != null)
            {
                db.Hangs.DeleteOnSubmit(hang);
                db.SubmitChanges();
            }
        }

        // Lấy danh sách hóa đơn
        public IEnumerable<Hoadon> GetHoadons()
        {
            return db.Hoadons.ToList();
        }

        // Thêm hóa đơn mới
        public void ThemHoadon(Hoadon hoadon)
        {
            db.Hoadons.InsertOnSubmit(hoadon);
            db.SubmitChanges();
        }

        // Sửa hóa đơn
        public void SuaHoadon(int id, Hoadon hoadonMoi)
        {
            Hoadon hoadonCu = db.Hoadons.SingleOrDefault(h => h.Id == id);
            if (hoadonCu != null)
            {
                hoadonCu.Ngay = hoadonMoi.Ngay;
                hoadonCu.Mota = hoadonMoi.Mota;
                // Thêm các trường khác nếu cần

                db.SubmitChanges();
            }
        }

        // Xóa hóa đơn
        public void XoaHoadon(int id)
        {
            Hoadon hoadon = db.Hoadons.SingleOrDefault(h => h.Id == id);
            if (hoadon != null)
            {
                db.Hoadons.DeleteOnSubmit(hoadon);
                db.SubmitChanges();
            }
        }
    }

    // Định nghĩa các lớp thực thể nếu chúng chưa được tạo tự động bởi LINQ to SQL
    public partial class Hang
    {
        public int Id { get; set; }
        public string Sanpham { get; set; }
        public int Soluong { get; set; }
        public int Hoadon { get; set; }
    }

    public partial class Hoadon
    {
        public int Id { get; set; }
        public DateTime Ngay { get; set; }
        public string Mota { get; set; }
    }
}
