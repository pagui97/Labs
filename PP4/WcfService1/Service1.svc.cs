using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using CapaBD;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void Actualizar_Curso(string id_curso, string cedula, string nombre, Nullable<byte> turno)
        {
            try
            {
                labsEntities Entidad = new labsEntities();
                Entidad.Actualizar_Curso(id_curso, cedula, nombre, turno);
                Entidad.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void Actualizar_Equipo(Nullable<int> id, string config, string software, string sistOper, string servidores)
        {
            try
            {
                labsEntities Entidad = new labsEntities();
                Entidad.Actualizar_Equipo(id, config, software, sistOper, servidores);
                Entidad.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void Actualizar_Laboratorio(Nullable<int> id, Nullable<byte> cantCompu, Nullable<byte> piso, Nullable<bool> aire, Nullable<bool> videoBeam, Nullable<bool> disponible, Nullable<int> id_equipo)
        {
            try
            {
                labsEntities Entidad = new labsEntities();
                Entidad.Actualizar_Laboratorio(id, cantCompu, piso, aire, videoBeam, disponible, id_equipo);
                Entidad.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Actualizar_Usuario(string cedula, string nombre, string apellido1, string apellido2, string ocupacion, string contraseña)
        {
            try
            {
                labsEntities Entidad = new labsEntities();
                Entidad.Actualizar_Usuario(cedula,nombre,apellido1,apellido2,ocupacion,contraseña);
                Entidad.SaveChanges();
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
                labsEntities Entidad = new labsEntities();
                Entidad.Eliminar_Curso(id_curso);
                Entidad.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Eliminar_Equipo(Nullable<int> id)
        {
            try
            {
                labsEntities Entidad = new labsEntities();
                Entidad.Eliminar_Equipo(id);
                Entidad.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Eliminar_Laboratorio(Nullable<int> id)
        {
            try
            {
                labsEntities Entidad = new labsEntities();
                Entidad.Eliminar_Laboratorio(id);
                Entidad.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Registrar_Curso(string id_curso, string cedula, string nombre, Nullable<byte> turno)
        {
            try
            {
                labsEntities Entidad = new labsEntities();
                Entidad.Registrar_Curso(id_curso,cedula,nombre,turno);
                Entidad.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Registrar_Equipo(string config, string software, string sistOper, string servidores)
        {
            try
            {
                labsEntities Entidad = new labsEntities();
                Entidad.Registrar_Equipo(config,software,sistOper,servidores);
                Entidad.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Registrar_Laboratorio(Nullable<int> id_lab, Nullable<byte> cantCompu, Nullable<byte> piso, Nullable<bool> aire, Nullable<bool> videoBeam, Nullable<bool> disponible, Nullable<int> id_equipo)
        {
            try
            {
                labsEntities Entidad = new labsEntities();
                Entidad.Registrar_Laboratorio(id_lab, cantCompu, piso, aire, videoBeam, disponible, id_equipo);
                Entidad.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Registrar_Solicitud(Nullable<int> id_lab, string id_curso, Nullable<System.DateTime> fecha, Nullable<System.TimeSpan> hora_ini, Nullable<System.TimeSpan> hora_fin, Nullable<bool> activo)
        {
            try
            {
                labsEntities Entidad = new labsEntities();
                Entidad.Registrar_Solicitud(id_lab,id_curso,fecha,hora_ini,hora_fin, activo);
                Entidad.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Registrar_Usuario(string cedula, string nombre, string apellido1, string apellido2, string ocupacion, Nullable<int> id_rol, string username, string contraseña)
        {
            try
            {
                labsEntities Entidad = new labsEntities();
                Entidad.Registrar_Usuario(cedula,nombre,apellido1,apellido2,ocupacion,id_rol,username,contraseña);
                Entidad.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }




    }
}
