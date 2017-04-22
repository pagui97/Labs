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
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,UriTemplate = "Actualizar_Equipo?config={config}&software={software}&sistOper={sistOper}&servidores={servidores}&id_lab={id_lab}")]
        void Actualizar_Equipo( string config, string software, string sistOper, string servidores,int id_lab);

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,UriTemplate = "Actualizar_Laboratorio?id={id}&cantCompu={cantCompu}&piso={piso}&aire={aire}&videoBeam={videoBeam}&disponible={disponible}")]
        void Actualizar_Laboratorio(int id, int cantCompu, int piso, byte aire, byte videoBeam, byte disponible);

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "Actualizar_Usuario?cedula={cedula}&nombre={nombre}&apellido1={apellido1}&apellido2={apellido2}&ocupacion={ocupacion}&contraseña={contraseña}")]
        void Actualizar_Usuario(string cedula, string nombre, string apellido1, string apellido2, string ocupacion, string contraseña);

        

        

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,UriTemplate = "Buscar_Equipo?id_lab={id_lab}")]
        Equipo Buscar_Equipo(int id_lab);

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,UriTemplate = "Buscar_Laboratorio_ID?id={id}")]
        Laboratorio Buscar_Laboratorio_ID(int id);
        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "Buscar_Usuario_Cedula?cedula={cedula}")]
        Usuario Buscar_Usuario_Cedula(string cedula);


        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,UriTemplate ="Eliminar_Equipo?id_lab={id_lab}")]
        void Eliminar_Equipo(int id_lab);
        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "Eliminar_Laboratorio?id={id}")]
        void Eliminar_Laboratorio(int id);

       

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "Registrar_Equipo?config={config}&software={software}&sistOper={sistOper}&servidores={servidores}&id_lab={id_lab}")]
        void Registrar_Equipo(string config, string software, string sistOper, string servidores,int id_lab);

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "Registrar_Laboratorio?id_lab={id_lab}&cantCompu={cantCompu}&piso={piso}&aire={aire}&videoBeam={videoBeam}&disponible={disponible}")]
        void Registrar_Laboratorio(int id_lab,int cantCompu, int piso, byte aire, byte videoBeam, byte disponible);

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "Registrar_Solicitud?id_lab={id_lab}&cedula={cedula}&fecha={fecha}&hora_ini={hora_ini}&hora_fin={hora_fin}&activo={activo}")]
        void Registrar_Solicitud(int id_lab, string cedula, DateTime fecha, TimeSpan hora_ini, TimeSpan hora_fin, byte activo);

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "Registrar_Usuario?cedula={cedula}&nombre={nombre}&apellido1={apellido1}&apellido2={apellido2}&ocupacion={ocupacion}&id_rol={id_rol}&username={username}&contraseña={contraseña}")]
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
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedResponse, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,UriTemplate = "Reporte_Solicitud_Laboratorio_General")]
        List<Reportes> Reporte_Solicitud_Laboratorio_General();

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedResponse, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,UriTemplate = "Reporte_Solicitud_Cedula?cedula={cedula}")]
        List<Reportes> Reporte_Solicitud_Cedula(string cedula);

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedResponse, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,UriTemplate = "Reporte_solicitud_Fecha?fecha={fecha}")]
        List<Reportes> Reporte_solicitud_Fecha(DateTime fecha);

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedResponse, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,UriTemplate = "Reporte_Solicitud_ID_Lab?id_lab={id_lab}")]
        List<Reportes> Reporte_Solicitud_ID_Lab(int id_lab);

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedResponse, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "Traer_Info_Solicitud?id_lab={id_lab}")]
        List<Reportes> Traer_Info_Solicitud(int id_lab);

        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.WrappedResponse, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, UriTemplate = "Traer_solicitudes?id_lab={id_lab}")]
        List<Reportes> Traer_solicitudes();

    }
}
