using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BD;
namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void Actualizar_Curso(string id_curso, string cedula, string nombre, int turno)
        {
            try
            {
                Curso.Actualizar_Curso(id_curso, cedula, nombre, turno);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void Actualizar_Equipo(int id, string config, string software, string sistOper, string servidores)
        {
            try
            {
                Equipo.Actualizar_Equipo(id,config,software,sistOper,servidores);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void Actualizar_Laboratorio(int id, int cantCompu, int piso, byte aire, byte videoBeam, byte disponible, int id_equipo)
        {
            try
            {
                Laboratorio.Actualizar_Laboratorio(id,cantCompu,piso,aire,videoBeam,disponible,id_equipo);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Actualizar_Usuario(string cedula, string nombre, string apellido1, string apellido2,string ocupacion, string contraseña)
        {
            try
            {
                Usuario.Actualiza_Usuario(cedula,nombre,apellido1,apellido2,ocupacion,contraseña);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Curso> Buscar_Curso_Cedula_Profesor(string cedula)
        {
            try
            {
                List<Curso> lista = new List<Curso>();
                lista = Curso.Buscar_Curso_Cedula_Profesor(cedula);
                return lista ;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Curso Buscar_Curso_ID(string id)
        {
            try
            {
                
                return Curso.Buscar_Curso(id);
             
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Equipo Buscar_Equipo(int id)
        {
            try
            {
                return Equipo.Buscar_Equipo(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Laboratorio Buscar_Laboratorio_ID(int id)
        {
            try
            {
                return Laboratorio.Buscar_Laboratorio(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Eliminar_Curso(string id_curso)
        {
            try
            {
                Curso.Eliminar_Curso(id_curso);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Eliminar_Equipo(int id)
        {
            try
            {
                Equipo.Eliminar_Equipo(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Eliminar_Laboratorio(int id)
        {
            try
            {
                Laboratorio.Eliminar_Laboratorio(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Registrar_Curso(string id_curso, string cedula, string nombre, int turno)
        {
            try
            {
                Curso.Registrar_Curso(id_curso, cedula, nombre, turno);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Registrar_Equipo(int id_equipo,string config, string software, string sistOper, string servidores)
        {
            try
            {
                Equipo.Registrar_Equipo(id_equipo,config, software, sistOper, servidores);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Registrar_Laboratorio(int id_lab, int cantCompu, int piso, byte aire, byte videoBeam, byte disponible, int id_equipo)
        {
            try
            {
                Laboratorio.Registrar_Laboratorio(id_lab,cantCompu,piso,aire,videoBeam,disponible,id_equipo);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Registrar_Solicitud(int id_lab, string id_curso, DateTime fecha, TimeSpan hora_ini, TimeSpan hora_fin, byte activo)
        {
            try
            {
                Solicitud.Registrar_Solicitud(id_lab, id_curso, fecha, hora_ini, hora_fin, activo);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Registrar_Usuario(string cedula, string nombre, string apellido1, string apellido2, string ocupacion, int id_rol, string username, string contraseña)
        {
            try
            {
                Usuario.Registrar_Usuario(cedula, nombre, apellido1, apellido2, ocupacion, id_rol, username, contraseña);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<string> Traer_ID_Labs()
        {
            try
            {
                List<string> lista = new List<string>();
                lista = Laboratorio.Traer_ID_Labs();
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public byte Validar_Cedula(int cedula)
        {
            try
            {
                return Usuario.Validar_Cedula(cedula);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public byte Validar_Labs_Solicitado(int id)
        {
            try
            {
                return Laboratorio.Validar_Labs_Solicitado(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public byte Validar_Nick(string username)
        {
            try
            {
                return Usuario.Validar_Nick(username);
            }
            catch (Exception)
            {

                throw;
            }
        }







    }
}
