using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class SuaNhanVien : Form
    {


        SqlConnection sqlConSua = new SqlConnection(formDangNhap.ChuoiketNoi);
        SqlCommand sqlSua = new SqlCommand();
        
        
        public SuaNhanVien()
        {
            InitializeComponent();
        }


        // Nut thoat
        private void button2_Click(object sender, EventArgs e)
        {
            if (sqlConSua.State == ConnectionState.Open)
            {
                sqlConSua.Close();
            }
            sqlConSua = null;
            this.Close();
        }


        // Nut luu
        private void button1_Click(object sender, EventArgs e)
        {
            if (tb1.Text != string.Empty)
            {
                if (sqlConSua.State == ConnectionState.Closed)
                {
                    sqlConSua.Open();
                }

                sqlSua.CommandType = CommandType.Text;
                sqlSua.CommandText = "DELETE NHANVIEN WHERE MaNhanVien = '" + tb1.Text + "';";
                sqlSua.Connection = sqlConSua;
                int thu = sqlSua.ExecuteNonQuery();
                if (thu <= 0)
                {
                    MessageBox.Show("Khong co nhan vien nay");
                }


                sqlSua.CommandText = "INSERT INTO NHANVIEN VALUES ('" + tb1.Text + "',N'" + tb2.Text + "','" + tb3.Text + "',N'" + tb4.Text + "','" + tb5.Text + "',N'" + tb6.Text + "');";
                int thu2 = sqlSua.ExecuteNonQuery();
                if (thu2 > 0)
                {
                    MessageBox.Show("Da sua thanh cong");
                }


            }
            else
            {
                MessageBox.Show("Chua nhap ma nhan vien");
            }
        }
    }
}
