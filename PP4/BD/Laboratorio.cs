using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    class Laboratorio
    {
        public int id_lab { get; set; }
        public int cantCompu { get; set; }
        public int piso { get; set; }
        public Boolean aire { get; set; }
        public Boolean videoBeam { get; set; }

        public Boolean disponible { get; set; }
        public int id_equipo { get; set; }


        public static void Registrar_Laboratorio(int id_lab,int cantCompu,int piso , Boolean aire,Boolean videoBeam,Boolean disponible,int id_equipo)
        {
            Conexion cnx = new Conexion();
            cnx.abrirConexion();
            Laboratorio nuevo = new Laboratorio();
            nuevo.id_lab = id_lab;
            nuevo.cantCompu = cantCompu;
            nuevo.piso = piso;
            nuevo.aire = aire;
            nuevo.videoBeam = videoBeam;
            nuevo.disponible = disponible;
            nuevo.id_equipo = id_equipo;
            SqlCommand cmd = new SqlCommand("Registrar_Laboratorio");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(@"id_lab", nuevo.id_lab);
            cmd.Parameters.AddWithValue(@"cantCompu", nuevo.cantCompu);
            cmd.Parameters.AddWithValue(@"piso", nuevo.piso);
            cmd.Parameters.AddWithValue(@"aire", nuevo.aire);
            cmd.Parameters.AddWithValue(@"videoBeam", nuevo.videoBeam);
            cmd.Parameters.AddWithValue(@"disponible", nuevo.disponible);
            cmd.Parameters.AddWithValue(@"id_equipo", nuevo.id_equipo);
            cmd.ExecuteNonQuery();
            cnx.cerrarConexion();

        }
        public static void Actualizar_Laboratorio(int id_lab, int cantCompu, int piso, Boolean aire, Boolean videoBeam, Boolean disponible, int id_equipo)
        {
            Conexion cnx = new Conexion();
            cnx.abrirConexion();
            Laboratorio nuevo = new Laboratorio();
            nuevo.id_lab = id_lab;
            nuevo.cantCompu = cantCompu;
            nuevo.piso = piso;
            nuevo.aire = aire;
            nuevo.videoBeam = videoBeam;
            nuevo.disponible = disponible;
            nuevo.id_equipo = id_equipo;
            SqlCommand cmd = new SqlCommand("Actualizar_Laboratorio");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(@"id_lab", nuevo.id_lab);
            cmd.Parameters.AddWithValue(@"cantCompu", nuevo.cantCompu);
            cmd.Parameters.AddWithValue(@"piso", nuevo.piso);
            cmd.Parameters.AddWithValue(@"aire", nuevo.aire);
            cmd.Parameters.AddWithValue(@"videoBeam", nuevo.videoBeam);
            cmd.Parameters.AddWithValue(@"disponible", nuevo.disponible);
            cmd.Parameters.AddWithValue(@"id_equipo", nuevo.id_equipo);
            cmd.ExecuteNonQuery();
            cnx.cerrarConexion();

        }
        public void Buscar_Laboratorio(int id)
        {
            Conexion cnx = new Conexion();
            cnx.abrirConexion();
            Laboratorio nuevo = new Laboratorio();
            SqlCommand cmd = new SqlCommand("Buscar_Laboratorio");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(@"id_lab", id);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            nuevo.id_lab = int.Parse(reader["id_lab"].ToString());
            nuevo.cantCompu = int.Parse(reader["cantCompu"].ToString());
            nuevo.piso = int.Parse(reader["piso"].ToString());
            nuevo.aire = Convert.ToBoolean(reader["aire"].ToString());
            nuevo.videoBeam = Convert.ToBoolean(reader["videoBeam"].ToString());
            nuevo.disponible = Convert.ToBoolean(reader["disponible"].ToString());
            nuevo.id_equipo = Convert.ToInt32(reader["id_equipo"].ToString());
        }

        public List<string> Traer_ID_Labs()
        {
            List<string> ids = new List<string>();
            Conexion cnx = new Conexion();
            cnx.abrirConexion();
            Laboratorio nuevo = new Laboratorio();
            SqlCommand cmd = new SqlCommand("Traer_ID_Labs");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ids.Add(reader["id_lab"].ToString());
            }
            return ids;
        }
    }
}
