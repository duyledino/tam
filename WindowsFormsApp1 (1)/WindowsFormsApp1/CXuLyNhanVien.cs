using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class CXuLyNhanVien
    {
        private List<NhanVien> tList;
        public CXuLyNhanVien()
        {
            tList = CData.create().getnvList();
        }
        public List<NhanVien> getList()
        {
            return tList;
        }
        public NhanVien tim(string id)
        {
            foreach (NhanVien t in tList)
            {
                if (t.Id == id) return t;
            }
            return null;
        }
        public bool them(NhanVien nv)
        {
            try
            {
                if (tim(nv.Id) == null)
                {
                    tList.Add(nv);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public bool sua(string id,NhanVien nv)
        {
            try
            {
                foreach(NhanVien tam in tList)
                {
                    if (tam.Id == nv.Id) return false;
                }
                NhanVien temp = tim(id);
                temp.Name = nv.Name;
                temp.Id = nv.Id;
                temp.Dob = nv.Dob;
                temp.LoaiNhanVien = nv.LoaiNhanVien;
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public bool xoa(NhanVien nv)
        {
            try
            {
                tList.Remove(nv);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public List<NhanVien> nvKhoList()
        {
            List<NhanVien> kho = new List<NhanVien>();
            foreach (NhanVien nv in tList)
            {
                if(nv.LoaiNhanVien == loaiNhanVien.QuanLyKho ) kho.Add(nv);
            }
            return kho;
        }
        public List<NhanVien> nvThuocList()
        {
            List<NhanVien> thuoc = new List<NhanVien>();
            foreach (NhanVien nv in tList)
            {
                if (nv.LoaiNhanVien == loaiNhanVien.KiemThuoc) thuoc.Add(nv);
            }
            return thuoc;
        }
    }
}
