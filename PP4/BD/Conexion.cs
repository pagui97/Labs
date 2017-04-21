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
            nueva.ConnectionString = "Data Source=DESKTOP-DL12JHA;Initial Catalog=labs;Integrated Security=True";
            return nueva;
        }


    }
}
