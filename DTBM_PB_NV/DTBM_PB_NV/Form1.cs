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
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DTBM_PB_NV
{
    public partial class Form1 : Form
    {
        String strConn = @"Data Source=LAPTOP-8MJ97B04;Initial Catalog=lab04_DTB;Integrated Security=True";
        SqlConnection sqlConn;
        String sqlCode;
        SqlCommand sqlComm;
        SqlDataReader sqlRead;
        private void HienThi()
        {

            listView1.Items.Clear();
            sqlConn.Open();
            sqlCode = @"SELECT * FROM PHONGBAN;";
            sqlComm = new SqlCommand(sqlCode, sqlConn);
            sqlRead = sqlComm.ExecuteReader();
            int i = 0;
            while (sqlRead.Read())
            {
                listView1.Items.Add(sqlRead["MaPhongBan"].ToString());
                listView1.Items[i].SubItems.Add(sqlRead["TenPhongBan"].ToString());
                listView1.Items[i].SubItems.Add(sqlRead["SoDT"].ToString());
                listView1.Items[i].SubItems.Add(sqlRead["DiaDiem"].ToString());
                i++;
            }
            sqlConn.Close();
        }

        private void HienThiNhanVien()
        {
            listView2.Items.Clear();
            sqlConn.Open();
            sqlCode = @"SELECT * FROM NHANVIEN";
            sqlComm = new SqlCommand(sqlCode, sqlConn);
            sqlRead = sqlComm.ExecuteReader();
            int i = 0;
            while (sqlRead.Read())
            {
                listView2.Items.Add(sqlRead["MaNhanVien"].ToString());
                listView2.Items[i].SubItems.Add(sqlRead["HoTen"].ToString());
                listView2.Items[i].SubItems.Add(sqlRead["DiaChi"].ToString());
                listView2.Items[i].SubItems.Add(sqlRead["SoDienThoai"].ToString());
                listView2.Items[i].SubItems.Add(sqlRead["MaPhongBan"].ToString());
                i++;
            }
            sqlConn.Close();
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConn = new SqlConnection(strConn);
            HienThi();
            HienThiNhanVien();
        }
        //private void ThemPB()
        //{
        //    listView1.Items.Clear();
        //    sqlConn.Open();

        //    // Insert into PHONGBAN
        //    sqlCode = @"INSERT INTO PHONGBAN VALUES(@MaPB, @TenPB, @SoDT, @DiaDiem)";
        //    sqlComm = new SqlCommand(sqlCode, sqlConn);
        //    sqlComm.Parameters.AddWithValue("@MaPB", txtMaPB.Text);
        //    sqlComm.Parameters.AddWithValue("@TenPB", txtTenPB.Text);
        //    sqlComm.Parameters.AddWithValue("@SoDT", txtSoDT.Text);
        //    sqlComm.Parameters.AddWithValue("@DiaDiem", txtDiaDiem.Text);
        //    sqlComm.ExecuteNonQuery();

        //    sqlConn.Close();
        //    HienThi();
        //}

        //private void ThemNV()
        //{
        //    listView2.Items.Clear();
        //    sqlConn.Open();

        //    // Insert into NHANVIEN
        //    sqlCode = @"INSERT INTO NHANVIEN VALUES(@MaNV, @HoTen, @DiaChi, @SoDT_NV, @MaPB_NV)";
        //    sqlComm = new SqlCommand(sqlCode, sqlConn);
        //    sqlComm.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
        //    sqlComm.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
        //    sqlComm.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
        //    sqlComm.Parameters.AddWithValue("@SoDT_NV", txtSoDT_NV.Text);
        //    sqlComm.Parameters.AddWithValue("@MaPB_NV", txtMaPB_NV.Text);
        //    sqlComm.ExecuteNonQuery();

        //    sqlConn.Close();
        //    HienThi();
        //}
        private void btnThem_Click(object sender, EventArgs e)
        {
            //listView1.Items.Clear();
            //listView2.Items.Clear();
            //sqlConn.Open();

            //// Insert into PHONGBAN
            ////sqlCode = @"INSERT INTO PHONGBAN VALUES(@MaPB, @TenPB, @SoDT, @DiaDiem)";
            ////sqlComm = new SqlCommand(sqlCode, sqlConn);
            ////sqlComm.Parameters.AddWithValue("@MaPB", txtMaPB.Text);
            ////sqlComm.Parameters.AddWithValue("@TenPB", txtTenPB.Text);
            ////sqlComm.Parameters.AddWithValue("@SoDT", txtSoDT.Text);
            ////sqlComm.Parameters.AddWithValue("@DiaDiem", txtDiaDiem.Text);
            ////sqlComm.ExecuteNonQuery();

            //// Insert into NHANVIEN
            ////sqlCode = @"INSERT INTO NHANVIEN VALUES(@MaNV, @HoTen, @DiaChi, @SoDT_NV, @MaPB_NV)";
            ////sqlComm = new SqlCommand(sqlCode, sqlConn);
            ////sqlComm.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
            ////sqlComm.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
            ////sqlComm.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
            ////sqlComm.Parameters.AddWithValue("@SoDT_NV", txtSoDT_NV.Text);
            ////sqlComm.Parameters.AddWithValue("@MaPB_NV", txtMaPB_NV.Text);
            ////sqlComm.ExecuteNonQuery();

            //DialogResult f = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (f == DialogResult.Yes)
            //{
            //    sqlCode = @"INSERT INTO PHONGBAN VALUES(@MaPB, @TenPB, @SoDT, @DiaDiem)";
            //    sqlComm = new SqlCommand(sqlCode, sqlConn);
            //    sqlComm.Parameters.AddWithValue("@MaPB", txtMaPB.Text);
            //    sqlComm.Parameters.AddWithValue("@TenPB", txtTenPB.Text);
            //    sqlComm.Parameters.AddWithValue("@SoDT", txtSoDT.Text);
            //    sqlComm.Parameters.AddWithValue("@DiaDiem", txtDiaDiem.Text);
            //    sqlComm.ExecuteNonQuery();
            //}
            //if (f == DialogResult.No)
            //{
            //    sqlCode = @"INSERT INTO NHANVIEN VALUES(@MaNV, @HoTen, @DiaChi, @SoDT_NV, @MaPB_NV)";
            //    sqlComm = new SqlCommand(sqlCode, sqlConn);
            //    sqlComm.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
            //    sqlComm.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
            //    sqlComm.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
            //    sqlComm.Parameters.AddWithValue("@SoDT_NV", txtSoDT_NV.Text);
            //    sqlComm.Parameters.AddWithValue("@MaPB_NV", txtMaPB_NV.Text);
            //    sqlComm.ExecuteNonQuery();
            //}

            //sqlConn.Close();
            //HienThi();
            //HienThiNhanVien();
            listView1.Items.Clear();
            listView2.Items.Clear();
            sqlConn.Open();

            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Bạn muốn thêm dữ liệu vào bảng nào?",
                StartPosition = FormStartPosition.CenterScreen
            };

            System.Windows.Forms.Button btnPB = new System.Windows.Forms.Button() { Text = "Phòng ban", Left = 50, Width = 100, Top = 20 };
            System.Windows.Forms.Button btnNV = new System.Windows.Forms.Button() { Text = "Nhân viên", Left = 350, Width = 100, Top = 20 };

            btnPB.Click += (senderPB, ePB) =>
            {             //// Insert into PHONGBAN
                sqlCode = @"INSERT INTO PHONGBAN VALUES(@MaPB, @TenPB, @SoDT, @DiaDiem)";
                sqlComm = new SqlCommand(sqlCode, sqlConn);
                sqlComm.Parameters.AddWithValue("@MaPB", txtMaPB.Text);
                sqlComm.Parameters.AddWithValue("@TenPB", txtTenPB.Text);
                sqlComm.Parameters.AddWithValue("@SoDT", txtSoDT.Text);
                sqlComm.Parameters.AddWithValue("@DiaDiem", txtDiaDiem.Text);
                sqlComm.ExecuteNonQuery(); 
                prompt.Close();
            };
            btnNV.Click += (senderNV, eNV) =>
            {              //// Insert into NHANVIEN
            sqlCode = @"INSERT INTO NHANVIEN VALUES(@MaNV, @HoTen, @DiaChi, @SoDT_NV, @MaPB_NV)";
            sqlComm = new SqlCommand(sqlCode, sqlConn);
            sqlComm.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
            sqlComm.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
            sqlComm.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
            sqlComm.Parameters.AddWithValue("@SoDT_NV", txtSoDT_NV.Text);
            sqlComm.Parameters.AddWithValue("@MaPB_NV", txtMaPB_NV.Text);
            sqlComm.ExecuteNonQuery(); 
                prompt.Close(); };

            prompt.Controls.Add(btnPB);
            prompt.Controls.Add(btnNV);
            prompt.ShowDialog();
            sqlConn.Close();
            HienThi();
            HienThiNhanVien();
        }


        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            sqlConn.Open();

            // Xóa từ bảng NHANVIEN
            sqlCode = @"DELETE FROM NHANVIEN WHERE (MaNhanVien = N'" + txtMaNV.Text + @"')";
            sqlComm = new SqlCommand(sqlCode, sqlConn);
            sqlComm.ExecuteNonQuery();

            // Xóa từ bảng PHONGBAN
            sqlCode = @"DELETE FROM PHONGBAN WHERE (MaPhongBan = N'" + txtMaPB.Text + @"')";
            sqlComm = new SqlCommand(sqlCode, sqlConn);
            sqlComm.ExecuteNonQuery();

            sqlConn.Close();
            HienThi();
            HienThiNhanVien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            sqlConn.Open();

            // Cập nhật bảng NHANVIEN
            sqlCode = @"UPDATE NHANVIEN 
                SET MaNhanVien=N'" + txtMaNV.Text + @"', HoTen=N'" + txtHoTen.Text + @"', DiaChi=N'" + txtDiaChi.Text + @"', SoDienThoai=N'" + txtSoDT_NV.Text + @"', MaPhongBan=N'" + txtMaPB_NV.Text + @"'
                WHERE (MaNhanVien = N'" + txtMaNV.Text + @"')";
            sqlComm = new SqlCommand(sqlCode, sqlConn);
            sqlComm.ExecuteNonQuery();

            // Cập nhật bảng PHONGBAN
            sqlCode = @"UPDATE PHONGBAN 
                SET MaPhongBan=N'" + txtMaPB.Text + @"', TenPhongBan=N'" + txtTenPB.Text + @"', DiaDiem=N'" + txtDiaDiem.Text + @"', SoDT=N'" + txtSoDT.Text + @"'
                WHERE (MaPhongBan = N'" + txtMaPB.Text + @"')";
            sqlComm = new SqlCommand(sqlCode, sqlConn);
            sqlComm.ExecuteNonQuery();

            sqlConn.Close();
            HienThi();
            HienThiNhanVien();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //PHONGBAN
            txtMaPB.Text = "";
            txtTenPB.Text = "";
            txtSoDT.Text = "";
            txtDiaDiem.Text = "";
            //NHANVIEN
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtSoDT_NV.Text = "";
            txtMaPB_NV.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                txtMaPB.Text = listView1.SelectedItems[0].Text;
                txtTenPB.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtSoDT.Text = listView1.SelectedItems[0].SubItems[2].Text;
                txtDiaDiem.Text = listView1.SelectedItems[0].SubItems[3].Text;
            }

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                txtMaNV.Text = listView2.SelectedItems[0].Text;
                txtHoTen.Text = listView2.SelectedItems[0].SubItems[1].Text;
                txtDiaChi.Text = listView2.SelectedItems[0].SubItems[2].Text;
                txtSoDT_NV.Text = listView2.SelectedItems[0].SubItems[3].Text;
                txtMaPB_NV.Text = listView2.SelectedItems[0].SubItems[4].Text;
            }
        }
    }
}

