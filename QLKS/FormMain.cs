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
    }
}
