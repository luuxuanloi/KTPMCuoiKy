using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dangkyvephim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbPhim.SelectedText = "---Chọn Phim---";
            cbSuat.SelectedText = "---Chọn Suất---";
            cbGhe.SelectedText = "---Chọn Ghế Ngồi---";
        }       

        public string NDK, Phim, Suat, Ghe;
        public DateTime Ngay;

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            GetItem();
            insert();
            clear();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public void GetItem()
        {
            NDK = txtNDK.Text;
            Ngay = dtpDat.Value.Date;
            Phim = cbPhim.Text;
            Suat = cbSuat.Text;
            Ghe = cbGhe.Text;
        }

        public void insert()
        {
            KetNoi.ketnoiAccess();
            KetNoi.ThucThiLenh("INSERT INTO RapPhim VALUES('" + NDK + "','" + Ngay + "','" + Phim + "','" + Suat + "','" + Ghe + "')");
            MessageBox.Show("Thêm dữ liệu thành công");
        }

        public void clear()
        {
            txtNDK.Text = "";
            cbPhim.SelectedItem = "---Chọn Phim---";
            cbSuat.SelectedItem = "---Chọn Suất---";
            cbGhe.SelectedItem = "---Chọn Ghế Ngồi---";
        }
    }
}
