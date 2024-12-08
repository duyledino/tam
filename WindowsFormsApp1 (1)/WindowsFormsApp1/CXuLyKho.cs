using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class CXuLyKho
    {
        internal List<KiemSoatKho> list;
        public List<CLoaiThuoc> thuocList;
        public CXuLyKho() {
            list = CData.create().getKhoList();
            thuocList = CData.create().getThuocList();
        }
        internal List<KiemSoatKho> getKhoList()
        {
            return list;
        }
        internal bool nhapKho(KiemSoatKho outSide)
        {
            try
            {
                list.Add(outSide);
                foreach (CLoaiThuoc temp in outSide.list)
                {
                    bool exist = false;
                    foreach (CLoaiThuoc ton in thuocList)
                    {
                        if (ton.MaT == temp.MaT)
                        {
                            ton.SoLuong += temp.SoLuong;
                            exist = true;
                            break;
                        }
                    }
                    if (!exist)
                    {
                        CLoaiThuoc thuocMoi = new CLoaiThuoc(temp.MaT, temp.TenT, temp.SoLuong, temp.NgayHH, temp.LoaiThuoc, temp.DonGia);
                        thuocList.Add(thuocMoi);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        internal bool xuatKho(KiemSoatKho outSide)
        {
            try
            {
                list.Add(outSide);
                foreach (CLoaiThuoc thuoc in outSide.list)
                {
                    foreach (CLoaiThuoc ton in thuocList)
                    {
                        if (thuoc.MaT == ton.MaT)
                        {
                            ton.SoLuong -= thuoc.SoLuong;
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
