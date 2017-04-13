create procedure Registrar_Usuario
@cedula varchar(20),
@nombre varchar(50),
@apellido1 varchar(50),
@apellido2 varchar(50),
@ocupacion varchar(50),
@id_rol integer,
@username varchar(20),
@contrase�a varchar(20)
as
insert into usuario(cedula, nombre, apellido1, apellido2, ocupacion, id_rol, userName, contrase�a)
values(@cedula, @nombre, @apellido1, @apellido2, @ocupacion, @id_rol, @username, @contrase�a);


--Valida si ya existe el nombre de usuario registrado, devuelve true o false
create function Validar_Nick
(@username varchar(20))
returns bit
as
begin
declare @existe bit = 0;
declare @no varchar(50);
select @no = userName from usuario where userName = @username;
if @no != ' '
begin
set @existe = 1;
end
return @existe
end

----- Para validar si el usuario realmente existe en el sistema
create function Validar_Cedula
(@id int)
returns bit
as
begin
declare @existe bit = 0;
declare @cedula varchar(50);
select @cedula = cedula from usuario where cedula = @id;
if @cedula != ' '
begin
set @existe = 1;
end
return @existe
end

create procedure Actualizar_Usuario
@cedula varchar(20),
@nombre varchar(50),
@apellido1 varchar(50),
@apellido2 varchar(50),
@ocupacion varchar(50),
@contrase�a varchar(20)
as
update usuario set nombre = @nombre, apellido1 = @apellido1, apellido2 = @apellido2, ocupacion = @ocupacion, contrase�a = @contrase�a
where cedula = @cedula;


create procedure Registrar_Equipo
@config VARCHAR(100),
@software VARCHAR(200),
@sistOper VARCHAR(100),
@servidores VARCHAR(100)
as
insert into equipo (config, software, sistOper, servidores)values(@config,@software, @sistOper, @servidores);

create procedure Actualizar_Equipo
@id integer,
@config VARCHAR(100),
@software VARCHAR(200),
@sistOper VARCHAR(100),
@servidores VARCHAR(100)
as
update equipo set config = @config, software = @software, sistOper = @sistOper, servidores = @servidores
where id_equipo = @id;

create procedure Buscar_Equipo
@id integer
as
select e.config,e.software,e.sistOper,e.servidores from equipo e where e.id_equipo = @id;

create procedure Eliminar_Equipo
@id integer
as
delete from equipo where id_equipo = @id

create procedure Registrar_Laboratorio
@id_lab integer,
@cantCompu TINYINT,
@piso TINYINT,
@aire BIT,
@videoBeam BIT,
@disponible BIT,
@id_equipo INTEGER
as
insert into Laboratorio (id_lab, cantCompu,piso,aire,videoBeam,disponible,id_equipo)
values(@id_lab,@cantCompu,@piso,@aire,@videoBeam,@disponible,@id_equipo);

create procedure Eliminar_Laboratorio
@id integer
as
delete from Laboratorio where id_lab = @id;

create procedure Buscar_Laboratorio_ID
@id integer
as
select  cantCompu,piso,aire,videoBeam,disponible,id_equipo from Laboratorio 
where id_lab = @id;

create procedure Actualizar_Laboratorio
@id integer,
@cantCompu TINYINT,
@piso TINYINT,
@aire BIT,
@videoBeam BIT,
@disponible BIT,
@id_equipo INTEGER
as
update Laboratorio set  cantCompu = @cantCompu, piso= @piso, aire = @aire, videoBeam = @videoBeam, disponible = @disponible, id_equipo = @id_equipo
where id_lab = @id;

create procedure Registrar_Curso
@id_curso VARCHAR(5),
@cedula VARCHAR(20),
@nombre VARCHAR(20),
@turno TINYINT
as
insert into curso (id_curso, cedula, nombre, turno)values(@id_curso, @cedula, @nombre, @turno);

create procedure Actualizar_Curso
@id_curso VARCHAR(5),
@cedula VARCHAR(20),
@nombre VARCHAR(20),
@turno TINYINT
as
update curso set cedula= @cedula, nombre = @nombre, turno = @turno where id_curso = @id_curso;

