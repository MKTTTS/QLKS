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
    public partial class HistoryOfCustomers : Form
    {
        private string Name;
        private string GioiTinh;
        private string NgaySinh;
        private string SDT;
        private string SoCMND;
        private string QueQuan;
        private string QuocTich;
        public HistoryOfCustomers(string name, string gioitinh, string date, string sdt, string cmnd, string quequan, string quoctich)
        {
            InitializeComponent();
            this.Name = name;
            this.GioiTinh = gioitinh;
            this.NgaySinh = date;
            this.SDT = sdt;
            this.SoCMND = cmnd;
            this.QueQuan = quequan;
            this.QuocTich = quoctich;
            this.textBoxTenKH.Text = this.Name;
            this.textBoxGioiTinhKH.Text = this.GioiTinh;
            this.textBoxNSKH.Text = this.NgaySinh;
            this.textBoxSDTKH.Text = this.SDT;
            this.textBoxCMNDKH.Text = this.SoCMND;
            this.textBoxQueQuanKH.Text = this.QueQuan;
            this.textBoxQuocTichKH.Text = this.QuocTich;
        }

        private void buttonHSCM_Click(object sender, EventArgs e)
        {
            var db = new DatabaseNV();
            List<CustomerParameter> lst = new List<CustomerParameter>();
            lst.Add(new CustomerParameter() { key = "@sdt", value = this.SDT });
            string sql = "HistoryOfCustomer";
            this.dataGridViewHistoryOfCustomer.DataSource = db.SelectData(sql, lst);
        }
    }
}
