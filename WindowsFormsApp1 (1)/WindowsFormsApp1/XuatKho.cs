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
    public partial class XuatKho : Form
    {
        public XuatKho()
        {
            InitializeComponent();
        }
        private CXuLyKho xulyKho = new CXuLyKho();
        List<KiemSoatKho> list = new List<KiemSoatKho>();
        List<CLoaiThuoc> khoTam = new List<CLoaiThuoc>();
        private void show()
        {
            list.Clear();
            foreach (KiemSoatKho temp in xulyKho.getKhoList())
            {
                if (temp.loaiHinh == loaiHinh.xuat)
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

        private void XuatKho_Load(object sender, EventArgs e)
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
            }
            else if (rmitBtn.Checked == true)
            {
                temp.location = diaDiem.DaiHocRMIT;
            }
            else
            {
                temp.location = diaDiem.DaiHocBachKhoa;
            }
            temp.date = dateTimePicker1.Value;
            temp.list = khoTam;
            dateTimePicker2.Value = DateTime.Now;
            temp.loaiHinh = loaiHinh.xuat;
            if (xulyKho.xuatKho(temp))
            {
                MessageBox.Show("Xuất kho thanh cong");
                Luu();
            }
            else
            {
                MessageBox.Show("Khong the xuat kho");
            }
        }

        private void maThuoc_KeyUp(object sender, KeyEventArgs e)
        {
            List<string> cboSource = new List<string>();
            CXuLyThuoc xuLyThuoc = new CXuLyThuoc();
            if (maThuoc.Text == "")
            {
                cboSource.Add("Thực phẩm chức năng");
                cboSource.Add("Mắt mũi miệng");
                cboSource.Add("Giảm đau hạ sốt");
                tenThuoc.Text = "";
                comboBox1.DataSource = cboSource;
                soLuongThuoc.Text = "";
                dateTimePicker1.Value = DateTime.Now;
                giaThuoc.Text = "";
            }
            else
            {
                CLoaiThuoc temp = xuLyThuoc.tim(maThuoc.Text.ToString());
                if (temp != null)
                {
                    switch (temp.LoaiThuoc)
                    {
                        case loaiThuoc.Giamdauhasot:
                            cboSource.Add("Giảm đau hạ sốt");
                            break;
                        case loaiThuoc.Matmuimieng:
                            cboSource.Add("Mắt mũi miệng");
                            break;
                        case loaiThuoc.Thucphamchucnang:
                            cboSource.Add("Thực phẩm chức năng");
                            break;
                    }
                    tenThuoc.Text = temp.TenT;
                    comboBox1.DisplayMember = "LoaiThuoc";
                    comboBox1.ValueMember = "MaT";
                    comboBox1.DataSource = cboSource;
                    soLuongThuoc.Text = temp.SoLuong.ToString();
                    dateTimePicker2.Value = temp.NgayHH;
                    giaThuoc.Text = temp.DonGia.ToString();
                }
            }
        }
    }
}
