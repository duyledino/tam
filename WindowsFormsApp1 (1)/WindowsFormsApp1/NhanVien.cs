using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public enum loaiNhanVien { KiemThuoc,QuanLyKho}
    [Serializable]
    public class NhanVien
    {
        private string name;
        private DateTime dob;
        private loaiNhanVien loaiNhanVien;
        private string id;

        public string Id { get => id; set => id = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public loaiNhanVien LoaiNhanVien { get => loaiNhanVien; set => loaiNhanVien = value; }
        public string Name { get => name; set => name = value; }

        public double Luong
        {
            get
            {
                if (this.LoaiNhanVien == loaiNhanVien.QuanLyKho) return 5000000;
                return 5100000;
            }
        }
        public NhanVien() { }
        public NhanVien(string id,string name,DateTime dob,loaiNhanVien loaiNhanVien)
        {
            this.Id = id;
            this.Name = name;
            this.Dob = dob;
            this.LoaiNhanVien = loaiNhanVien;
        }
    }
}
