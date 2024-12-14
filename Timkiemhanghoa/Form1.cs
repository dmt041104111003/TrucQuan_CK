using ClosedXML.Excel;
using DocumentFormat.OpenXml.Math;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timkiemhanghoa
{
    public partial class Form1 : Form
    {
        Classes.DataProcesser dtBase = new Classes.DataProcesser();
        public Form1()
        {
            InitializeComponent();
            LoadChatLieu();
        }

        private void tbTu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void tbDen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
          
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                this.Close();
            }
        }
        private void LoadChatLieu()
        {
            try
            {
                string query = "SELECT TenChatLieu FROM tblChatLieu";
                DataTable dtChatLieu = dtBase.ReadData(query);

                foreach (DataRow row in dtChatLieu.Rows)
                {
                    cbChatlieu.Items.Add(row["TenChatLieu"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải chất liệu: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbChatlieu_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        #region "Nen vang"
        private void tbMahang_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.BackColor = Color.Yellow;
        }

        private void tbMahang_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.BackColor = Color.White;
        }

        private void tbTu_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.BackColor = Color.Yellow;
        }

        private void tbTu_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.BackColor = Color.White;
        }

        private void tbDen_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.BackColor = Color.Yellow;
        }

        private void tbDen_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.BackColor = Color.White;
        }

        private void tbTenhang_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.BackColor = Color.Yellow;
        }

        private void tbTenhang_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.BackColor = Color.White;
        }

       

        private void cbChatlieu_Enter(object sender, EventArgs e)
        {
         
        }

        private void cbChatlieu_Leave(object sender, EventArgs e)
        {
       
        }
        #endregion


        private void CreateColumnGridView()
        {
            if (data.Columns.Count == 0)
            {
                // Thêm các cột đúng với cơ sở dữ liệu
                data.Columns.Add("MaHang", "Mã Hàng");
                data.Columns.Add("TenHang", "Tên Hàng");
                data.Columns.Add("TenChatLieu", "Tên Chất Liệu");
                data.Columns.Add("DonGiaNhap", "Giá Nhập");
                data.Columns.Add("DonGiaBan", "Giá Bán");
                data.Columns.Add("SoLuong", "Số Lượng");
            }
        }
        private void AdddtTimKiemHangHoaView(DataTable dt)
        {
            data.DataSource = null;
            foreach (DataRow row in dt.Rows)
            {
                // Thêm các dữ liệu vào dtTimKiemHangHoaView
                data.Rows.Add(
                    row["MaHang"].ToString(),
                    row["TenHang"].ToString(),
                    row["TenChatLieu"].ToString(),
                    row["DonGiaNhap"].ToString(),
                    row["DonGiaBan"].ToString(),
                    row["SoLuong"].ToString()
                );
            }
        }
        private void btTimkiem_Click(object sender, EventArgs e)
        {
           
            string maHang = tbMahang.Text.Trim();
            string tenHang = tbTenhang.Text.Trim();
            string chatLieu = cbChatlieu.SelectedItem?.ToString() ?? ""; 
            string giabantu = tbTu.Text.Trim();
            string giabannhap = tbDen.Text.Trim();

           
            string whereClause = "WHERE 1=1"; 

            if (!string.IsNullOrEmpty(maHang))
            {
                whereClause += " AND tblHang.MaHang LIKE N'%" + maHang + "%'";
            }

            if (!string.IsNullOrEmpty(tenHang))
            {
                whereClause += " AND tblHang.TenHang LIKE N'%" + tenHang + "%'";
            }

            if (!string.IsNullOrEmpty(chatLieu))
            {
                whereClause += " AND tblChatLieu.TenChatLieu = N'" + chatLieu + "'"; 
            }

            if (!string.IsNullOrEmpty(giabantu) && decimal.TryParse(giabantu, out decimal minPrice))
            {
                whereClause += " AND tblHang.DonGiaBan >= " + minPrice;
            }

            if (!string.IsNullOrEmpty(giabannhap) && decimal.TryParse(giabannhap, out decimal maxPrice))
            {
                whereClause += " AND tblHang.DonGiaBan <= " + maxPrice;
            }


            string query = "SELECT tblHang.MaHang, tblHang.TenHang, tblChatLieu.TenChatLieu, " +
                           "tblHang.DonGiaNhap, tblHang.DonGiaBan, tblHang.SoLuong " +
                           "FROM tblHang " +
                           "JOIN tblChatLieu ON tblChatLieu.MaChatLieu = tblHang.MaChatLieu " +
                           whereClause;

            try
            {
                DataTable dt = dtBase.ReadData(query);
                if (dt.Rows.Count > 0)
                {

                    data.Columns.Clear();
                    CreateColumnGridView();
                    AdddtTimKiemHangHoaView(dt);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mặt hàng với các tiêu chí đã nhập.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện truy vấn: " + ex.Message);
            }
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
        
                string chatLieu = data.Rows[e.RowIndex].Cells["TenChatLieu"].Value.ToString();

    
                string queryCount = "SELECT COUNT(*) FROM tblHang " +
                                    "JOIN tblChatLieu ON tblChatLieu.MaChatLieu = tblHang.MaChatLieu " +
                                    "WHERE tblChatLieu.TenChatLieu = N'" + chatLieu + "'";

                try
                {
          
                    DataTable dtCount = dtBase.ReadData(queryCount);
                    int count = Convert.ToInt32(dtCount.Rows[0][0]); 

                  
                    MessageBox.Show($"Có {count} mặt hàng có chất liệu '{chatLieu}'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi truy vấn dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btExcel_Click(object sender, EventArgs e)
        {
            if (data.Rows.Count > 0)
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Danh Sách Mặt Hàng");

  
                    worksheet.Cell("A1").Value = "CỬA HÀNG BÁN ĐỒ LƯU NIỆM BÌNH AN";
                    worksheet.Range("A1:D1").Merge();
                    worksheet.Range("A1:D1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    worksheet.Cell("A2").Value = "Địa chỉ: 37B - TT Đống Anh - Hà Nội";
                    worksheet.Range("A2:D2").Merge();
                    worksheet.Range("A2:D2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    worksheet.Cell("A3").Value = "Số điện thoại: 0987234567";
                    worksheet.Range("A3:D3").Merge();
                    worksheet.Range("A3:D3").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;


                    worksheet.Cell("B4").Value = "DANH SÁCH CÁC MẶT HÀNG";
                    worksheet.Range("B4:H4").Merge();
                    worksheet.Range("B4:H4").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    worksheet.Range("B4:H4").Style.Font.FontColor = XLColor.Blue;

                    // Thêm tiêu đề cột
                    worksheet.Cell("B6").Value = "STT";
                    worksheet.Cell("C6").Value = "Mã hàng";
                    worksheet.Cell("D6").Value = "Tên hàng";
                    worksheet.Cell("E6").Value = "Chất liệu";
                    worksheet.Cell("F6").Value = "Giá nhập";
                    worksheet.Cell("G6").Value = "Giá bán";
                    worksheet.Cell("H6").Value = "Số lượng";
                    worksheet.Range("B6:H6").Style.Font.Bold = true;
                    worksheet.Range("B6:H6").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;


                    int row = 7;
                    int rowIndex = 1;
                    for (int i = 0; i < data.Rows.Count - 1; i++) 
                    {
            
                        if (data.Rows[i].Cells["MaHang"].Value != null)
                        {
                            worksheet.Cell(row, 2).Value = rowIndex;
                            worksheet.Cell(row, 3).Value = data.Rows[i].Cells["MaHang"].Value?.ToString();
                            worksheet.Cell(row, 4).Value = data.Rows[i].Cells["TenHang"].Value?.ToString();
                            worksheet.Cell(row, 5).Value = data.Rows[i].Cells["TenChatLieu"].Value?.ToString();
                            worksheet.Cell(row, 6).Value = data.Rows[i].Cells["DonGiaNhap"].Value?.ToString();
                            worksheet.Cell(row, 7).Value = data.Rows[i].Cells["DonGiaBan"].Value?.ToString();
                            worksheet.Cell(row, 8).Value = data.Rows[i].Cells["SoLuong"].Value?.ToString();

                            row++;
                            rowIndex++;
                        }
                    }


                    worksheet.Columns().AdjustToContents();

                    string filePath = @"F:\Timkiemhanghoa\DanhSachMatHang.xlsx"; 
                    workbook.SaveAs(filePath);

                    MessageBox.Show("Lưu thành công tại " + filePath);
                }
            }
            else
            {
                MessageBox.Show("Không có danh sách hàng để in.");
            }
        }
    }
}
