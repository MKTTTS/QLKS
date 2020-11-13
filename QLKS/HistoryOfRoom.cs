using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;

namespace QLKS
{
    public partial class HistoryOfRoom : Form
    {
        private static DateTime MinDate = DateTime.ParseExact("01/01/1900", "dd/MM/yyyy", CultureInfo.InvariantCulture);
        private string Maphong;
        private string Loaiphong;
        private string TrangThai;
        public HistoryOfRoom(string MP, string LP, string TT)
        {
            InitializeComponent();
            DateTime date = DateTime.Now;
            this.maskedTextBoxTo.Text = date.ToString("dd/MM/yyyy");
            this.maskedTextBoxFrom.Text = MinDate.ToString("dd/MM/yyyy");
            this.Maphong = MP;
            this.Loaiphong = LP;
            this.TrangThai = TT;
            this.textBoxSP.Text = this.Maphong;
            this.textBoxLP.Text = this.Loaiphong;
            this.textBoxTT.Text = this.TrangThai;
        }

        private void buttonHS_Click(object sender, EventArgs e)
        {
            DateTime from;
            DateTime to;
            try
            {
                from = DateTime.ParseExact(this.maskedTextBoxFrom.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Ngày tháng không hợp lệ");
                this.maskedTextBoxFrom.Select();
                return;
            }
            try
            {
                to = DateTime.ParseExact(this.maskedTextBoxTo.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Ngày tháng không hợp lệ");
                this.maskedTextBoxTo.Select();
                return;
            }
            if(DateTime.Compare(from, to) >= 0)
            {
                MessageBox.Show("Ngày tháng không hợp lệ");
                this.maskedTextBoxTo.Select();
                return;
            }
            var bd = new DatabaseNV();
            List<CustomerParameter> lst = new List<CustomerParameter>();
            lst.Add(new CustomerParameter() { key = "@maphong", value = this.Maphong });
            lst.Add(new CustomerParameter() { key = "@from", value = from.ToString("yyyy-MM-dd") });
            lst.Add(new CustomerParameter() { key = "@to", value = to.ToString("yyyy-MM-dd") });
            string sql = "HistoryOfRoom";
            this.dataGridViewHistoryOfRoom.DataSource = bd.SelectData(sql, lst);

        }
    }
}
