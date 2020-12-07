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
    public partial class FormThongTinKH : Form
    {
        string flag="";
        private int Level;
        SqlConnection connection;
        SqlCommand command;
        string str = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
        SqlDataAdapter adapter = new SqlDataAdapter();
        System.Data.DataTable table = new System.Data.DataTable();
        public FormThongTinKH()
        {
            InitializeComponent();
        }

        private void FormThongTinKH_Load(object sender, EventArgs e)
        {
            lockcontrol();
            connection = new SqlConnection(str);
            show();
        }
        void lockcontrol()
        {
            txtcmt.ReadOnly = true;
            txtdiachi.ReadOnly = true;
            txtsdt.ReadOnly = true;
            txttenkh.ReadOnly = true;
            cbgiotinhkh.Enabled = false;
            cbquoctich.Enabled = false;
            dtngaysinh.Enabled = false;
            btn_add.Enabled = true;
            btn_edit.Enabled = false;
            btn_exit.Enabled = true;
            btn_save.Enabled = false;
        }
        void unlock()
        {
            txtcmt.ReadOnly = false;
            txtdiachi.ReadOnly = false;
            txtsdt.ReadOnly = true;
            txttenkh.ReadOnly = false;
            cbgiotinhkh.Enabled = true;
            cbquoctich.Enabled = true;
            dtngaysinh.Enabled = true;
            btn_add.Enabled = true;
            btn_edit.Enabled = false;
            btn_exit.Enabled = true;
            btn_save.Enabled = true;
        }
        void show()
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM dbo.KhachHang";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgKH.DataSource = table;
            dgKH.ReadOnly = true;
            connection.Close();
        }
        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '+')
                e.Handled = true;
        }
        private void txtcmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            flag = "add";
            unlock();
            txtsdt.ReadOnly = false;
            txtcmt.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
            txttenkh.Text = "";
            cbgiotinhkh.SelectedIndex = 0;
            cbquoctich.SelectedIndex = 0;
            dtngaysinh.Value = DateTime.Now;
        }

        private void dgKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lockcontrol();
            int i;
            i = dgKH.CurrentRow.Index;
            if (i >= 0)
            {

                var r = dgKH.Rows[i].Cells["SoDT"].Value.ToString();
                if (!string.IsNullOrEmpty(r))
                {
                    txttenkh.Text = dgKH.Rows[i].Cells[0].Value.ToString();
                    dtngaysinh.Text = dgKH.Rows[i].Cells[1].Value.ToString();
                    cbgiotinhkh.Text = dgKH.Rows[i].Cells[2].Value.ToString();
                    txtcmt.Text = dgKH.Rows[i].Cells[3].Value.ToString();
                    txtsdt.Text = dgKH.Rows[i].Cells[4].Value.ToString();
                    txtdiachi.Text = dgKH.Rows[i].Cells[5].Value.ToString();
                    cbquoctich.Text = dgKH.Rows[i].Cells[6].Value.ToString();
                    this.btn_edit.Enabled = true;
                }
                else
                {
                    this.btn_edit.Enabled = false;
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            flag = "edit";
            unlock();
        }
        bool check()
        {
            if (string.IsNullOrEmpty(txttenkh.Text))
            {
                MessageBox.Show("Chưa nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttenkh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtsdt.Text))
            {
                MessageBox.Show("Chưa nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsdt.Focus();
                return false;
            }     
            return true;
        }
        bool checksdt(string sdt)
        {
            int check = 0;
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "SELECT SoDT FROM dbo.KhachHang";
            adapter.SelectCommand = command;
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            connection.Close();
            if (tb.Rows.Count != 0)
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    if (sdt == tb.Rows[i].ItemArray[0].ToString().Trim())
                    {
                        check++;
                        break;
                    }
                }
                if (check != 0)
                {
                    MessageBox.Show("Số điện thoại đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtsdt.Focus();
                    return false;
                    
                }
                else return true;
            }
            else return true;
        }
        bool checkcmnd(string cmnd)
        {
            int check = 0;
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "SELECT SoCMT FROM dbo.KhachHang";
            adapter.SelectCommand = command;
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            connection.Close();
            if (cmnd == "" || tb.Rows.Count ==0)
            {
                return true;
            }
            else
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    if (cmnd == tb.Rows[i].ItemArray[0].ToString().Trim())
                    {
                        check++;
                        break;
                    }
                }
                if (check != 0)
                {
                    MessageBox.Show("Số CMND đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtcmt.Focus();
                    return false;

                }
                else return true;
            }
        }
        bool checkcmnd_2(string cmnd, string sdt)
        {
            int check = 0;
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "SELECT SoCMT FROM dbo.KhachHang WHERE SoDT <>'"+txtsdt.Text+"'";
            adapter.SelectCommand = command;
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            connection.Close();
            if (cmnd == "" || tb.Rows.Count < 1 )
            {
                return true;
            }
            else
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    if (cmnd.Trim() == tb.Rows[i].ItemArray[0].ToString().Trim())
                    {
                        check++;
                        break;
                    }
                }
                if (check > 0)
                {
                    MessageBox.Show("Số CMND đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtcmt.Focus();
                    return false;
                    
                }
                else return true;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (flag == "add")
            {
                if (check() && checkcmnd(txtcmt.Text) && checksdt(txtsdt.Text))
                {
                    connection.Open();
                    command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO dbo.KhachHang( TenKH , NgaySinh ,GioiTinh ,SoCMT ,SoDT ,QueQuan , QuocTich )VALUES  ( N'" + txttenkh.Text + "' , '" + dtngaysinh.Text + "' , '" + cbgiotinhkh.Text + "' ,  '" + txtcmt.Text + "' , '" + txtsdt.Text + "' ,'" + txtdiachi.Text + "' , N'" + cbquoctich.Text + "')";
                    command.ExecuteNonQuery();
                    connection.Close();
                    show();
                }
            }
            else if (flag == "edit")
            {
                if (check() && checkcmnd_2(txtcmt.Text,txtsdt.Text))
                {
                    connection.Open();
                    command = connection.CreateCommand();
                    command.CommandText = "UPDATE dbo.KhachHang SET TenKH='" + txttenkh.Text + "',NgaySinh='" + dtngaysinh.Text + "',GioiTinh='" + cbgiotinhkh.Text + "',SoCMT='" + txtcmt.Text + "',QueQuan='" + txtdiachi.Text + "',QuocTich='" + cbquoctich.Text + "' WHERE SoDT='" + txtsdt.Text + "' ";
                    command.ExecuteNonQuery();
                    connection.Close();
                    show();
                }
            }
        }
    }
}
