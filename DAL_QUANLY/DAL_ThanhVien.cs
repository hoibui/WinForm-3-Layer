using DTO_QUANLY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QUANLY
{
    public class DAL_ThanhVien:DBConnect
    {
        public DataTable getThanhVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT TV_ID as 'ID',TV_NAME as 'Name', TV_PHONE as 'Phone Number', TV_EMAIL as 'Email' FROM THANHVIEN",conn);
            DataTable dtThanhVien = new DataTable();
            da.Fill(dtThanhVien);
            return dtThanhVien;
        }

        public DataTable findThanhVien(string infor)
        {
            SqlDataAdapter daf = new SqlDataAdapter("SELECT TV_ID as 'ID',TV_NAME as 'Name', TV_PHONE as 'Phone Number', TV_EMAIL as 'Email' FROM THANHVIEN WHERE TV_NAME LIKE '" + infor+"%'", conn);
            DataTable dtThanhVien = new DataTable();
            daf.Fill(dtThanhVien);
            return dtThanhVien;

        }

        public bool addThanhVien(DTO_ThanhVien dtoThanhVien)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("INSERT INTO THANHVIEN(TV_NAME,TV_PHONE,TV_EMAIL) VALUES('{0}','{1}','{2}')",dtoThanhVien.ThanhVienName,dtoThanhVien.ThanhVienPhone,dtoThanhVien.ThanhVienEmail,conn);
                SqlCommand cmd = new SqlCommand(SQL,conn);
                if (cmd.ExecuteNonQuery() > 0)
                return true;
            }
            catch (Exception ex)
            {

               
            }
             finally
            {
                conn.Close();
            }

            return false;
        }

        public bool editThanhVien(DTO_ThanhVien dtoThanhVien)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE THANHVIEN SET TV_NAME='{0}',TV_PHONE='{1}',TV_EMAIL='{2}' WHERE TV_ID ='{3}'", dtoThanhVien.ThanhVienName, dtoThanhVien.ThanhVienPhone, dtoThanhVien.ThanhVienEmail,dtoThanhVien.ThanhVienId, conn);
                SqlCommand cmd = new SqlCommand(SQL, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception ex)
            {


            }
            finally
            {
                conn.Close();
            }

            return false;
        }

        public bool deleteThanhVien(int ID)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("DELETE FROM THANHVIEN WHERE TV_ID='{0}'",ID);
                SqlCommand cmd = new SqlCommand(SQL, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception ex)
            {


            }
            finally
            {
                conn.Close();
            }

            return false;
        }

    }
}
