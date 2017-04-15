using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BD;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,UriTemplate = "Actualizar_Curso")]
        void Actualizar_Curso(string id_curso, string cedula, string nombre, int turno);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,UriTemplate = "Actualizar_Equipo")]
        void Actualizar_Equipo(int id, string config, string software, string sistOper, string servidores,int id_lab);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,UriTemplate = "Actualizar_Laboratorio")]
        void Actualizar_Laboratorio(int id, int cantCompu, int piso, byte aire, byte videoBeam, byte disponible);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "Actualizar_Usuario")]
        void Actualizar_Usuario(string cedula, string nombre, string apellido1, string apellido2, string ocupacion, string contraseña);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,UriTemplate = "Buscar_Curso_Cedula_Profeso")]
        List<Curso> Buscar_Curso_Cedula_Profesor(string cedula);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,UriTemplate = "Buscar_Curso_ID")]
        Curso Buscar_Curso_ID(string id);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,UriTemplate = "Buscar_Equipo")]
        Equipo Buscar_Equipo(int id);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,UriTemplate ="Buscar_Laboratorio")]
        Laboratorio Buscar_Laboratorio_ID(int id);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,UriTemplate ="Eliminar_Curso")]
        void Eliminar_Curso(string id_curso);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,UriTemplate ="Eliminar_Equipo")]
        void Eliminar_Equipo(int id);
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "Eliminar_Laboratorio")]
        void Eliminar_Laboratorio(int id);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "Registrar_Curso")]
        void Registrar_Curso(string id_curso, string cedula, string nombre, int turno);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "Registrar_Equipo")]
        void Registrar_Equipo(int id_equipo,string config, string software, string sistOper, string servidore,int id_lab);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "Registrar_Laboratorio")]
        void Registrar_Laboratorio(int id_lab,int cantCompu, int piso, byte aire, byte videoBeam, byte disponible);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "Registrar_Solicitud")]
        void Registrar_Solicitud(int id_lab, string id_curso, DateTime fecha, TimeSpan hora_ini, TimeSpan hora_fin, byte activo);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "Registrar_Usuario")]
        void Registrar_Usuario(string cedula, string nombre, string apellido1, string apellido2, string ocupacion, int id_rol, string username, string contraseña);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedResponse, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,UriTemplate = "Traer_ID_Labs")]
         List<string>Traer_ID_Labs();

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedResponse, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,UriTemplate ="Validar_Cedula")]
        byte Validar_Cedula(int id);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedResponse, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,UriTemplate = "Validar_Labs_Solicitado")]
        byte Validar_Labs_Solicitado(int id);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedResponse, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,UriTemplate = "Validar_Nick")]
        byte Validar_Nick(string username);
        
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedResponse, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,UriTemplate = "Reporte_Solicitud_Laboratorio_General")]
        List<Reportes> Reporte_Solicitud_Laboratorio_General();

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedResponse, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,UriTemplate = "Reporte_Solicitud_Cedula")]
        List<Reportes> Reporte_Solicitud_Cedula(string cedula);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedResponse, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,UriTemplate = "Reporte_solicitud_Fecha")]
        List<Reportes> Reporte_solicitud_Fecha(DateTime fecha);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedResponse, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,UriTemplate = "Reporte_Solicitud_ID_Lab")]
        List<Reportes> Reporte_Solicitud_ID_Lab(int id_lab);
        
    }
}
