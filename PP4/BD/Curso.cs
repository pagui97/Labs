using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    public  class Curso
    {
        public string id_cruso { get; set; }
        public string cedula { get; set; }
        public string nombre { get; set; }
        public int turno { get; set; }


        public static void Registrar_Curso(string id_curso, string cedula, string nombre, int turno)
        {
            Conexion nueva = new Conexion();
            
            Curso nuevo = new Curso();
            nuevo.id_cruso = id_curso;
            nuevo.cedula = cedula;
            nuevo.nombre = nombre;
            nuevo.turno = turno;
            SqlCommand cmd = new SqlCommand("Registrar_Curso");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = nueva.objconexion();
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue(@"id_curso", nuevo.id_cruso);
            cmd.Parameters.AddWithValue(@"cedula", nuevo.cedula);
            cmd.Parameters.AddWithValue(@"nombre", nuevo.nombre);
            cmd.Parameters.AddWithValue(@"turno", nuevo.turno);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            

        }

        public static void Actualizar_Curso(string id_curso, string cedula, string nombre, int turno)
        {
            Conexion nueva = new Conexion();
            Curso nuevo = new Curso();
            nuevo.id_cruso = id_curso;
            nuevo.cedula = cedula;
            nuevo.nombre = nombre;
            nuevo.turno = turno;
            SqlCommand cmd = new SqlCommand("Actualizar_Curso");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection.Open();
            cmd.Connection = nueva.objconexion();
            cmd.Parameters.AddWithValue(@"id_curso", nuevo.id_cruso);
            cmd.Parameters.AddWithValue(@"cedula", nuevo.cedula);
            cmd.Parameters.AddWithValue(@"nombre", nuevo.nombre);
            cmd.Parameters.AddWithValue(@"turno", nuevo.turno);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }

        public static void Eliminar_Curso(string id_curso)
        {
            Conexion nueva = new Conexion();
            nueva.objconexion().Open();
            Curso nuevo = new Curso();
            nuevo.id_cruso = id_curso;
            SqlCommand cmd = new SqlCommand("Eliminar_Curso");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection.Open();
            cmd.Connection = nueva.objconexion();
            cmd.Parameters.AddWithValue(@"id_curso", nuevo.id_cruso);
            cmd.ExecuteNonQuery();
            cmd.Connection.Open();
        }

        public static Curso Buscar_Curso(string id)
        {
            Conexion nueva = new Conexion();
            nueva.objconexion().Open();
            Curso nuevo = new Curso();
            SqlCommand cmd = new SqlCommand("Eliminar_Curso");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = nueva.objconexion();
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue(@"id_curso", id);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            nuevo.id_cruso = reader["id_curso"].ToString();
            nuevo.turno = int.Parse(reader["turno"].ToString());
            nuevo.nombre = reader["nombre"].ToString();
            nuevo.cedula = reader["cedula"].ToString();
            cmd.Connection.Close();
            reader.Dispose();
            cmd.Dispose();
            return nuevo;


        }

        public static List<Curso> Buscar_Curso_Cedula_Profesor(string id)
        {
            List<Curso> lista = new List<Curso>();
            Conexion nueva = new Conexion();
            nueva.objconexion().Open();
            SqlCommand cmd = new SqlCommand("Buscar_Curso_Cedula_Profesor");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = nueva.objconexion();
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue(@"id_curso", id);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Curso nuevo = new Curso();
                nuevo.id_cruso = reader["id_curso"].ToString();
                nuevo.turno = int.Parse(reader["turno"].ToString());
                nuevo.nombre = reader["nombre"].ToString();
                nuevo.cedula = reader["cedula"].ToString();
                lista.Add(nuevo);
            }

            cmd.Connection.Open();
            reader.Dispose();
            cmd.Dispose();
            return lista;


        }

    }
}
