﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Linq;

public partial class labsEntities : DbContext
{
    public labsEntities()
        : base("name=labsEntities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public virtual DbSet<curso> curso { get; set; }
    public virtual DbSet<equipo> equipo { get; set; }
    public virtual DbSet<laboratorio> laboratorio { get; set; }
    public virtual DbSet<rol> rol { get; set; }
    public virtual DbSet<solicitud> solicitud { get; set; }
    public virtual DbSet<usuario> usuario { get; set; }

    public virtual int Actualizar_Curso(string id_curso, string cedula, string nombre, Nullable<byte> turno)
    {
        var id_cursoParameter = id_curso != null ?
            new ObjectParameter("id_curso", id_curso) :
            new ObjectParameter("id_curso", typeof(string));

        var cedulaParameter = cedula != null ?
            new ObjectParameter("cedula", cedula) :
            new ObjectParameter("cedula", typeof(string));

        var nombreParameter = nombre != null ?
            new ObjectParameter("nombre", nombre) :
            new ObjectParameter("nombre", typeof(string));

        var turnoParameter = turno.HasValue ?
            new ObjectParameter("turno", turno) :
            new ObjectParameter("turno", typeof(byte));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Actualizar_Curso", id_cursoParameter, cedulaParameter, nombreParameter, turnoParameter);
    }

    public virtual int Actualizar_Equipo(Nullable<int> id, string config, string software, string sistOper, string servidores)
    {
        var idParameter = id.HasValue ?
            new ObjectParameter("id", id) :
            new ObjectParameter("id", typeof(int));

        var configParameter = config != null ?
            new ObjectParameter("config", config) :
            new ObjectParameter("config", typeof(string));

        var softwareParameter = software != null ?
            new ObjectParameter("software", software) :
            new ObjectParameter("software", typeof(string));

        var sistOperParameter = sistOper != null ?
            new ObjectParameter("sistOper", sistOper) :
            new ObjectParameter("sistOper", typeof(string));

        var servidoresParameter = servidores != null ?
            new ObjectParameter("servidores", servidores) :
            new ObjectParameter("servidores", typeof(string));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Actualizar_Equipo", idParameter, configParameter, softwareParameter, sistOperParameter, servidoresParameter);
    }

    public virtual int Actualizar_Laboratorio(Nullable<int> id, Nullable<byte> cantCompu, Nullable<byte> piso, Nullable<bool> aire, Nullable<bool> videoBeam, Nullable<bool> disponible, Nullable<int> id_equipo)
    {
        var idParameter = id.HasValue ?
            new ObjectParameter("id", id) :
            new ObjectParameter("id", typeof(int));

        var cantCompuParameter = cantCompu.HasValue ?
            new ObjectParameter("cantCompu", cantCompu) :
            new ObjectParameter("cantCompu", typeof(byte));

        var pisoParameter = piso.HasValue ?
            new ObjectParameter("piso", piso) :
            new ObjectParameter("piso", typeof(byte));

        var aireParameter = aire.HasValue ?
            new ObjectParameter("aire", aire) :
            new ObjectParameter("aire", typeof(bool));

        var videoBeamParameter = videoBeam.HasValue ?
            new ObjectParameter("videoBeam", videoBeam) :
            new ObjectParameter("videoBeam", typeof(bool));

        var disponibleParameter = disponible.HasValue ?
            new ObjectParameter("disponible", disponible) :
            new ObjectParameter("disponible", typeof(bool));

        var id_equipoParameter = id_equipo.HasValue ?
            new ObjectParameter("id_equipo", id_equipo) :
            new ObjectParameter("id_equipo", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Actualizar_Laboratorio", idParameter, cantCompuParameter, pisoParameter, aireParameter, videoBeamParameter, disponibleParameter, id_equipoParameter);
    }

    public virtual int Actualizar_Usuario(string cedula, string nombre, string apellido1, string apellido2, string ocupacion, string contraseña)
    {
        var cedulaParameter = cedula != null ?
            new ObjectParameter("cedula", cedula) :
            new ObjectParameter("cedula", typeof(string));

        var nombreParameter = nombre != null ?
            new ObjectParameter("nombre", nombre) :
            new ObjectParameter("nombre", typeof(string));

        var apellido1Parameter = apellido1 != null ?
            new ObjectParameter("apellido1", apellido1) :
            new ObjectParameter("apellido1", typeof(string));

        var apellido2Parameter = apellido2 != null ?
            new ObjectParameter("apellido2", apellido2) :
            new ObjectParameter("apellido2", typeof(string));

        var ocupacionParameter = ocupacion != null ?
            new ObjectParameter("ocupacion", ocupacion) :
            new ObjectParameter("ocupacion", typeof(string));

        var contraseñaParameter = contraseña != null ?
            new ObjectParameter("contraseña", contraseña) :
            new ObjectParameter("contraseña", typeof(string));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Actualizar_Usuario", cedulaParameter, nombreParameter, apellido1Parameter, apellido2Parameter, ocupacionParameter, contraseñaParameter);
    }

    public virtual ObjectResult<Buscar_Curso_Cedula_Profesor_Result> Buscar_Curso_Cedula_Profesor(string cedula)
    {
        var cedulaParameter = cedula != null ?
            new ObjectParameter("cedula", cedula) :
            new ObjectParameter("cedula", typeof(string));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Buscar_Curso_Cedula_Profesor_Result>("Buscar_Curso_Cedula_Profesor", cedulaParameter);
    }

    public virtual ObjectResult<Buscar_Curso_ID_Result> Buscar_Curso_ID(string id)
    {
        var idParameter = id != null ?
            new ObjectParameter("id", id) :
            new ObjectParameter("id", typeof(string));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Buscar_Curso_ID_Result>("Buscar_Curso_ID", idParameter);
    }

    public virtual ObjectResult<Buscar_Equipo_Result> Buscar_Equipo(Nullable<int> id)
    {
        var idParameter = id.HasValue ?
            new ObjectParameter("id", id) :
            new ObjectParameter("id", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Buscar_Equipo_Result>("Buscar_Equipo", idParameter);
    }

    public virtual ObjectResult<Buscar_Laboratorio_ID_Result> Buscar_Laboratorio_ID(Nullable<int> id)
    {
        var idParameter = id.HasValue ?
            new ObjectParameter("id", id) :
            new ObjectParameter("id", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Buscar_Laboratorio_ID_Result>("Buscar_Laboratorio_ID", idParameter);
    }

    public virtual int Eliminar_Curso(string id_curso)
    {
        var id_cursoParameter = id_curso != null ?
            new ObjectParameter("id_curso", id_curso) :
            new ObjectParameter("id_curso", typeof(string));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Eliminar_Curso", id_cursoParameter);
    }

    public virtual int Eliminar_Equipo(Nullable<int> id)
    {
        var idParameter = id.HasValue ?
            new ObjectParameter("id", id) :
            new ObjectParameter("id", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Eliminar_Equipo", idParameter);
    }

    public virtual int Eliminar_Laboratorio(Nullable<int> id)
    {
        var idParameter = id.HasValue ?
            new ObjectParameter("id", id) :
            new ObjectParameter("id", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Eliminar_Laboratorio", idParameter);
    }

    public virtual int Registrar_Curso(string id_curso, string cedula, string nombre, Nullable<byte> turno)
    {
        var id_cursoParameter = id_curso != null ?
            new ObjectParameter("id_curso", id_curso) :
            new ObjectParameter("id_curso", typeof(string));

        var cedulaParameter = cedula != null ?
            new ObjectParameter("cedula", cedula) :
            new ObjectParameter("cedula", typeof(string));

        var nombreParameter = nombre != null ?
            new ObjectParameter("nombre", nombre) :
            new ObjectParameter("nombre", typeof(string));

        var turnoParameter = turno.HasValue ?
            new ObjectParameter("turno", turno) :
            new ObjectParameter("turno", typeof(byte));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Registrar_Curso", id_cursoParameter, cedulaParameter, nombreParameter, turnoParameter);
    }

    public virtual int Registrar_Equipo(string config, string software, string sistOper, string servidores)
    {
        var configParameter = config != null ?
            new ObjectParameter("config", config) :
            new ObjectParameter("config", typeof(string));

        var softwareParameter = software != null ?
            new ObjectParameter("software", software) :
            new ObjectParameter("software", typeof(string));

        var sistOperParameter = sistOper != null ?
            new ObjectParameter("sistOper", sistOper) :
            new ObjectParameter("sistOper", typeof(string));

        var servidoresParameter = servidores != null ?
            new ObjectParameter("servidores", servidores) :
            new ObjectParameter("servidores", typeof(string));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Registrar_Equipo", configParameter, softwareParameter, sistOperParameter, servidoresParameter);
    }

    public virtual int Registrar_Laboratorio(Nullable<int> id_lab, Nullable<byte> cantCompu, Nullable<byte> piso, Nullable<bool> aire, Nullable<bool> videoBeam, Nullable<bool> disponible, Nullable<int> id_equipo)
    {
        var id_labParameter = id_lab.HasValue ?
            new ObjectParameter("id_lab", id_lab) :
            new ObjectParameter("id_lab", typeof(int));

        var cantCompuParameter = cantCompu.HasValue ?
            new ObjectParameter("cantCompu", cantCompu) :
            new ObjectParameter("cantCompu", typeof(byte));

        var pisoParameter = piso.HasValue ?
            new ObjectParameter("piso", piso) :
            new ObjectParameter("piso", typeof(byte));

        var aireParameter = aire.HasValue ?
            new ObjectParameter("aire", aire) :
            new ObjectParameter("aire", typeof(bool));

        var videoBeamParameter = videoBeam.HasValue ?
            new ObjectParameter("videoBeam", videoBeam) :
            new ObjectParameter("videoBeam", typeof(bool));

        var disponibleParameter = disponible.HasValue ?
            new ObjectParameter("disponible", disponible) :
            new ObjectParameter("disponible", typeof(bool));

        var id_equipoParameter = id_equipo.HasValue ?
            new ObjectParameter("id_equipo", id_equipo) :
            new ObjectParameter("id_equipo", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Registrar_Laboratorio", id_labParameter, cantCompuParameter, pisoParameter, aireParameter, videoBeamParameter, disponibleParameter, id_equipoParameter);
    }

    public virtual int Registrar_Solicitud(Nullable<int> id_lab, string id_curso, Nullable<System.DateTime> fecha, Nullable<System.TimeSpan> hora_ini, Nullable<System.TimeSpan> hora_fin, Nullable<bool> activo)
    {
        var id_labParameter = id_lab.HasValue ?
            new ObjectParameter("id_lab", id_lab) :
            new ObjectParameter("id_lab", typeof(int));

        var id_cursoParameter = id_curso != null ?
            new ObjectParameter("id_curso", id_curso) :
            new ObjectParameter("id_curso", typeof(string));

        var fechaParameter = fecha.HasValue ?
            new ObjectParameter("fecha", fecha) :
            new ObjectParameter("fecha", typeof(System.DateTime));

        var hora_iniParameter = hora_ini.HasValue ?
            new ObjectParameter("hora_ini", hora_ini) :
            new ObjectParameter("hora_ini", typeof(System.TimeSpan));

        var hora_finParameter = hora_fin.HasValue ?
            new ObjectParameter("hora_fin", hora_fin) :
            new ObjectParameter("hora_fin", typeof(System.TimeSpan));

        var activoParameter = activo.HasValue ?
            new ObjectParameter("activo", activo) :
            new ObjectParameter("activo", typeof(bool));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Registrar_Solicitud", id_labParameter, id_cursoParameter, fechaParameter, hora_iniParameter, hora_finParameter, activoParameter);
    }

    public virtual int Registrar_Usuario(string cedula, string nombre, string apellido1, string apellido2, string ocupacion, Nullable<int> id_rol, string username, string contraseña)
    {
        var cedulaParameter = cedula != null ?
            new ObjectParameter("cedula", cedula) :
            new ObjectParameter("cedula", typeof(string));

        var nombreParameter = nombre != null ?
            new ObjectParameter("nombre", nombre) :
            new ObjectParameter("nombre", typeof(string));

        var apellido1Parameter = apellido1 != null ?
            new ObjectParameter("apellido1", apellido1) :
            new ObjectParameter("apellido1", typeof(string));

        var apellido2Parameter = apellido2 != null ?
            new ObjectParameter("apellido2", apellido2) :
            new ObjectParameter("apellido2", typeof(string));

        var ocupacionParameter = ocupacion != null ?
            new ObjectParameter("ocupacion", ocupacion) :
            new ObjectParameter("ocupacion", typeof(string));

        var id_rolParameter = id_rol.HasValue ?
            new ObjectParameter("id_rol", id_rol) :
            new ObjectParameter("id_rol", typeof(int));

        var usernameParameter = username != null ?
            new ObjectParameter("username", username) :
            new ObjectParameter("username", typeof(string));

        var contraseñaParameter = contraseña != null ?
            new ObjectParameter("contraseña", contraseña) :
            new ObjectParameter("contraseña", typeof(string));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Registrar_Usuario", cedulaParameter, nombreParameter, apellido1Parameter, apellido2Parameter, ocupacionParameter, id_rolParameter, usernameParameter, contraseñaParameter);
    }

    public virtual ObjectResult<Nullable<int>> Traer_ID_Labs()
    {
        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("Traer_ID_Labs");
    }
}
