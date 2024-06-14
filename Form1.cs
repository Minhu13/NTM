using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTM
{
    public partial class Form1 : Form
    {
        private string connectionSTR = "Data Source=.\\SQLEXPRESS;Initial Catalog=quanlydangky_nhutuanminh;Integrated Security=True";

        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        public Form1()
        {
            InitializeComponent();
        }
        //Câu 1
        private void Form1_Load(object sender, EventArgs e)
        {
            showSK();
            showKH();
            //showPDK();
        }
        private void showKH()
        {
            List<string> gettenkh = new List<string>();
            string query = "SELECT tenkh FROM KhachHang";
            DataTable dt = ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                string tenKH = row["tenkh"].ToString();
                gettenkh.Add(tenKH);
            }

            cb_tenKH.Items.Clear();
            cb_tenKH.Items.AddRange(gettenkh.ToArray());
        }
        private void showSK()
        {
            try
            {
                string query = @"
                     SELECT masukien AS N'Mã sự kiện', 
                            tensukien AS N'Tên sự kiện', 
                            diachi AS N'Địa chỉ', 
                            thoigian AS N'Thời gian'
                    FROM SuKien";

                 DataTable dt = ExecuteQuery(query);

                tbSK.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        //Câu 2
        private void ClearFields()
        {
            txtmkh.Clear();
            txttkh.Clear();
            txtsdt.Clear();
        }
        private void btAddKH_Click(object sender, EventArgs e)
        {
            try
            {
                string makh = txtmkh.Text;
                string tkh = txttkh.Text;
                string sdt = txtsdt.Text;

                bool addSuccess = AddKH(makh, tkh, sdt);

                if (addSuccess)
                {
                    MessageBox.Show("Thêm khách hàng mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showKH();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Không thể thêm khách hàng. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool AddKH(string makh, string tkh, string sdt)
        {
            string query = @"
            INSERT INTO KhachHang (makh, tenkh, dienthoai)
            VALUES (@mkh, @tkh, @sdt);";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@mkh", makh);
                command.Parameters.AddWithValue("@tkh", tkh);
                command.Parameters.AddWithValue("@sdt", sdt);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                return rowsAffected > 0; // Return true if at least one row was inserted into the database
            }
        }
        //Câu 3
        private void btDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                string tenKH = cb_tenKH.SelectedItem.ToString(); 
                string maSuKien = tbSK.CurrentRow.Cells["Mã sự kiện"].Value.ToString();
                string soLuong = txtSoLuong.Text;
                DateTime ngayDangKy = dtpNgayDangKy.Value;

                string maKH = LayMaKhachHang(tenKH);

                if (DangKySuKien(maKH, maSuKien, soLuong, ngayDangKy))
                {
                    MessageBox.Show("Đăng ký sự kiện thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //showPDK();
                }
                else
                {
                    MessageBox.Show("Không thể đăng ký sự kiện. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string LayMaKhachHang(string tenKH)
        {
            string query = "SELECT makh FROM KhachHang WHERE tenkh = @tenKH";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@tenKH", tenKH);

                connection.Open();
                object result = command.ExecuteScalar();
                connection.Close();

                return result != null ? result.ToString() : null; // Trả về null nếu không tìm thấy mã khách hàng
            }
        }

        public bool DangKySuKien(string maKH, string maSuKien, string soLuong, DateTime ngayDangKy)
        {
            string query = @"
        INSERT INTO PhieuDangKy (masukien, makh, ngaydk, soluong )
        VALUES (@maSuKien, @makh, @ngayDangKy, @soLuong);";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@makh", maKH);
                command.Parameters.AddWithValue("@maSuKien", maSuKien);
                command.Parameters.AddWithValue("@soLuong", soLuong);
                command.Parameters.AddWithValue("@ngayDangKy", ngayDangKy);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                return rowsAffected > 0; // Trả về true nếu có ít nhất một dòng được chèn vào cơ sở dữ liệu
            }
        }
        ////
        //private void showPDK()
        //{
        //    try
        //    {
        //        string query = @"
        //             SELECT masukien AS N'Mã sự kiện', 
        //                    makh AS N'Mã khách hàng', 
        //                    ngaydk AS N'Ngày đăng ký', 
        //                    soluong AS N'Số lượng'
        //            FROM PhieuDangKy";

        //        DataTable dt = ExecuteQuery(query);

        //        tbPDK.DataSource = dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi: " + ex.Message);
        //    }
        //}
        ////
        //Câu 4
        private void showHTTTDK()
        {
            try
            {
                string query = @"
                SELECT KhachHang.makh AS 'Mã khách hàng', KhachHang.tenkh AS 'Tên khách hàng', 
                       SuKien.tensukien AS 'Tên sự kiện', PhieuDangKy.soluong AS 'Số lượng', 
                       SuKien.thoigian AS 'Thời gian', SuKien.diachi AS 'Địa chỉ'
                FROM PhieuDangKy
                   JOIN 
                       KhachHang ON PhieuDangKy.makh = KhachHang.makh
                   JOIN 
                       SuKien ON PhieuDangKy.masukien = SuKien.masukien;";

                DataTable dt = ExecuteQuery(query);

                tbAll.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void btTTDK_Click(object sender, EventArgs e)
        {
            showHTTTDK();
        }
    }
}
