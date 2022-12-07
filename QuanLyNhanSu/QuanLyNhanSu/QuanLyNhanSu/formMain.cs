using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyNhanSu
{

    


    public partial class formMain : Form
    {
        public event EventHandler DangXuat;

        public bool isexit = true;

        SqlConnection sqlconMain;
        SqlCommand sqlTruyVanMain;
        SqlDataAdapter adtMain = new SqlDataAdapter();
        DataTable tableMain = new DataTable();
        




        // Ham load bang
        void loadTable(string str)
        {
            sqlTruyVanMain = sqlconMain.CreateCommand();
            sqlTruyVanMain.CommandText = str;
            adtMain.SelectCommand= sqlTruyVanMain;
            tableMain.Clear();
            adtMain.Fill(tableMain);
            dtgvMain.DataSource = tableMain;

        }

        public formMain()
        {
            InitializeComponent();
        }


        // Nut Dang Xuat
        private void smDangXuat_Click(object sender, EventArgs e)
        {
            
            DangXuat(this, new EventArgs());

        }


        // Nut tai khoan
        private void smTaiKhoan_Click(object sender, EventArgs e)
        {
            formTaiKhoan ftk = new formTaiKhoan();
            ftk.ShowDialog();
            ftk = null;
        }


        // Nut them nhan vien
        private void smThemNhanVien_Click(object sender, EventArgs e)
        {
            ThemNhanVien tnv = new ThemNhanVien();
            tnv.ShowDialog();
            tnv = null;
        }


        // Nut xoa nhan vien
        private void smXoaNhanVien_Click(object sender, EventArgs e)
        {
            formXoaNhanVien xnv = new formXoaNhanVien();
            xnv.ShowDialog();
            xnv = null;
        }


        // Nut them phong ban
        private void ThemXoaPhongBan(object sender, EventArgs e)
        {
            ThemXoaPhongBan txpb = new ThemXoaPhongBan();
            txpb.ShowDialog();
            txpb = null;
        }


        // Nut dong chuong trinh
        private void formMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isexit == true)
            {
                
                Application.Exit();
            }
        }


        // Nut sua nhan vien
        private void sửaNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SuaNhanVien snv = new SuaNhanVien();
            snv.ShowDialog();
            snv = null;
        }


        // Nut danh sach nhan vien
        private void smDanhSach_Click(object sender, EventArgs e)
        {
            sqlconMain = new SqlConnection(formDangNhap.ChuoiketNoi);
            if (sqlconMain.State == ConnectionState.Closed)
            {
                sqlconMain.Open();
            }
            loadTable("select * from NHANVIEN");
            sqlconMain.Close();
        }


        // Nut clear
        private void button1_Click(object sender, EventArgs e)
        {
            dtgvMain.DataSource = null;
            tbMnv.Text = string.Empty;
            tbHoTen.Text = string.Empty;
            tbPhongBan.Text = string.Empty;
        }


        // Nut tim kiem
        private void btTimKiemNV_Click(object sender, EventArgs e)
        {
            
            
            
            

            if(tbMnv.Text == string.Empty && tbHoTen.Text==string.Empty && tbPhongBan.Text == string.Empty)
            {

            }
            else
            {
                sqlconMain = new SqlConnection(formDangNhap.ChuoiketNoi);
                    if (sqlconMain.State == ConnectionState.Closed)
                    {
                        sqlconMain.Open();
                    }
                if (tbMnv.Text != string.Empty && tbHoTen.Text == string.Empty && tbPhongBan.Text == string.Empty) {
                    loadTable("SELECT * FROM NHANVIEN WHERE MaNhanVien = '" + tbMnv.Text + "'");
                } else if (tbMnv.Text != string.Empty && tbHoTen.Text != string.Empty && tbPhongBan.Text == string.Empty)
                {
                    loadTable("SELECT * FROM NHANVIEN WHERE MaNhanVien = '" + tbMnv.Text + "' and HoTen = N'" + tbHoTen.Text + "'");
                } else if(tbMnv.Text==string.Empty && tbHoTen.Text!=string.Empty && tbPhongBan.Text==string.Empty){
                    loadTable("SELECT * FROM NHANVIEN WHERE HoTen = N'" + tbHoTen.Text + "'");
                }else if (tbMnv.Text == string.Empty && tbHoTen.Text != string.Empty && tbPhongBan.Text != string.Empty)
                {
                    loadTable("SELECT * FROM NHANVIEN WHERE HoTen = N'" + tbHoTen.Text + "' and PhongBan = '" + tbPhongBan.Text + "';");
                }else if(tbMnv.Text != string.Empty && tbHoTen.Text == string.Empty && tbPhongBan.Text != string.Empty)
                {
                    loadTable("SELECT * FROM NHANVIEN WHERE MaNhanVien = '" + tbMnv.Text + "'and PhongBan = '" + tbPhongBan.Text + "';");
                }else if(tbMnv.Text == string.Empty && tbHoTen.Text == string.Empty && tbPhongBan.Text != string.Empty)
                {
                    loadTable("SELECT * FROM NHANVIEN WHERE PhongBan = '" + tbPhongBan.Text + "';");
                }
                
                else
                {
                    loadTable("SELECT * FROM NHANVIEN WHERE MaNhanVien = '" + tbMnv.Text + "' and HoTen = N'" + tbHoTen.Text + "' and PhongBan = '" + tbPhongBan.Text + "';");
                }
                
                sqlconMain.Close();

            } 

            
            

            
        }
    }
}


