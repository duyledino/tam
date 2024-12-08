using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class CXuLyThuoc
    {
        private List<CLoaiThuoc> tList;
        public CXuLyThuoc()
        {
            tList = CData.create().getThuocList();
        }
        public List<CLoaiThuoc> getList()
        {
            return tList;
        }

        public CLoaiThuoc tim(string id)
        {
            foreach (CLoaiThuoc t in getList())
            {
                if (t.MaT == id) return t;
            }
            return null;
        }
        public bool them(CLoaiThuoc cLoaiThuoc)
        {
            try
            {
                if(tim(cLoaiThuoc.MaT) == null) tList.Add(cLoaiThuoc);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public bool sua(CLoaiThuoc thuoc)
        {
            try
            {
                CLoaiThuoc temp = tim(thuoc.MaT);
                temp.MaT = thuoc.MaT;
                temp.LoaiThuoc = thuoc.LoaiThuoc;
                temp.TenT = thuoc.TenT;
                temp.NgayHH = thuoc.NgayHH;
                temp.DonGia = thuoc.DonGia;
                temp.SoLuong = thuoc.SoLuong;
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public bool xoa(string id)
        {
            try
            {
                CLoaiThuoc temp = tim(id);
                tList.Remove(temp);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
