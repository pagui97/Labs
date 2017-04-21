using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    class Conexion {



        public SqlConnection objconexion()
        {
            SqlConnection nueva = new SqlConnection();
            nueva.ConnectionString = @"Data Source=PAGUIMENDEZ\SQL2014N1;Initial Catalog=labs;Integrated Security=True";
            return nueva;
        }


    }
}
