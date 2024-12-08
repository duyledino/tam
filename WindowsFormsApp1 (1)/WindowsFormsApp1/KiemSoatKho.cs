using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public enum loaiHinh
    {
        nhap,xuat
    }
    public enum diaDiem
    {
        DaiHocTonDucThang,
        DaiHocRMIT,
        DaiHocBachKhoa
    }
    [Serializable]
    internal class KiemSoatKho
    {
        public List<CLoaiThuoc> list;
        public int soLuong { get {
                int sum = 0;
                foreach(CLoaiThuoc thuoc in list)
                {
                    sum += thuoc.SoLuong;
                }
                return sum; 
            } }
        public DateTime date {  get; set; }
        public diaDiem location { get; set; }
        public loaiHinh loaiHinh { get; set; }
        public double TongTien
        {
            get {
                int sum = 0;
                foreach (CLoaiThuoc thuoc in list)
                {
                    sum += thuoc.DonGia * thuoc.SoLuong;
                }
                return sum;
            }
        }

        public loaiThuoc Thongtinkho { get; internal set; }

        public KiemSoatKho()
        {
        }
        public KiemSoatKho(DateTime date,diaDiem location, List<CLoaiThuoc> thuoc, loaiHinh loaiHinh)
        {
            this.date = date;
            this.location = location;
            list = thuoc;
            this.loaiHinh = loaiHinh;
        }

    }
}
