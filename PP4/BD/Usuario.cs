using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    public class Usuario
    {
        #region atributos
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string ocupacion { get; set; }
        public int id_rol { get; set; }
        public string userName { get; set; }
        public string contraseña { get; set; }
        #endregion

        #region metodos
        public static void Registrar_Usuario(string cedula, string nombre, string apellido1, string apellido2, string ocupacion, int id_rol, string username, string contrasena)
        {
            Conexion nueva = new Conexion();
            Usuario nuevo = new Usuario();
            nuevo.cedula = cedula;
            nuevo.nombre = nombre;
            nuevo.apellido1 = apellido1;
            nuevo.apellido2 = apellido2;
            nuevo.ocupacion = ocupacion;
            nuevo.id_rol = id_rol;
            nuevo.userName = username;
            nuevo.contraseña = contrasena;
            SqlCommand cmd = new SqlCommand("Registrar_Usuario");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = nueva.objconexion();
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue(@"cedula", nuevo.cedula);
            cmd.Parameters.AddWithValue(@"nombre", nuevo.nombre);
            cmd.Parameters.AddWithValue(@"apellido1", nuevo.apellido1);
            cmd.Parameters.AddWithValue(@"apellido2", nuevo.apellido2);
            cmd.Parameters.AddWithValue(@"ocupacion", nuevo.ocupacion);
            cmd.Parameters.AddWithValue(@"id_rol", nuevo.id_rol);
            cmd.Parameters.AddWithValue(@"userName", nuevo.userName);
            cmd.Parameters.AddWithValue(@"contraseña", nuevo.contraseña);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public static void Actualiza_Usuario(string cedula, string nombre, string apellido1, string apellido2, string ocupacion, string contrasena)
        {
            Conexion nueva = new Conexion();
            Usuario nuevo = new Usuario();
            nuevo.cedula = cedula;
            nuevo.nombre = nombre;
            nuevo.apellido1 = apellido1;
            nuevo.apellido2 = apellido2;
            nuevo.ocupacion = ocupacion;
            nuevo.contraseña = contrasena;
            SqlCommand cmd = new SqlCommand("Actualizar_Usuario");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = nueva.objconexion();
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue(@"cedula", nuevo.cedula);
            cmd.Parameters.AddWithValue(@"nombre", nuevo.nombre);
            cmd.Parameters.AddWithValue(@"apellido1", nuevo.apellido1);
            cmd.Parameters.AddWithValue(@"apellido2", nuevo.apellido2);
            cmd.Parameters.AddWithValue(@"ocupacion", nuevo.ocupacion);
            cmd.Parameters.AddWithValue(@"contraseña", nuevo.contraseña);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }

        public static byte Validar_Cedula(int id)
        {
            Conexion nueva = new Conexion();
            SqlCommand cmd = new SqlCommand("Execute dbo.Validar_Cedula");
            cmd.Connection = nueva.objconexion();
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue(@"id", id);
            byte resultado = (Byte)cmd.ExecuteScalar();
            cmd.Connection.Close();
            return resultado;

        }
        public static byte Validar_Nick(string username)
        {
            Conexion nueva = new Conexion();
            SqlCommand cmd = new SqlCommand("Execute dbo.Validar_Nick");
            cmd.Connection = nueva.objconexion();
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue(@"username", username);
            byte resultado = (Byte)cmd.ExecuteScalar();
            cmd.Connection.Close();
            return resultado;

        }


        #endregion
    }
}
