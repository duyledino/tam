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
    [Serializable]
    internal class CData
    {
        private List<NhanVien> nvList;
        private List<CLoaiThuoc> tList;
        private List<KiemSoatKho> khoList;
        private static CData instance = null;
        private CData()
        {
            nvList = new List<NhanVien>();
            tList = new List<CLoaiThuoc>();
            khoList = new List<KiemSoatKho>();
        }

        public List<KiemSoatKho> getKhoList()
        {
            return khoList;
        }

        public List<NhanVien> getnvList()
        {
            return nvList;
        }
        public List<CLoaiThuoc> getThuocList()
        {
            return tList;
        }
        public static CData create()
        {
            if (instance == null)
            {
                instance = new CData();
            }
            return instance;
        }
        public static bool IsFileOpen(string filePath)
        {
            try
            {
                using (var stream = File.Open(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                {
                    return false; // File is not in use
                }
            }
            catch (IOException)
            {
                return true; // File is in use
            }
        }
        public static bool readFile(string filename)
        {
            try
            {
                FileStream fs;
                fs = new FileStream(filename, FileMode.Open);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                instance = (CData)binaryFormatter.Deserialize(fs);
                fs.Close();
                return true;
            }
            catch (Exception e)
            {
                {
                    MessageBox.Show($"Loi Doc File\n{e.Message}");
                    return false;
                }
            }
        }
        public static bool writeFile(string filename)
        {
            try
            {
                FileStream fs = new FileStream(filename, FileMode.Create);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, instance);
                fs.Close();
                return true;
            }
            catch (Exception e)
            {
                {
                    MessageBox.Show($"Loi Ghi File\n{e.Message}");
                    return false;
                }
            }
        }
    }
}
