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
    [ServiceBehavior (AddressFilterMode = AddressFilterMode.Any)]
    public class Service1 : IService1
    {
       

        public void Actualizar_Equipo( string config, string software, string sistOper, string servidores,int id_lab)
        {
            try
            {
                Equipo.Actualizar_Equipo(config,software,sistOper,servidores,id_lab);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void Actualizar_Laboratorio(int id, int cantCompu, int piso, byte aire, byte videoBeam, byte disponible)
        {
            try
            {
                Laboratorio.Actualizar_Laboratorio(id,cantCompu,piso,aire,videoBeam,disponible);

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
       
       
        public Equipo Buscar_Equipo(int id_lab)
        {
            try
            {
                return Equipo.Buscar_Equipo(id_lab);
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

        public Usuario Buscar_Usuario_Cedula(string cedula)
        {
            try
            {
                return Usuario.Buscar_Usuario(cedula);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Eliminar_Equipo(int id_lab)
        {
            try
            {
                Equipo.Eliminar_Equipo(id_lab);
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

       

        public void Registrar_Equipo(string config, string software, string sistOper, string servidores,int id_lab)
        {
            try
            {
                Equipo.Registrar_Equipo(config, software, sistOper, servidores,id_lab);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Registrar_Laboratorio(int id_lab, int cantCompu, int piso, byte aire, byte videoBeam, byte disponible)
        {
            try
            {
                Laboratorio.Registrar_Laboratorio(id_lab,cantCompu,piso,aire,videoBeam,disponible);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Registrar_Solicitud(int id_lab, string cedula, DateTime fecha, TimeSpan hora_ini, TimeSpan hora_fin, byte activo)
        {
            try
            {
                Solicitud.Registrar_Solicitud(id_lab, cedula, fecha, hora_ini, hora_fin, activo);
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
        
         public List<Reportes> Reporte_Solicitud_Laboratorio_General()
        {
            try
            {
                return Reportes.Reporte_Solicitud_Laboratorio_General();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Reportes> Reporte_Solicitud_Cedula(string cedula)
        {
            try
            {
                return Reportes.Reporte_Solicitud_Cedula(cedula);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Reportes> Reporte_solicitud_Fecha(DateTime fecha)
        {
            try
            {
                return Reportes.Reporte_solicitud_Fecha(fecha);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Reportes> Reporte_Solicitud_ID_Lab(int id_lab)
        {
            try
            {
                return Reportes.Reporte_Solicitud_ID_Lab(id_lab);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Reportes> Traer_Info_Solicitud(int id_lab)
        {
            try
            {
                return Reportes.Traer_Info_Solicitud(id_lab);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Reportes> Traer_solicitudes()
        {
            try
            {
                return Reportes.Traer_solicitudes();
            }
            catch (Exception)
            {

                throw;
            }
        }







    }
}
