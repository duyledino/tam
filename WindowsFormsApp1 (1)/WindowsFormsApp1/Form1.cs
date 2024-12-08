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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Form currentForm = null;
        private object formnhanVienKho;

        private void thựcPhẩmChứcNăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thucPhamchucNang formThucPhamChucNang = new thucPhamchucNang();

            formThucPhamChucNang.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void giảmĐauHạSốtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiamDauHaSot formGiamDauHaSot = new GiamDauHaSot();
                formGiamDauHaSot.Show();
        }

        private void mắtMũiMiệngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            matMuiMieng formmatMuiMieng = new matMuiMieng();
            formmatMuiMieng.Show();
        }

        private void nhânViênKiểmThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
           nhanVienThuoc formnhanVienThuoc = new nhanVienThuoc();
            formnhanVienThuoc.Show();
        }

        private void nhânViênQuảnLýKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           nhanVienKho formnhanVienKho= new nhanVienKho();
            formnhanVienKho.Show();
        }

        private void xemThôngTinNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhapKho formnhapkho = new NhapKho();
            formnhapkho.Show();
        }

        private void xemThôngTinXuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           XuatKho formxuatkho = new XuatKho();
            formxuatkho.Show();
        }
    }
}
