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
    public partial class FormThongTinPhong : Form
    {
        public void LoadAgain()
        {

            string conString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(conString);
            sqlCon.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Phong", sqlCon);
            da.Fill(dt);
            this.GridView.DataSource = dt;
        }
        public FormThongTinPhong()
        {
            InitializeComponent();
        }

        private void FormThongTinPhong_Load(object sender, EventArgs e)
        {
            LoadAgain();


            //da.Fill(dt);
        }

        private void btnthoatphong_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnthemphong_Click(object sender, EventArgs e)
        {
            string sql = "sp_insPHONG";
            List<CustomerParameter> lstPara1 = new List<CustomerParameter>();
            lstPara1.Add(new CustomerParameter() { key = "@MaPhong", value = this.txtphong.Text });
            lstPara1.Add(new CustomerParameter() { key = "@LoaiPhong", value = this.txtloaiphong.Text });
            lstPara1.Add(new CustomerParameter() { key = "@GiaPhong", value = this.txtdongiaphong.Text });
            var r = new DatabaseNV().Excute(sql, lstPara1, null);
            if (r > 0)
            {
                MessageBox.Show("Thêm thành công.");
                LoadAgain();
            }
        }

        private void btnsuaphong_Click(object sender, EventArgs e)
        {
            string sql = "sp_updatePhong";
            List<CustomerParameter> lstPara1 = new List<CustomerParameter>();
            lstPara1.Add(new CustomerParameter() { key = "@MaPhong", value = this.txtphong.Text });
            lstPara1.Add(new CustomerParameter() { key = "@LoaiPhong", value = this.txtloaiphong.Text });
            lstPara1.Add(new CustomerParameter() { key = "@GiaPhong", value = this.txtdongiaphong.Text });
            var r = new DatabaseNV().Excute(sql, lstPara1, null);
            if (r > 0)
            {
                MessageBox.Show("Sửa thành công.");
                LoadAgain();
            }
        }
    }
}
