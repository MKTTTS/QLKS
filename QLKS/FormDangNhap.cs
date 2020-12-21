using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace QLKS
{
    public partial class FormDangNhap : Form
    {
        string connectString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;


        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(connectString);
            try
            {
                conn.Open();
                string tk = txttaikhoan.Text;
                string mk = txtmatkhau.Text;
                string sql = "select * from DANGNHAP where UserName ='" + tk + "' and PassWords ='" + mk + "' ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show("Dang nhap thanh cong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    FormMain form1 = new FormMain();
                    form1.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Dang nhap that bai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi");
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
            {
                Application.Exit();
            }

        }

        private void cbkhach_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            FormThongTinPhong_KH formKH = new FormThongTinPhong_KH();
            formKH.ShowDialog();
            this.Close();
        }
    }
}
