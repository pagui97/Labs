using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    class Conexion { 
    


        public void abrirConexion()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=DESKTOP-DL12JHA;Initial Catalog=labs;Integrated Security=True";
            conexion.Open();
        }
        public void cerrarConexion()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=DESKTOP-DL12JHA;Initial Catalog=labs;Integrated Security=True";
            conexion.Close();
        }

    }
}
