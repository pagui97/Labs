using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    public class Solicitud
    {
        public int id_lab { get; set; }
        public string id_curso { get; set; }
        public DateTime fecha { get; set; }
        public TimeSpan hora_ini { get; set; }
        public TimeSpan hora_fin { get; set; }
        public byte activo { get; set; }
        public static void Registrar_Solicitud(int id_lab, string id_curso, DateTime fecha, TimeSpan hora_ini, TimeSpan hora_fin, byte activo)
        {
            Conexion nueva = new Conexion();
            nueva.objconexion().Open();
            Solicitud nuevo = new Solicitud();
            nuevo.id_lab = id_lab;
            nuevo.id_curso = id_curso;
            nuevo.fecha = fecha;
            nuevo.hora_ini = hora_ini;
            nuevo.hora_fin = hora_fin;
            SqlCommand cmd = new SqlCommand("Registrar_Solicitud");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = nueva.objconexion();
            cmd.Parameters.AddWithValue(@"id_lab", nuevo.id_lab);
            cmd.Parameters.AddWithValue(@"id_curso", nuevo.id_curso);
            cmd.Parameters.AddWithValue(@"fecha", nuevo.fecha);
            cmd.Parameters.AddWithValue(@"hora_ini", nuevo.hora_ini);
            cmd.Parameters.AddWithValue(@"hora_fin", nuevo.hora_fin);
            cmd.Parameters.AddWithValue(@"activo", nuevo.activo);
            cmd.ExecuteNonQuery();
            nueva.objconexion().Close();
        }
    }
}

    
