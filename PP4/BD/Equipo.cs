    using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    public class Equipo
    {
        public int id_equipo { get; set; }
        public string config { get; set; }
        public string software { get; set; }
        public string sistOper { get; set; }
        public string servidores { get; set; }
        public int id_lab { get; set; }
        public static void Registrar_Equipo(string config, string software, string sistOper, string servidores, int id_lab)
        {
            Conexion nueva = new Conexion();
            nueva.objconexion().Open();
            Equipo nuevo = new Equipo();
            nuevo.config = config;
            nuevo.software = software;
            nuevo.sistOper = sistOper;
            nuevo.servidores = servidores;
            nuevo.id_lab = id_lab;
            SqlCommand cmd = new SqlCommand("Registrar_Equipo");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = nueva.objconexion();
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue(@"config", nuevo.config);
            cmd.Parameters.AddWithValue(@"software", nuevo.software);
            cmd.Parameters.AddWithValue(@"sistOper", nuevo.sistOper);
            cmd.Parameters.AddWithValue(@"servidores", nuevo.servidores);
            cmd.Parameters.AddWithValue(@"id_lab", nuevo.id_lab);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public static void Actualizar_Equipo(int id_equipo, string config, string software, string sistOper, string servidores, int id_lab)
        {
            Conexion nueva = new Conexion();
            nueva.objconexion().Open();
            Equipo nuevo = new Equipo();
            nuevo.id_equipo = id_equipo;
            nuevo.config = config;
            nuevo.software = software;
            nuevo.sistOper = sistOper;
            nuevo.servidores = servidores;
            nuevo.id_lab = id_lab;
            SqlCommand cmd = new SqlCommand("Actualizar_Equipo");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = nueva.objconexion();
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue(@"id_equipo", nuevo.id_equipo);
            cmd.Parameters.AddWithValue(@"config", nuevo.config);
            cmd.Parameters.AddWithValue(@"software", nuevo.software);
            cmd.Parameters.AddWithValue(@"sistOper", nuevo.sistOper);
            cmd.Parameters.AddWithValue(@"servidores", nuevo.servidores);
            cmd.Parameters.AddWithValue(@"id_lab", nuevo.id_lab);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }
        public static void Eliminar_Equipo(int id_equipo)
        {
            Conexion nueva = new Conexion();
            nueva.objconexion().Open();
            Equipo nuevo = new Equipo();
            nuevo.id_equipo = id_equipo;
            SqlCommand cmd = new SqlCommand("Eliminar_Equipo");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection.Open();
            cmd.Connection = nueva.objconexion();
            cmd.Parameters.AddWithValue(@"id", nuevo.id_equipo);
            cmd.ExecuteNonQuery();
            cmd.Connection.Open();

        }

        public static Equipo Buscar_Equipo(int id_equipo)
        {
            Conexion nueva = new Conexion();
            nueva.objconexion().Open();
            SqlCommand cmd = new SqlCommand("Buscar_Equipo");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = nueva.objconexion();
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue(@"id", id_equipo);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            Equipo nuevo = new Equipo();
            nuevo.id_equipo = id_equipo;
            while (reader.Read())
            {
                nuevo.config = reader["config"].ToString();
                nuevo.servidores = reader["servidores"].ToString();
                nuevo.software = reader["software"].ToString();
                nuevo.sistOper = reader["sistOper"].ToString();
                nuevo.id_lab = int.Parse(reader["id_lab"].ToString());
            }
            
            cmd.Connection.Close();
            cmd.Dispose();
            reader.Dispose();
            return nuevo;
        }
    }

    
}
