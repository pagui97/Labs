using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    public class Laboratorio
    {
        public int id_lab { get; set; }
        public int cantCompu { get; set; }
        public int piso { get; set; }
        public byte aire { get; set; }
        public byte videoBeam { get; set; }

        public byte disponible { get; set; }
        public int id_equipo { get; set; }


        public static void Registrar_Laboratorio(int id_lab,int cantCompu,int piso , byte aire,byte videoBeam,byte disponible,int id_equipo)
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
        public static void Actualizar_Laboratorio(int id_lab, int cantCompu, int piso, byte aire, byte videoBeam, byte disponible, int id_equipo)
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
            cmd.Parameters.AddWithValue(@"id", nuevo.id_lab);
            cmd.Parameters.AddWithValue(@"cantCompu", nuevo.cantCompu);
            cmd.Parameters.AddWithValue(@"piso", nuevo.piso);
            cmd.Parameters.AddWithValue(@"aire", nuevo.aire);
            cmd.Parameters.AddWithValue(@"videoBeam", nuevo.videoBeam);
            cmd.Parameters.AddWithValue(@"disponible", nuevo.disponible);
            cmd.Parameters.AddWithValue(@"id_equipo", nuevo.id_equipo);
            cmd.ExecuteNonQuery();
            cnx.cerrarConexion();

        }

        public static void Eliminar_Laboratorio(int id_lab)
        {
            Conexion cnx = new Conexion();
            cnx.abrirConexion();
            SqlCommand cmd = new SqlCommand("Eliminar_Laboratorio");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(@"id", id_lab);
            cmd.ExecuteNonQuery();
            cnx.cerrarConexion();
        }
        public static Laboratorio Buscar_Laboratorio(int id)
        {
            Conexion cnx = new Conexion();
            cnx.abrirConexion();
            Laboratorio nuevo = new Laboratorio();
            SqlCommand cmd = new SqlCommand("Buscar_Laboratorio");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(@"id", id);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            nuevo.id_lab = int.Parse(reader["id_lab"].ToString());
            nuevo.cantCompu = int.Parse(reader["cantCompu"].ToString());
            nuevo.piso = int.Parse(reader["piso"].ToString());
            nuevo.aire = Convert.ToByte(reader["aire"].ToString());
            nuevo.videoBeam = Convert.ToByte(reader["videoBeam"].ToString());
            nuevo.disponible = Convert.ToByte(reader["disponible"].ToString());
            nuevo.id_equipo = Convert.ToInt32(reader["id_equipo"].ToString());
            return nuevo;
        }

        public static List<string> Traer_ID_Labs()
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

        public static byte Validar_Labs_Solicitado(int id)
        {
            Conexion cnx = new Conexion();
            cnx.abrirConexion();
            SqlCommand cmd = new SqlCommand("Execute dbo.Validar_Labs_Solicitado");
            cmd.Parameters.AddWithValue(@"id", id);
            byte resultado = (Byte)cmd.ExecuteScalar();
            cnx.cerrarConexion();
            return resultado;
        }
    }
}
