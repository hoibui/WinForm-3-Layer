using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QUANLY
{
   public class DBConnect
    {
        protected SqlConnection conn = new SqlConnection("Data Source=SGH649TX7D\\SQLEXPRESS;Initial Catalog=QUANLY;Integrated Security=True");
    }
}
