using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QUANLY
{
   public class DTO_ThanhVien
    {
        private int thanhVienId;
        private string thanhVienName;
        private string thanhVienPhone;
        private string thanhVienEmail;

        public DTO_ThanhVien()
        {

        }
        public DTO_ThanhVien(int thanhVienId, string thanhVienName, string thanhVienPhone, string thanhVienEmail)
        {
            ThanhVienId = thanhVienId;
            ThanhVienName = thanhVienName;
            ThanhVienPhone = thanhVienPhone;
            ThanhVienEmail = thanhVienEmail;
        }

        public int ThanhVienId
        {
            get
            {
                return thanhVienId;
            }

            set
            {
                thanhVienId = value;
            }
        }

        public string ThanhVienName
        {
            get
            {
                return thanhVienName;
            }

            set
            {
                thanhVienName = value;
            }
        }

        public string ThanhVienPhone
        {
            get
            {
                return thanhVienPhone;
            }

            set
            {
                thanhVienPhone = value;
            }
        }

        public string ThanhVienEmail
        {
            get
            {
                return thanhVienEmail;
            }

            set
            {
                thanhVienEmail = value;
            }
        }





    }
}
