using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;

namespace QLKS
{
    public partial class ThanhToan : Form
    {
        DatabaseNV db = new DatabaseNV();
        public ThanhToan()
        {
            InitializeComponent();
            TimKiem("","sdt");
        }
        private void TimKiem(string key, string mode)
        {

            List<CustomerParameter> lstpara = new List<CustomerParameter>();
            if(mode == "sdt")
            {
                lstpara.Add(new CustomerParameter() { key = "@SoDT", value = key });
                this.phongThueBindingSource.DataSource = db.SelectData("SP_TimKiemPhongThue",lstpara);
            }
            else if (mode == "cmtnd")
            {
                lstpara.Add(new CustomerParameter() { key = "@SoCMT", value = key });
                this.phongThueBindingSource.DataSource = db.SelectData("SP_TimKiemPhongThueCMTND", lstpara);
            }   
            else if (mode == "mp")
            {
                lstpara.Add(new CustomerParameter() { key = "@MaPhong", value = key });
                this.phongThueBindingSource.DataSource = db.SelectData("SP_TimKiemPhongThueMaPhongf", lstpara);
            }
            else if (mode == "ten")
            {
                lstpara.Add(new CustomerParameter() { key = "@Name", value = key });
                this.phongThueBindingSource.DataSource = db.SelectData("SP_TimKiemPhongThueTen", lstpara);
            }

        }
        private void TimKiem_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TimKiem_btn_Click(object sender, EventArgs e)
        {
            if (TimKiem_txb.Text == "")
            {
                MessageBox.Show("Vui lòng nhập nội dung tìm kiếm!");
                return;
            }
            if (comboBox1.SelectedIndex == 0)
            {
                TimKiem(TimKiem_txb.Text, "mp");
            }
            else if(comboBox1.SelectedIndex == 2)
            {
                /*cmtnd*/
                TimKiem(TimKiem_txb.Text, "cmtnd");
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                // sdt
                TimKiem(TimKiem_txb.Text, "sdt");
            }
            else if(comboBox1.SelectedIndex == 3)
            {
                TimKiem(TimKiem_txb.Text, "ten");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hình thức tìm kiếm!");
            }
        }

        private void all_btn_Click(object sender, EventArgs e)
        {
            TimKiem("", "sdt");
        }

        private void XuatHoaDon_btn_Click(object sender, EventArgs e)
        {
            if (tongTienTextBox.Text == "")
            {
                DateTime from = ngayThueDateTimePicker.Value;
                DateTime to = ngayTraPhongDateTimePicker.Value;
                TimeSpan denta = to - from;

                int soNgay = denta.Days;
                int TongTien = soNgay * int.Parse(giaPhongTextBox.Text);
                List<CustomerParameter> lstpara = new List<CustomerParameter>();

                lstpara.Add(new CustomerParameter() { key = "@MaNV", value = "LT001  " });
                lstpara.Add(new CustomerParameter() { key = "@SoDT", value = soDTTextBox.Text });
                lstpara.Add(new CustomerParameter() { key = "@NgayLap", value = DateTime.Today.ToShortDateString() });
                lstpara.Add(new CustomerParameter() { key = "@TongTien", value = TongTien.ToString() });

                db.Excute("SP_XuatHoaDon", lstpara, null);      // function tạo mã HD tự động bằng sql function
                TimKiem("", "sdt");
                MessageBox.Show(tongTienTextBox.Text);

            }
            else
            {
                MessageBox.Show("Phòng đã có Hoá đơn!");
            }
        }

        private void ThanhToan_btn_Click(object sender, EventArgs e)
        {
            if(daThanhToanTextBox.Text == "True")
            {
                MessageBox.Show("Hoá đơn đã Thanh Toán");
            }
            else
            {
                List<CustomerParameter> lstpara = new List<CustomerParameter>();
                string MaHD = maHDTextBox.Text;
                if(MaHD == "")
                {
                    MessageBox.Show("Vui lòng thanh toán phòng đã xuất hoá đơn!");
                    return;
                }
                lstpara.Add(new CustomerParameter() { key = "@MaHD", value = MaHD });
                db.Excute("SP_ThanhToan", lstpara, null);
                TimKiem("", "sdt");
                MessageBox.Show("Thanh toán thành công!");
            }

        }

          private void ThanhToan_Load(object sender, EventArgs e)
          {

          }
     }
}
