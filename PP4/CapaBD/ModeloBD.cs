﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class curso
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public curso()
    {
        this.solicitud = new HashSet<solicitud>();
    }

    public string id_curso { get; set; }
    public string cedula { get; set; }
    public string nombre { get; set; }
    public Nullable<byte> turno { get; set; }

    public virtual usuario usuario { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<solicitud> solicitud { get; set; }
}

public partial class equipo
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public equipo()
    {
        this.laboratorio = new HashSet<laboratorio>();
    }

    public int id_equipo { get; set; }
    public string config { get; set; }
    public string software { get; set; }
    public string sistOper { get; set; }
    public string servidores { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<laboratorio> laboratorio { get; set; }
}

public partial class laboratorio
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public laboratorio()
    {
        this.solicitud = new HashSet<solicitud>();
    }

    public int id_lab { get; set; }
    public Nullable<byte> cantCompu { get; set; }
    public Nullable<byte> piso { get; set; }
    public Nullable<bool> aire { get; set; }
    public Nullable<bool> videoBeam { get; set; }
    public Nullable<bool> disponible { get; set; }
    public Nullable<int> id_equipo { get; set; }

    public virtual equipo equipo { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<solicitud> solicitud { get; set; }
}

public partial class rol
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public rol()
    {
        this.usuario = new HashSet<usuario>();
    }

    public int id_rol { get; set; }
    public string descripcion { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<usuario> usuario { get; set; }
}

public partial class solicitud
{
    public int id_solic { get; set; }
    public Nullable<int> id_lab { get; set; }
    public string id_curso { get; set; }
    public Nullable<System.DateTime> fecha { get; set; }
    public Nullable<System.TimeSpan> hora_ini { get; set; }
    public Nullable<System.TimeSpan> hora_fin { get; set; }
    public Nullable<bool> activo { get; set; }

    public virtual curso curso { get; set; }
    public virtual laboratorio laboratorio { get; set; }
}

public partial class usuario
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public usuario()
    {
        this.curso = new HashSet<curso>();
    }

    public string cedula { get; set; }
    public string nombre { get; set; }
    public string apellido1 { get; set; }
    public string apellido2 { get; set; }
    public string ocupacion { get; set; }
    public Nullable<int> id_rol { get; set; }
    public string userName { get; set; }
    public string contraseña { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<curso> curso { get; set; }
    public virtual rol rol { get; set; }
}

public partial class Buscar_Curso_Cedula_Profesor_Result
{
    public string nombre { get; set; }
    public string apellido1 { get; set; }
    public string apellido2 { get; set; }
    public string cedula { get; set; }
    public string nombre1 { get; set; }
    public Nullable<byte> turno { get; set; }
}

public partial class Buscar_Curso_ID_Result
{
    public string nombre { get; set; }
    public string apellido1 { get; set; }
    public string apellido2 { get; set; }
    public string cedula { get; set; }
    public string nombre1 { get; set; }
    public Nullable<byte> turno { get; set; }
}

public partial class Buscar_Equipo_Result
{
    public string config { get; set; }
    public string software { get; set; }
    public string sistOper { get; set; }
    public string servidores { get; set; }
}

public partial class Buscar_Laboratorio_ID_Result
{
    public Nullable<byte> cantCompu { get; set; }
    public Nullable<byte> piso { get; set; }
    public Nullable<bool> aire { get; set; }
    public Nullable<bool> videoBeam { get; set; }
    public Nullable<bool> disponible { get; set; }
    public Nullable<int> id_equipo { get; set; }
}
