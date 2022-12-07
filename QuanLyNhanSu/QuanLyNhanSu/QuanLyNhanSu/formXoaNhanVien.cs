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
    public partial class formXoaNhanVien : Form
    {

        SqlConnection sqlConXoa = new SqlConnection(formDangNhap.ChuoiketNoi);
        SqlCommand sqlXoa = new SqlCommand();
        
        public formXoaNhanVien()
        {
            InitializeComponent();
        }


        // Nut thoat
        private void button2_Click(object sender, EventArgs e)
        {
            if (sqlConXoa.State == ConnectionState.Open)
            {
                sqlConXoa.Close();
                sqlConXoa = null;
            }
            this.Close();
        }


        // Nut xoa nhan vien
        private void button1_Click(object sender, EventArgs e)
        {
            if(tBXoa.Text!=string.Empty)
            {
                if(sqlConXoa.State==ConnectionState.Closed)
                {
                   sqlConXoa.Open();
                }

                sqlXoa.CommandType= CommandType.Text;
                sqlXoa.CommandText = "DELETE NHANVIEN WHERE MaNhanVien = '"+tBXoa.Text+"';";
                sqlXoa.Connection = sqlConXoa;
                int thu = sqlXoa.ExecuteNonQuery();
                if(thu>0) {
                    MessageBox.Show("Da xoa nhan vien");
                }
                else
                {
                    MessageBox.Show("Khong co nhan vien nay");
                }
                
            }
            else
            {
                MessageBox.Show("Chua nhap ma nhan vien");
            }

            
        }
    }
}
