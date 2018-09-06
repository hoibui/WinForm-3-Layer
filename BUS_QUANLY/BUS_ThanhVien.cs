using DAL_QUANLY;
using DTO_QUANLY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QUANLY
{
   public class BUS_ThanhVien
    {
        DAL_ThanhVien dalThanhVien = new DAL_ThanhVien();
        
        public DataTable getThanhVien()
        {
            return dalThanhVien.getThanhVien();
        }

        public DataTable findThanhVien(string infor)
        {
            return dalThanhVien.findThanhVien(infor);
        }

        public bool addThanhVien(DTO_ThanhVien dtoThanhVien)
        {
            return dalThanhVien.addThanhVien(dtoThanhVien);
        }
        public bool editThanhVien(DTO_ThanhVien dtoThanhVien)
        {
            return dalThanhVien.editThanhVien(dtoThanhVien);
        }
        public bool deleteThanhVien( int ID)
        {
            return dalThanhVien.deleteThanhVien(ID);
        }
    }
}
