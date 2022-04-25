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

namespace QuanLyNhanSu
{
    public partial class Form1 : Form
    {
        //Tao chuoi ket noi voi SQL
        string strCon = @"Data Source=LAPTOP-3V5F2V2F;Initial Catalog=QLNS_DangNhap;Integrated Security=True";
        //Tao doi tuong ket noi vs SQL
        SqlConnection sqlCon = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCon = new SqlConnection(strCon);

                if (txt_TaiKoan.Text == @"Abc@123" || txt_TaiKoan.Text == @"XYZ@789")
                {
                    if (txt_MatKhau.Text == @"ADM111" || txt_MatKhau.Text == @"ADM222")
                    {
                        Form2 frm2 = new Form2();
                        frm2.Show();
                        this.Hide();
                    }
                }
                else
                    MessageBox.Show("Tai khoan hoac mat khau sai!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbox_HienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_HienMK.Checked == true)
            {
                txt_MatKhau.UseSystemPasswordChar = false;
            }
            else
                txt_MatKhau.UseSystemPasswordChar = true;
        }
    }
}
