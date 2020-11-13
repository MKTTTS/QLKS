﻿using System;
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
using View;

namespace QLKS
{
     public partial class FormMain : Form
     {
          string conString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
          int dem = 0;
          public FormMain()
          {
               InitializeComponent();
            this.radioButtonPhong.Checked = true;
            this.panelTheoPhong.Visible = true;
            this.panelKH.Visible = false;

        }

          private void FormMain_Load(object sender, EventArgs e)
          {
               SqlConnection sqlCon = new SqlConnection(conString);
               string qry = "select * from Phong";
               SqlDataAdapter da = new SqlDataAdapter(qry, sqlCon);

               DataTable dt = new DataTable();
               da.Fill(dt);
               dem = dt.Rows.Count;
               dtgvDanhSachphong.DataSource = dt;
               
              
          }

          private void dtgvDanhSachphong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
          {
               int test = 0;
               foreach (DataGridViewRow row in dtgvDanhSachphong.Rows)
               {
                    string ok = row.Cells[3].Value.ToString();

                    if (ok.TrimEnd() == "ready")
                    {
                         row.DefaultCellStyle.ForeColor = Color.Green;
                    }

                    if (ok.TrimEnd() == "waiting")
                    {
                         row.DefaultCellStyle.ForeColor = Color.YellowGreen;
                    }

                    if (ok.TrimEnd() == "used")
                    {
                         row.DefaultCellStyle.ForeColor = Color.Red;
                    }

                    test++;

                    if (test == dem) break;


               }
          }

        private void radioButtonPhong_CheckedChanged(object sender, EventArgs e)
        {
            this.panelTheoPhong.Visible = true;
            this.panelKH.Visible = false;
            this.dtgvTimKiem.DataSource = null;
        }

        private void radioButtonKH_CheckedChanged(object sender, EventArgs e)
        {
            this.panelKH.Visible = true;
            this.panelTheoPhong.Visible = false;
            this.dtgvTimKiem.DataSource = null;
        }

        

        private void buttonTimkiemKH_Click(object sender, EventArgs e)
        {
            var db = new DatabaseNV();
            List<CustomerParameter> lst = new List<CustomerParameter>();
            lst.Add(new CustomerParameter() { key = "@tukhoa", value = this.textBoxKhachHang.Text });
            string sql = "SELECTKHACHHANG";
            this.dtgvTimKiem.DataSource = db.SelectData(sql, lst);
        }

        private void buttonTimkiemPhong_Click(object sender, EventArgs e)
        {
            string trangthai1 = "";
            string trangthai2 = "";
            string trangthai3 = "";
            if (this.checkBoxAll.Checked == true)
            {
                trangthai1 = "Het";
                trangthai2 = "Coc";
                trangthai3 = "Trong";
            }
            else
            {
                if(this.checkBoxDattruoc.Checked == true)
                {
                    trangthai2 = "Coc";
                }
                if(this.checkBoxThue.Checked == true)
                {
                    trangthai1 = "Het";
                }
                if(this.checkBoxTrong.Checked == true)
                {
                    trangthai3 = "Trong";
                }
            }
            var db = new DatabaseNV();
            List<CustomerParameter> lst = new List<CustomerParameter>();
            lst.Add(new CustomerParameter() { key = "@trangthai1", value = trangthai1 });
            lst.Add(new CustomerParameter() { key = "@trangthai2", value = trangthai2 });
            lst.Add(new CustomerParameter() { key = "@trangthai3", value = trangthai3 });
            lst.Add(new CustomerParameter() { key = "maphong", value = this.textBoxPhong.Text });
            string sql = "SEARCHPHONG";
            this.dtgvTimKiem.DataSource = db.SelectData(sql, lst);
        }

        private void dtgvTimKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if(this.radioButtonPhong.Checked == true)
                {
                    var r = this.dtgvTimKiem.Rows[e.RowIndex].Cells["Phòng"].Value.ToString().Trim();
                    if (!string.IsNullOrEmpty(r))
                    {
                        string mp = this.dtgvTimKiem.Rows[e.RowIndex].Cells["Phòng"].Value.ToString().Trim();
                        string lp = this.dtgvTimKiem.Rows[e.RowIndex].Cells["Loại phòng"].Value.ToString().Trim();
                        string tt = this.dtgvTimKiem.Rows[e.RowIndex].Cells["Tình trạng"].Value.ToString().Trim();
                        HistoryOfRoom hs = new HistoryOfRoom(mp, lp, tt);
                        hs.ShowDialog();
                    }
                }
                if(this.radioButtonKH.Checked == true)
                {
                    var r = this.dtgvTimKiem.Rows[e.RowIndex].Cells["Số điện thoại"].Value.ToString().Trim();
                    if (!string.IsNullOrEmpty(r))
                    {
                        string tenkh = this.dtgvTimKiem.Rows[e.RowIndex].Cells["Tên khách hàng"].Value.ToString().Trim();
                        string gioitinh = this.dtgvTimKiem.Rows[e.RowIndex].Cells["Giới tính"].Value.ToString().Trim();
                        string ngaysinh = this.dtgvTimKiem.Rows[e.RowIndex].Cells["Ngày sinh"].Value.ToString().Trim();
                        string sdt = this.dtgvTimKiem.Rows[e.RowIndex].Cells["Số điện thoại"].Value.ToString().Trim();
                        string cmnd = this.dtgvTimKiem.Rows[e.RowIndex].Cells["Số CMND"].Value.ToString().Trim();
                        string quequan = this.dtgvTimKiem.Rows[e.RowIndex].Cells["Quên quán"].Value.ToString().Trim();
                        string quoctich = this.dtgvTimKiem.Rows[e.RowIndex].Cells["Quốc tịch"].Value.ToString().Trim();
                        HistoryOfCustomers hs = new HistoryOfCustomers(tenkh, gioitinh, ngaysinh, sdt, cmnd, quequan, quoctich);
                        hs.ShowDialog();

                    }
                }
              
            }
        }
    }
}
