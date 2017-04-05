using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void Actualizar_Curso(string id_curso, string cedula, string nombre, Nullable<byte> turno);

        [OperationContract]
        void Actualizar_Equipo(Nullable<int> id, string config, string software, string sistOper, string servidores);

        [OperationContract]
        void Actualizar_Laboratorio(Nullable<int> id, Nullable<byte> cantCompu, Nullable<byte> piso, Nullable<bool> aire, Nullable<bool> videoBeam, Nullable<bool> disponible, Nullable<int> id_equipo);

        [OperationContract]
        void Actualizar_Usuario(string cedula, string nombre, string apellido1, string apellido2, string ocupacion, string contraseña);

        [OperationContract]
        void Buscar_Curso_Cedula_Profesor(string cedula);

        [OperationContract]
        void Buscar_Curso_ID(string id);

        [OperationContract]
        void Buscar_Equipo(Nullable<int> id);

        [OperationContract]
        void Buscar_Laboratorio_ID(Nullable<int> id);

        [OperationContract]
        void Eliminar_Curso(string id_curso);

        [OperationContract]
        void Eliminar_Equipo(Nullable<int> id);
        [OperationContract]
        void Eliminar_Laboratorio(Nullable<int> id);

        [OperationContract]
        void Registrar_Curso(string id_curso, string cedula, string nombre, Nullable<byte> turno);

        [OperationContract]
        void Registrar_Equipo(string config, string software, string sistOper, string servidores);

        [OperationContract]
        void Registrar_Laboratorio(Nullable<int> id_lab, Nullable<byte> cantCompu, Nullable<byte> piso, Nullable<bool> aire, Nullable<bool> videoBeam, Nullable<bool> disponible, Nullable<int> id_equipo);

        [OperationContract]
        void Registrar_Solicitud(Nullable<int> id_lab, string id_curso, Nullable<System.DateTime> fecha, Nullable<System.TimeSpan> hora_ini, Nullable<System.TimeSpan> hora_fin, Nullable<bool> activo);

        [OperationContract]
        void Registrar_Usuario(string cedula, string nombre, string apellido1, string apellido2, string ocupacion, Nullable<int> id_rol, string username, string contraseña);

        [OperationContract]
        void Traer_ID_Labs();

        
    }
}
