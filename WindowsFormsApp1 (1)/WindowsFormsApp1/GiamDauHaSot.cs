using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GiamDauHaSot : Form
    {
        public GiamDauHaSot()
        {
            InitializeComponent();
        }

        CXuLyThuoc thuoc;
        List<CLoaiThuoc> list = new List<CLoaiThuoc>();
        private void show()
        {
            list.Clear();
            foreach (CLoaiThuoc temp in thuoc.getList())
            {
                if (temp.LoaiThuoc == loaiThuoc.Giamdauhasot) list.Add(temp);
            }
            dataGridView1.AutoGenerateColumns = false;
            BindingSource bs = new BindingSource();
            bs.DataSource = list;
            dataGridView1.DataSource = bs;
        }
        private void GiamDauHaSot_Load(object sender, EventArgs e)
        {
            if (!CData.IsFileOpen("data.dat"))
            {
                if (CData.readFile("data.dat"))
                {
                    thuoc = new CXuLyThuoc();
                    foreach (CLoaiThuoc temp in thuoc.getList())
                    {
                        if (temp.LoaiThuoc == loaiThuoc.Giamdauhasot) list.Add(temp);
                    }
                    show();
                }
            }
            else
            {
                thuoc = new CXuLyThuoc();
                foreach (CLoaiThuoc temp in thuoc.getList())
                {
                    if (temp.LoaiThuoc == loaiThuoc.Giamdauhasot) list.Add(temp);
                }
                show();
            }
        }
        private void Luu()
        {
            if (CData.writeFile("data.dat"))
            {
                MessageBox.Show("Luu thanh cong");
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            CLoaiThuoc temp = new CLoaiThuoc();
            temp.MaT = textBox1.Text.ToString();
            temp.TenT = textBox2.Text.ToString();
            temp.SoLuong = int.Parse(textBox3.Text.ToString());
            temp.DonGia = int.Parse(textBox4.Text.ToString());
            temp.NgayHH = dateTimePicker1.Value;
            temp.LoaiThuoc = loaiThuoc.Giamdauhasot;
            if (thuoc.them(temp))
            {
                MessageBox.Show("them thanh cong");
                Luu();
                show();

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string id = textBox1.Text.ToString();
            if (thuoc.xoa(id))
            {
                MessageBox.Show("Xoa thanh cong");
                Luu();
                show();

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            CLoaiThuoc temp = new CLoaiThuoc();
            temp.MaT = textBox1.Text.ToString();
            temp.TenT = textBox2.Text.ToString();
            temp.SoLuong = int.Parse(textBox3.Text.ToString());
            temp.DonGia = int.Parse(textBox4.Text.ToString());
            temp.NgayHH = dateTimePicker1.Value;
            temp.LoaiThuoc = loaiThuoc.Giamdauhasot;
            if (thuoc.sua(temp))
            {
                MessageBox.Show("Sua thanh cong");
                Luu();
                show();

            }
        }

        private void dataGridView1_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string id = row.Cells[0].Value.ToString();
                CLoaiThuoc temp = thuoc.tim(id);
                if (temp != null)
                {
                    textBox1.Text = temp.MaT;
                    textBox2.Text = temp.TenT;
                    textBox3.Text = temp.SoLuong.ToString();
                    textBox4.Text = temp.DonGia.ToString();
                    dateTimePicker1.Value = temp.NgayHH;
                }
            }
        }
    }
}
