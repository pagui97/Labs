using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BD
{
    public class Reportes
    {
        public string Cedula {get; set ;}
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int ID_lab { get; set; }
        public int cantidad { get; set; }
        public int piso { get; set; }
        public DateTime fecha { get; set; }
        public TimeSpan hora_ini { get; set; }
        public TimeSpan hora_fin { get; set; }
        public string curso_ID { get; set; }
        public int id_solicitud { get; set; }

        public static List<Reportes> Reporte_Solicitud_Laboratorio_General()
        {
            List<Reportes> listadoGeneral = new List<Reportes>();

            Conexion nueva = new Conexion();
            SqlCommand cmd = new SqlCommand("Reporte_Solicitud_Laboratorio_General");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = nueva.objconexion();
            cmd.Connection.Open();
            //cmd.Parameters.AddWithValue(@"id", id);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Reportes ojb = new Reportes();
                ojb.Cedula = reader.GetString(0);
                ojb.Nombre = reader.GetString(1);
                ojb.Apellido = reader.GetString(2);
                ojb.ID_lab = reader.GetInt32(3);
                ojb.cantidad = reader.GetInt32(4);
                ojb.piso = reader.GetInt32(5);
                ojb.fecha = reader.GetDateTime(6);
                ojb.hora_ini = reader.GetTimeSpan(7);
                ojb.hora_fin = reader.GetTimeSpan(8);
                ojb.curso_ID = reader.GetString(9);
                ojb.id_solicitud = reader.GetInt32(10);
                listadoGeneral.Add(ojb);
            }
            cmd.Connection.Close();
            return listadoGeneral;
        }

        public static List<Reportes> Reporte_Solicitud_Cedula(string cedula)
        {
            List<Reportes> listadoGeneral = new List<Reportes>();

            Conexion nueva = new Conexion();
            SqlCommand cmd = new SqlCommand("Reporte_Solicitud_Cedula");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = nueva.objconexion();
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue(@"cedula", cedula);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Reportes ojb = new Reportes();
                ojb.Cedula = reader.GetString(0);
                ojb.Nombre = reader.GetString(1);
                ojb.Apellido = reader.GetString(2);
                ojb.ID_lab = reader.GetInt32(3);
                ojb.cantidad = reader.GetInt32(4);
                ojb.piso = reader.GetInt32(5);
                ojb.fecha = reader.GetDateTime(6);
                ojb.hora_ini = reader.GetTimeSpan(7);
                ojb.hora_fin = reader.GetTimeSpan(8);
                ojb.curso_ID = reader.GetString(9);
                ojb.id_solicitud = reader.GetInt32(10);
                listadoGeneral.Add(ojb);
            }
            cmd.Connection.Close();
            return listadoGeneral;
        }

        public static List<Reportes> Reporte_solicitud_Fecha(DateTime fecha)
        {
            List<Reportes> listadoGeneral = new List<Reportes>();

            Conexion nueva = new Conexion();
            SqlCommand cmd = new SqlCommand("Reporte_solicitud_Fecha");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = nueva.objconexion();
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue(@"fecha", fecha);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Reportes ojb = new Reportes();
                ojb.Cedula = reader.GetString(0);
                ojb.Nombre = reader.GetString(1);
                ojb.Apellido = reader.GetString(2);
                ojb.ID_lab = reader.GetInt32(3);
                ojb.cantidad = reader.GetInt32(4);
                ojb.piso = reader.GetInt32(5);
                ojb.fecha = reader.GetDateTime(6);
                ojb.hora_ini = reader.GetTimeSpan(7);
                ojb.hora_fin = reader.GetTimeSpan(8);
                ojb.curso_ID = reader.GetString(9);
                ojb.id_solicitud = reader.GetInt32(10);
                listadoGeneral.Add(ojb);
            }
            cmd.Connection.Close();
            return listadoGeneral;
        }

        public static List<Reportes> Reporte_Solicitud_ID_Lab(int id_lab)
        {
            List<Reportes> listadoGeneral = new List<Reportes>();

            Conexion nueva = new Conexion();
            SqlCommand cmd = new SqlCommand("Reporte_Solicitud_ID_Lab");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = nueva.objconexion();
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue(@"id_lab", id_lab);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Reportes ojb = new Reportes();
                ojb.Cedula = reader.GetString(0);
                ojb.Nombre = reader.GetString(1);
                ojb.Apellido = reader.GetString(2);
                ojb.ID_lab = reader.GetInt32(3);
                ojb.cantidad = reader.GetInt32(4);
                ojb.piso = reader.GetInt32(5);
                ojb.fecha = reader.GetDateTime(6);
                ojb.hora_ini = reader.GetTimeSpan(7);
                ojb.hora_fin = reader.GetTimeSpan(8);
                ojb.curso_ID = reader.GetString(9);
                ojb.id_solicitud = reader.GetInt32(10);
                listadoGeneral.Add(ojb);
            }
            cmd.Connection.Close();
            return listadoGeneral;
        }
    }
}
