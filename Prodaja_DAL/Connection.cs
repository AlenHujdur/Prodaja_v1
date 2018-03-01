using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodaja_DAL
{
    public class Connection
    {
        public static SqlConnection getConnection()
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.ProdajaSQLConnectionString);
            cn.Open();
            return cn;

        }
    }
}
