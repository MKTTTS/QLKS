using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
     public partial class FormMain : Form
     {
          string conString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
          int dem = 0;
          public FormMain()
          {
               InitializeComponent();
          }

          private void FormMain_Load(object sender, EventArgs e)
          {
               SqlConnection sqlCon = new SqlConnection(conString);
               sqlCon.Open();

               //Cap nhat cac phong duoc dat trc nhung qua han ngay su dung
               string qry_DatHetHan = "select MaPhong from DatPhong where NgaySuDung < GETDATE()";
               SqlCommand cmd_DatHetHan = new SqlCommand(qry_DatHetHan, sqlCon);
               SqlDataReader reader_DatHetHan = cmd_DatHetHan.ExecuteReader();
               string[] maPhongHetHan = new string[3];
               int j = 0;

               if (reader_DatHetHan.HasRows)
               {
                    while (reader_DatHetHan.Read())
                    {
                         maPhongHetHan[j] = reader_DatHetHan.GetString(0);
                         j++;
                    }
                    j--;
               }

               reader_DatHetHan.Close();

               while(j >= 0)
               {
                    string qry_updateTinhTrang = "update Phong set TinhTrang='Trong' where MaPhong='" + maPhongHetHan[j] + "'";
                    string qry_xoaPhongDat = "delete from DatPhong where MaPhong='" + maPhongHetHan[j] + "'";
                    SqlCommand cmd_updateTinhTrang = new SqlCommand(qry_updateTinhTrang, sqlCon); //update phòng về tình trạng trống
                    SqlCommand cmd_xoaPhongDat = new SqlCommand(qry_xoaPhongDat, sqlCon); //xóa phòng này trong danh sách đc đặt
                    cmd_updateTinhTrang.ExecuteNonQuery();
                    cmd_xoaPhongDat.ExecuteNonQuery();
                    j--;
               }               


               //Tab Danh sach Phong
               string qry_DSPhong = "select * from Phong";
               SqlDataAdapter da_DSPhong = new SqlDataAdapter(qry_DSPhong, sqlCon);
               DataTable dt_DSPhong = new DataTable();
               da_DSPhong.Fill(dt_DSPhong);
               dem = dt_DSPhong.Rows.Count;
               dtgvDanhSachphong.DataSource = dt_DSPhong;

               //Tab Thue Phong
               string qry_MaPhong = "select MaPhong from Phong where TinhTrang='Trong'";
               SqlDataAdapter da_MaPhong = new SqlDataAdapter(qry_MaPhong, sqlCon);
               DataTable dt_MaPhong = new DataTable();
               da_MaPhong.Fill(dt_MaPhong);

               cbxPhongReady.Items.Clear(); // Moi khi load lai form phai cap nhat danh sach phong

               for(int i=0;i<dt_MaPhong.Rows.Count;i++)
               {
                    cbxPhongReady.Items.Add(dt_MaPhong.Rows[i]["MaPhong"]);
               }


               sqlCon.Close();
          }

          private void dtgvDanhSachphong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
          {
               int test = 0;
               foreach (DataGridViewRow row in dtgvDanhSachphong.Rows)
               {
                    string ok = row.Cells[3].Value.ToString();

                    if (ok.TrimEnd() == "Trong")
                    {
                         row.DefaultCellStyle.ForeColor = Color.Green;
                    }

                    if (ok.TrimEnd() == "Coc")
                    {
                         row.DefaultCellStyle.ForeColor = Color.YellowGreen;
                    }

                    if (ok.TrimEnd() == "Het")
                    {
                         row.DefaultCellStyle.ForeColor = Color.Red;
                    }

                    test++;

                    if (test == dem) break;


               }
          }

          private void btThuePhongOK_Click(object sender, EventArgs e)
          {

          }

          private void btnOkDatPhong_Click(object sender, EventArgs e)
          {
               SqlConnection sqlCon = new SqlConnection(conString);
               sqlCon.Open();

               string ngay = dtngaydattruoc.Value.Day.ToString();
               string thang = dtngaydattruoc.Value.Month.ToString();
               string nam = dtngaydattruoc.Value.Year.ToString().Substring(2);

               string maDat = String.Concat(ngay, thang, nam, cbxPhongReady.Text);

               string qry_DatPhong = "insert into DatPhong values (" + maDat + "," + cbxPhongReady.Text + "," + txtSDTdatPhong.Text + "," 
                                      + txtTienCoc.Text + ",'" + dtngaydattruoc.Value.ToString() + "','" + dtNgayTraPhongDat.Value.ToString() + "')";

               SqlCommand cmd_DatPhong = new SqlCommand(qry_DatPhong, sqlCon);
               cmd_DatPhong.ExecuteNonQuery();
               cmd_DatPhong.Cancel();

               string qry_ChuyenTinhTrang = "Update Phong set TinhTrang = 'Het' where MaPhong = '" + cbxPhongReady.Text + "'";
               SqlCommand cmd_ChuyenTinhTrang = new SqlCommand(qry_ChuyenTinhTrang, sqlCon);
               cmd_ChuyenTinhTrang.ExecuteNonQuery();
               cmd_ChuyenTinhTrang.Cancel();

               FormMain_Load(sender, e);

               sqlCon.Close();    

          }
     }
}
