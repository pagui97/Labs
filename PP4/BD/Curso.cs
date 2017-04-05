﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    class Curso
    {
        public string id_cruso { get; set; }
        public string cedula { get; set; }
        public string nombre { get; set; }
        public int turno { get; set; }
      

        public static void Registrar_Curso(string id_curso, string cedula, string nombre, int turno)
        {
            Conexion cnx = new Conexion();
            cnx.abrirConexion();
            Curso nuevo = new Curso();
            nuevo.id_cruso = id_curso;
            nuevo.cedula = cedula;
            nuevo.nombre = nombre;
            nuevo.turno = turno;
            SqlCommand cmd = new SqlCommand("Registrar_Curso");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(@"id_curso", nuevo.id_cruso);
            cmd.Parameters.AddWithValue(@"cedula", nuevo.cedula);
            cmd.Parameters.AddWithValue(@"nombre", nuevo.nombre);
            cmd.Parameters.AddWithValue(@"turno", nuevo.turno);
            cmd.ExecuteNonQuery();
            cnx.cerrarConexion();

        }

        public static void Actualizar_Curso(string id_curso, string cedula, string nombre, int turno)
        {
            Conexion cnx = new Conexion();
            cnx.abrirConexion();
            Curso nuevo = new Curso();
            nuevo.id_cruso = id_curso;
            nuevo.cedula = cedula;
            nuevo.nombre = nombre;
            nuevo.turno = turno;
            SqlCommand cmd = new SqlCommand("Actualizar_Curso");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(@"id_curso", nuevo.id_cruso);
            cmd.Parameters.AddWithValue(@"cedula", nuevo.cedula);
            cmd.Parameters.AddWithValue(@"nombre", nuevo.nombre);
            cmd.Parameters.AddWithValue(@"turno", nuevo.turno);
            cmd.ExecuteNonQuery();
            cnx.cerrarConexion();

        }

        public static void Eliminar_Curso(string id_curso)
        {
            Conexion cnx = new Conexion();
            cnx.abrirConexion();
            Curso nuevo = new Curso();
            nuevo.id_cruso = id_curso;
            SqlCommand cmd = new SqlCommand("Eliminar_Curso");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(@"id_curso", nuevo.id_cruso);
            cmd.ExecuteNonQuery();
            cnx.cerrarConexion();
        }

    }
}
