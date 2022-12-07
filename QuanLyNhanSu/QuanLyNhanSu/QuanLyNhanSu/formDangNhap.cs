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

    
    public partial class formDangNhap : Form
    {


        static public string ChuoiketNoi = @"Data Source=THANBAC\SQL_OF_BAC;Initial Catalog=QLNS;Integrated Security=True";

        SqlConnection sqlConDangNhap = new SqlConnection(ChuoiketNoi);
        SqlCommand sqlTruyVanDN = new SqlCommand();


        public formDangNhap()
        {
            InitializeComponent();
        }

        string ten = "1";
        string mk = "1";


        // Nut dang nhap
        private void DangNhap(object sender, EventArgs e)
        {

            sqlTruyVanDN.CommandType = CommandType.Text;
            sqlTruyVanDN.CommandText = "SELECT COUNT(*) FROM USERNAME WHERE TK = '" + tb1.Text + "' and MK = '" + tb2.Text + "';";
            if (sqlConDangNhap.State == ConnectionState.Closed)
            {
                sqlConDangNhap.Open();
                sqlTruyVanDN.Connection = sqlConDangNhap;
            }

            int thu = (int)sqlTruyVanDN.ExecuteScalar();


            if (thu != 0)
            {
                this.Hide();
                formMain fm = new formMain();
                fm.Show();
                fm.DangXuat += Fm_DangXuat;
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }

                
                
            
            
        }


        // Dang xuat
        private void Fm_DangXuat(object sender, EventArgs e)
        {
            (sender as formMain).isexit = false;
            (sender as formMain).Close();
            this.Show();
        }


        // Nut thoat
        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }

}
