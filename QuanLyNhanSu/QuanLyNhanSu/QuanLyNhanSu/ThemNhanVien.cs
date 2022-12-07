using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class ThemNhanVien : Form
    {

        SqlConnection sqlConThemNhanVien = new SqlConnection(formDangNhap.ChuoiketNoi);
        SqlCommand sqlThemNhanVien = new SqlCommand();

        

        public ThemNhanVien()
        {
            InitializeComponent();
        }


        // Nut thoat
        private void button2_Click(object sender, EventArgs e)
        {
            if (sqlConThemNhanVien.State == ConnectionState.Open)
            {
                sqlConThemNhanVien.Close();
            }
            sqlConThemNhanVien = null;
            this.Close();
        }

        
        

        // Nut luu khi them nhan vien.
        private void button1_Click(object sender, EventArgs e)
        {



            string srt = "";

            if (tb1.Text!=string.Empty && tb2.Text!=string.Empty) {
                sqlThemNhanVien.CommandType= CommandType.Text;
                sqlThemNhanVien.CommandText = "INSERT INTO NHANVIEN VALUES ('"+tb1.Text+"',N'"+tb2.Text+"','"+tb3.Text+"',N'"+tb4.Text+"','"+tb5.Text+"',N'"+srt+"');";

                if(sqlConThemNhanVien.State==ConnectionState.Closed)
                {
                
                    sqlConThemNhanVien.Open();
                }

            
                 sqlThemNhanVien.Connection = sqlConThemNhanVien;
            
            
                int thu = sqlThemNhanVien.ExecuteNonQuery();
                if(thu > 0)
                {
                    MessageBox.Show("Them thanh cong");
                }
                else
                {
                    MessageBox.Show("Them that bai do trung ma nhan vien");
                }
            }
            else
            {
                MessageBox.Show("Ban hay nhap du lieu");
            }

            
        }
    }
}
