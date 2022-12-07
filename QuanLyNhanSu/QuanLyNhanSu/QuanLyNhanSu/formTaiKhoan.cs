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
    public partial class formTaiKhoan : Form
    {


        SqlConnection sqlcon;
        SqlCommand sqlTruyVan;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable table = new DataTable();


        public formTaiKhoan()
        {
            InitializeComponent();
        }


        // Ham loadTable
        void loadTable(string str)
        {
            sqlTruyVan = sqlcon.CreateCommand();
            sqlTruyVan.CommandText = str;
            adt.SelectCommand = sqlTruyVan;
            table.Clear();
            adt.Fill(table);
            dtgvTaiKhoan.DataSource= table;

        }



        // Nut dong formTaiKhoan
        private void btDongFormTaiKhoan_Click(object sender, EventArgs e)
        {
            if (sqlcon.State == ConnectionState.Open)
            {
                sqlcon.Close();
            }
            sqlcon = null; sqlTruyVan = null;
            this.Close();
        }

        private void formTaiKhoan_Load(object sender, EventArgs e)
        {
            sqlcon = new SqlConnection(formDangNhap.ChuoiketNoi);
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            loadTable("select * from USERNAME");
            sqlcon.Close();
        }

        private void btThemTaiKhoan_Click(object sender, EventArgs e)
        {
            if(sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }

            sqlTruyVan = new SqlCommand();
            sqlTruyVan.CommandType= CommandType.Text;
            sqlTruyVan.CommandText = "INSERT INTO USERNAME VALUES ('"+tb1.Text+"','"+tb2.Text+"');";
            sqlTruyVan.Connection = sqlcon;
            int thu = sqlTruyVan.ExecuteNonQuery();
            if(thu > 0)
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            loadTable("select * from USERNAME");
            sqlcon.Close();
            

        }

        private void btXoaTaiKhoan_Click(object sender, EventArgs e)
        {

            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }

            sqlTruyVan = new SqlCommand();
            sqlTruyVan.CommandType = CommandType.Text;
            sqlTruyVan.CommandText = "DELETE FROM USERNAME WHERE TK = '" + tb1.Text + "' AND MK = '" + tb2.Text + "';";
            sqlTruyVan.Connection = sqlcon;
            int thu = sqlTruyVan.ExecuteNonQuery();
            if (thu > 0)
            {
                MessageBox.Show("Xoa tai khoan thanh cong");
            }
            loadTable("select * from USERNAME");
            sqlcon.Close();

        }

    }
}
//"DELETE FROM USERNAME WHERE TK = '" + tb1.Text + "' AND MK = '" + tb2.Text + "';";