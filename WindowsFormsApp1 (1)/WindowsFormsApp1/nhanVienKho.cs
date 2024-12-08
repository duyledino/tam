using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace WindowsFormsApp1
{
    public partial class nhanVienKho : Form
    {
        public nhanVienKho()
        {
            InitializeComponent();
        }
        CXuLyNhanVien nv = new CXuLyNhanVien();
        List<NhanVien> list = new List<NhanVien>();
        NhanVien tam;
        int i = 0;
        private void Luu()
        {
            if (CData.writeFile("data.dat"))
            {
                MessageBox.Show("Luu thanh cong");
            }
        }
        private void show()
        {
            nv = new CXuLyNhanVien();
            list.Clear();
            foreach (NhanVien temp in nv.getList())
            {
                if (temp.LoaiNhanVien == loaiNhanVien.QuanLyKho) list.Add(temp);
            }
            if (list.Count > 0) {
                manv.Text = list[i].Id;
                tennv.Text = list[i].Name;
                dateTimePicker1.Value = list[i].Dob;
                luong.Text = list[i].Luong.ToString();
                label6.Text = $"{i + 1}/{list.Count}";
            }
            else
            {
                manv.Text = "";
                tennv.Text = "";
                dateTimePicker1.Value = DateTime.Now;
                luong.Text = "";
                label6.Text = $"{0}/{list.Count}";
            }
        }
        private void nhanVienKho_Load(object sender, EventArgs e)
        {
            if (!CData.IsFileOpen("data.dat"))
            {
                if (CData.readFile("data.dat"))
                {
                    nv = new CXuLyNhanVien();
                    foreach (NhanVien temp in nv.getList())
                    {
                        if (temp.LoaiNhanVien == loaiNhanVien.QuanLyKho) list.Add(temp);
                    }
                    show();
                }
            }
            else
            {
                nv = new CXuLyNhanVien();
                foreach (NhanVien temp in nv.getList())
                {
                    if (temp.LoaiNhanVien == loaiNhanVien.QuanLyKho) list.Add(temp);
                }
                show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                i = list.Count - 1;
            }
            else i--;
            show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i == list.Count-1)
            {
                i = 0;
            }
            else i++;
            show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NhanVien temp = new NhanVien();
            temp.Name = tennv.Text.ToString();
            temp.Id = manv.Text.ToString();
            temp.Dob = dateTimePicker1.Value;
            temp.LoaiNhanVien = loaiNhanVien.QuanLyKho;
            if (nv.them(temp))
            {
                MessageBox.Show("Them Thanh Cong");
                show();
                Luu();
            }
            else
            {
                MessageBox.Show("Đã tồn tại nhân viên này");
                show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NhanVien temp = new NhanVien();
            temp.Name = tennv.Text.ToString();
            temp.Id = manv.Text.ToString();
            temp.Dob = dateTimePicker1.Value;
            temp.LoaiNhanVien = loaiNhanVien.QuanLyKho;
            if (nv.sua(tam.Id, temp))
            {
                MessageBox.Show("Sua Thanh Cong");
                show();
                Luu();
            }
            else
            {
                MessageBox.Show("Nhân viên không tồn tại hoặc đã tồn tại nhân viên này");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NhanVien temp = nv.tim(manv.Text.ToString());
            if(nv.xoa(temp))
            {
                MessageBox.Show("Xoa Thanh Cong");
                if (i == nv.getList().Count) i--;
                show();
                Luu();
            }
        }

        private void manv_MouseClick(object sender, MouseEventArgs e)
        {
            tam = nv.tim(manv.Text.ToString());
        }
    }
}