create procedure Buscar_Curso_ID
@id varchar(5)
as
select u.nombre, u.apellido1, u.apellido2, c.cedula, c.nombre, c.turno from curso c inner join usuario u 
on c.cedula = u.cedula  where c.id_curso = @id;

create procedure Buscar_Curso_Cedula_Profesor
@cedula varchar(20)
as
select u.nombre, u.apellido1, u.apellido2, c.cedula, c.nombre, c.turno from curso c inner join usuario u 
on c.cedula = u.cedula  where c.cedula = @cedula;

create procedure Eliminar_Curso
@id_curso varchar(20)
as
delete from curso where id_curso = @id_curso;

create procedure Registrar_Solicitud
@id_lab INTEGER,
@id_curso VARCHAR(5),
@fecha DATE,
@hora_ini TIME,
@hora_fin TIME,
@activo BIT
as
insert into solicitud (id_lab, id_curso, fecha, hora_ini, hora_fin, activo)
values(@id_lab, @id_curso, @fecha, @hora_ini, @hora_fin, @activo);


create procedure Traer_ID_Labs
as
select id_lab from Laboratorio;


---- meter dentro del ciclo para validar cada lab
create function Validar_Labs_Solicitado
(@id integer)
returns bit
as
begin
declare @existe bit = 0;
declare @no integer;
select @no = id_lab from Solicitud where id_lab = @id;
if @no != ' '
begin
set @existe = 1;
end
return @existe
end


create procedure Traer_Info_Solicitud
@id_lab integer
as
select  u.nombre, u.apellido1, u.apellido2, s.id_curso, s.fecha, s.hora_ini, s.hora_fin, s.activo from solicitud s inner join curso l 
on s.id_curso = l.id_curso inner join usuario u on l.cedula = u.cedula
where s.id_lab = @id_lab;

create procedure Traer_solicitudes
as
select u.nombre, u.apellido1, u.apellido2, s.id_curso, s.fecha, s.hora_ini, s.hora_fin, s.activo from solicitud s inner join curso l 
on s.id_curso = l.id_curso inner join usuario u on l.cedula = u.cedula

create procedure Aprobar_Denegar
@activo bit,
@id_lab integer
as
update Solicitud set activo = @activo where id_lab = @id_lab;

create procedure Reporte_Solicitud_Laboratorio_General
as
select c.cedula, u.nombre, u.apellido1, l.id_lab, l.cantCompu,l.piso, s.fecha, s.hora_ini, s.hora_fin, s.id_curso,s.id_solic 
from laboratorio l inner join solicitud s on l.id_lab = s.id_lab 
inner join curso c on s.id_curso = c.id_curso inner join usuario u on u.cedula = c.cedula; 



create procedure Reporte_Solicitud_Cedula
@cedula varchar(20)
as
select c.cedula, u.nombre, u.apellido1, l.id_lab, l.cantCompu,l.piso, s.fecha, s.hora_ini, s.hora_fin, s.id_curso,s.id_solic 
from laboratorio l inner join solicitud s on l.id_lab = s.id_lab 
inner join curso c on s.id_curso = c.id_curso inner join usuario u on u.cedula = c.cedula
where u.cedula = @cedula;

create procedure Reporte_Solicitud_ID_Lab
@id_lab integer
as
select c.cedula, u.nombre, u.apellido1, l.id_lab, l.cantCompu,l.piso, s.fecha, s.hora_ini, s.hora_fin, s.id_curso,s.id_solic 
from laboratorio l inner join solicitud s on l.id_lab = s.id_lab 
inner join curso c on s.id_curso = c.id_curso inner join usuario u on u.cedula = c.cedula
where l.id_lab = @id_lab;

create procedure Reporte_solicitud_Fecha
@fecha date
as
select c.cedula, u.nombre, u.apellido1, l.id_lab, l.cantCompu,l.piso, s.fecha, s.hora_ini, s.hora_fin, s.id_curso,s.id_solic 
from laboratorio l inner join solicitud s on l.id_lab = s.id_lab 
inner join curso c on s.id_curso = c.id_curso inner join usuario u on u.cedula = c.cedula
where s.fecha = @fecha;