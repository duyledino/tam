using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1
{
    public enum loaiThuoc { Thucphamchucnang, Giamdauhasot, Matmuimieng }

    [Serializable]

    public class CLoaiThuoc
    {
        private string m_mathuoc;
        private string m_tenthuoc;
        private int m_soluong;
        private DateTime m_ngayhh;
        private loaiThuoc m_loaithuoc;
        private int m_dongia;

        public CLoaiThuoc()
        {
            m_mathuoc = string.Empty;
            m_tenthuoc = string.Empty;
            m_soluong = 0;
            m_ngayhh = DateTime.Now;
            m_loaithuoc = loaiThuoc.Thucphamchucnang;
            m_dongia = 0;
        }

        public CLoaiThuoc(string mathuoc, string tenthuoc, int soluong, DateTime ngayhh, loaiThuoc loaithuoc, int dongia)
        {
            m_mathuoc = mathuoc;
            m_tenthuoc = tenthuoc;
            m_soluong = soluong;
            m_ngayhh = ngayhh;
            m_loaithuoc = loaithuoc;
            m_dongia = dongia;
        }

        public string MaT
        {
            get { return m_mathuoc; }
            set { m_mathuoc = value; }
        }

        public string TenT
        {
            get { return m_tenthuoc; }
            set { m_tenthuoc = value; }
        }

        public int SoLuong
        {
            get { return m_soluong; }
            set { m_soluong = value; }
        }

        public DateTime NgayHH
        {
            get { return m_ngayhh; }
            set { m_ngayhh = value; }
        }

        public loaiThuoc LoaiThuoc
        {
            get { return m_loaithuoc; }
            set { m_loaithuoc = value; }
        }

        public int DonGia
        {
            get { return m_dongia; }
            set { m_dongia = value; }
        }
    }
}





