using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ET
{
    public class Connection
    {
        //public static SqlConnection conn = new SqlConnection("Data Source=MSI;Initial Catalog=NHOM3_QLSIEUTHICOOPMART;Integrated Security=True");
        // public static SqlConnection conn = new SqlConnection("Data Source=DESKTOP-P3GKJ3N\\SQLEXPRESS;Initial Catalog=NHOM3_QLSIEUTHICOOPMART;Integrated Security=True");
        public static SqlConnection conn = new SqlConnection("Data Source=NGOCTHU;Initial Catalog=NHOM3_QLSIEUTHICOOPMART;Integrated Security=True");
    }
}
