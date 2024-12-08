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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class NhapKho : Form
    {
        private CXuLyKho xulyKho = new CXuLyKho();
        List<KiemSoatKho> list = new List<KiemSoatKho>();
        List<CLoaiThuoc> khoTam = new List<CLoaiThuoc>();
        public NhapKho()
        {
            InitializeComponent();
        }
        private void show()
        {
            list.Clear();
            foreach(KiemSoatKho temp in xulyKho.getKhoList())
            {
                if(temp.loaiHinh == loaiHinh.nhap)
                {
                    list.Add(temp);
                }
            }
            dataGridView1.AutoGenerateColumns = false;
            BindingSource bs = new BindingSource();
            bs.DataSource = list;
            dataGridView1.DataSource = bs;
        }
        private void Luu()
        {
            if (CData.writeFile("data.dat"))
            {
                MessageBox.Show("Luu thanh cong");
            }
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            if (CData.readFile("data.dat"))
            {
                xulyKho = new CXuLyKho();
                show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CLoaiThuoc temp = new CLoaiThuoc();
            temp.MaT = maThuoc.Text.ToString();
            temp.TenT = tenThuoc.Text.ToString();
            temp.DonGia = int.Parse(giaThuoc.Text.ToString());
            temp.SoLuong = int.Parse(soLuongThuoc.Text.ToString());
            temp.NgayHH = dateTimePicker2.Value;
            string loai = comboBox1.Text.ToString();
            if (loai == "Thực Phẩm Chức Năng") temp.LoaiThuoc = loaiThuoc.Thucphamchucnang;
            else if (loai == "Giảm Đau Hạ Sốt") temp.LoaiThuoc = loaiThuoc.Giamdauhasot;
            else temp.LoaiThuoc = loaiThuoc.Matmuimieng;
            khoTam.Add(temp);
            maThuoc.Text = "";
            tenThuoc.Text = "";
            giaThuoc.Text = "";
            soLuongThuoc.Text = "";
            dateTimePicker2.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maThuoc.Text = "";
            tenThuoc.Text = "";
            giaThuoc.Text = "";
            soLuongThuoc.Text = "";
            KiemSoatKho temp = new KiemSoatKho();
            if (tdtBtn.Checked == true)
            {
                temp.location = diaDiem.DaiHocTonDucThang;
            } else if (rmitBtn.Checked == true) {
                temp.location = diaDiem.DaiHocRMIT;
            }
            else
            {
                temp.location = diaDiem.DaiHocBachKhoa;
            }
            
            temp.date = dateTimePicker1.Value;
            temp.list = khoTam;
            temp.loaiHinh = loaiHinh.nhap;
            dateTimePicker2.Value = DateTime.Now;
            if (xulyKho.nhapKho(temp))
            {
                MessageBox.Show("Them vao kho thanh cong");
                Luu();
            }
            else
            {
                MessageBox.Show("Khong the them vao kho");
            }
        }

       
    }
}
