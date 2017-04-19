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


        public static void Registrar_Laboratorio(int id_lab, int cantCompu, int piso, byte aire, byte videoBeam, byte disponible)
        {
            Conexion nueva = new Conexion();
            nueva.objconexion().Open();
            Laboratorio nuevo = new Laboratorio();
            nuevo.id_lab = id_lab;
            nuevo.cantCompu = cantCompu;
            nuevo.piso = piso;
            nuevo.aire = aire;
            nuevo.videoBeam = videoBeam;
            nuevo.disponible = disponible;
            SqlCommand cmd = new SqlCommand("Registrar_Laboratorio");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = nueva.objconexion();
            cmd.Parameters.AddWithValue(@"id_lab", nuevo.id_lab);
            cmd.Parameters.AddWithValue(@"cantCompu", nuevo.cantCompu);
            cmd.Parameters.AddWithValue(@"piso", nuevo.piso);
            cmd.Parameters.AddWithValue(@"aire", nuevo.aire);
            cmd.Parameters.AddWithValue(@"videoBeam", nuevo.videoBeam);
            cmd.Parameters.AddWithValue(@"disponible", nuevo.disponible);
            cmd.ExecuteNonQuery();
            nueva.objconexion().Close();

        }
        public static void Actualizar_Laboratorio(int id_lab, int cantCompu, int piso, byte aire, byte videoBeam, byte disponible)
        {
            Conexion nueva = new Conexion();
            nueva.objconexion().Open();
            Laboratorio nuevo = new Laboratorio();
            nuevo.id_lab = id_lab;
            nuevo.cantCompu = cantCompu;
            nuevo.piso = piso;
            nuevo.aire = aire;
            nuevo.videoBeam = videoBeam;
            nuevo.disponible = disponible;
            SqlCommand cmd = new SqlCommand("Actualizar_Laboratorio");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = nueva.objconexion();
            cmd.Parameters.AddWithValue(@"id", nuevo.id_lab);
            cmd.Parameters.AddWithValue(@"cantCompu", nuevo.cantCompu);
            cmd.Parameters.AddWithValue(@"piso", nuevo.piso);
            cmd.Parameters.AddWithValue(@"aire", nuevo.aire);
            cmd.Parameters.AddWithValue(@"videoBeam", nuevo.videoBeam);
            cmd.Parameters.AddWithValue(@"disponible", nuevo.disponible);
            cmd.ExecuteNonQuery();
            nueva.objconexion().Close();
        }

        public static void Eliminar_Laboratorio(int id_lab)
        {
            Conexion nueva = new Conexion();
            nueva.objconexion().Open();
            SqlCommand cmd = new SqlCommand("Eliminar_Laboratorio");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = nueva.objconexion();
            cmd.Parameters.AddWithValue(@"id", id_lab);
            cmd.ExecuteNonQuery();
            nueva.objconexion().Close();
        }
        public static Laboratorio Buscar_Laboratorio(int id)
        {
            Conexion nueva = new Conexion();
            nueva.objconexion().Open();
            Laboratorio nuevo = new Laboratorio();
            SqlCommand cmd = new SqlCommand("Buscar_Laboratorio");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = nueva.objconexion();
            cmd.Parameters.AddWithValue(@"id", id);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            nuevo.id_lab = int.Parse(reader["id_lab"].ToString());
            nuevo.cantCompu = int.Parse(reader["cantCompu"].ToString());
            nuevo.piso = int.Parse(reader["piso"].ToString());
            nuevo.aire = Convert.ToByte(reader["aire"].ToString());
            nuevo.videoBeam = Convert.ToByte(reader["videoBeam"].ToString());
            nuevo.disponible = Convert.ToByte(reader["disponible"].ToString());
            nueva.objconexion().Close();
            return nuevo;
        }

        public static List<string> Traer_ID_Labs()
        {
            List<string> ids = new List<string>();
            Conexion nueva = new Conexion();
            nueva.objconexion().Open();
            Laboratorio nuevo = new Laboratorio();
            SqlCommand cmd = new SqlCommand("Traer_ID_Labs");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = nueva.objconexion();
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ids.Add(reader["id_lab"].ToString());
            }
            nueva.objconexion().Close();
            return ids;
        }

        public static byte Validar_Labs_Solicitado(int id)
        {
            Conexion nueva = new Conexion();
            nueva.objconexion().Open();
            SqlCommand cmd = new SqlCommand("Execute dbo.Validar_Labs_Solicitado");
            cmd.Connection = nueva.objconexion();
            cmd.Parameters.AddWithValue(@"id", id);
            byte resultado = (Byte)cmd.ExecuteScalar();
            nueva.objconexion().Close();
            return resultado;
        }
    }
}
