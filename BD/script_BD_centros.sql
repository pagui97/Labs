USE master;
--DROP DATABASE labs;
CREATE DATABASE labs;

USE labs;

CREATE TABLE rol (
	id_rol INTEGER IDENTITY(1,1) PRIMARY KEY
	,descripcion VARCHAR(100)
);

CREATE TABLE usuario(
	cedula VARCHAR(20) PRIMARY KEY
	,nombre VARCHAR(50)
	,apellido1 VARCHAR(50)
	,apellido2 VARCHAR(50)
	,ocupacion VARCHAR(50)
	,id_rol INTEGER FOREIGN KEY REFERENCES rol(id_rol)
	,userName VARCHAR(20)
	,contraseña VARCHAR(50)
);

CREATE TABLE laboratorio(
	id_lab INTEGER PRIMARY KEY 
	,cantCompu TINYINT
	,piso TINYINT
	,aire BIT
	,videoBeam BIT
	,disponible BIT
);

CREATE TABLE equipo(
	id_equipo INTEGER IDENTITY(1,1) PRIMARY KEY
	,config VARCHAR(100)
	,software VARCHAR(200)
	,sistOper VARCHAR(100)
	,servidores VARCHAR(100)
	,id_lab INTEGER FOREIGN KEY REFERENCES laboratorio(id_lab)
);


CREATE TABLE solicitud(
	id_solic INTEGER IDENTITY(1,1) PRIMARY KEY
	,id_lab INTEGER FOREIGN KEY REFERENCES laboratorio(id_lab)
	,cedula VARCHAR(20) FOREIGN KEY REFERENCES usuario(cedula)
	,fecha DATE
	,hora_ini TIME
	,hora_fin TIME
	,activo BIT
);

INSERT INTO rol(descripcion) VALUES ('administrador'), ('profesor');