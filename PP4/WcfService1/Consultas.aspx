﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consultas.aspx.cs" Inherits="WcfService1.ClienteHtml.Consultas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
        <title>Reportes</title>
        <link rel="stylesheet" type="text/css" media="screen" href="css/flick/jquery-ui-1.8.16.custom.css" />
        <link rel="stylesheet" type="text/css" media="screen" href="jqgrid/css/ui.jqgrid.css" />

        <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js" type="text/javascript"></script>
        <script src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.8.16/jquery-ui.min.js" type="text/javascript"></script>
        <script src="jqgrid/js/i18n/grid.locale-es.js" type="text/javascript"></script>
        <script src="jqgrid/js/jquery.jqGrid.min.js" type="text/javascript"></script>
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>


        <!-- Bootstrap Core CSS -->
        <link href="css/cssMante/bootstrap.min.css" rel="stylesheet"/>

        <!-- Custom CSS -->
        <link href="css/cssMante/logo-nav.css" rel="stylesheet"/>
        <link rel="stylesheet" type="text/css" href="css/flick/styleConsulta.css"/>
        <link href="https://fonts.googleapis.com/css?family=Questrial" rel="stylesheet"/>
</head>
<body>
    <nav class="navbar navbar-inverse navbar-fixed-top" role="navigation">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                </button>
                <a class="navbar-brand" href="index.html">
                    <img src="images/programming.png" alt="">
                </a>
            </div>
            <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                <ul class="nav navbar-nav">
                    <li>
                        <a href="LabMan.html">Laboratorios</a>
                    </li>
                    <li>
                        <a href="UsuariosMan.html">Usuarios</a>
                    </li>
                    <li>
                        <a href="Asignacion.html">Asignación</a>
                    </li>
                    <li>
                        <a href="Consultas.html">Consultas</a>
                    </li>
                    <li>
                        <a href="Login.html">Salir</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>

    <div class="wrapper">
        <div id="content">
            <div class="lab">
                <h2>Filtar</h2>
                <form>
                    <fieldset>
                        <label>Número de Cedula:</label><input class="txt" type="" name="">
                        <label>ID Laboratorio:</label><input class="txt" type="" name="">
                        <label>Fecha:</label><input class="txt" type="text" name="">
                        <div class="boton"><input class="btnA" type="submit" name="" value="Buscar"></div>
                    </fieldset>
                </form>
            </div>
        </div>

        <table class="table-fill">
            <thead>
            <tr>
                <th class="text-left">Cedula</th>
                <th class="text-left">Nombre</th>
                <th class="text-left">Apellido</th>
                <th class="text-left">ID-Laboratorio</th>
                <th class="text-left">Cantidad-Computadoras</th>
                <th class="text-left">Piso</th>
                <th class="text-left">Fecha</th>
                <th class="text-left">Hora-Inicio</th>
                <th class="text-left">Hora-Fin</th>
                <th class="text-left">ID-Curso</th>
                <th class="text-left">ID-Solicitud</th>
            </tr>
            </thead>
            <tbody id="cuerpoTabla"></tbody>
            <!-- <tbody class="table-hover">
            <tr>
                <td class="text-left"></td>
                <td class="text-left"></td>
                <td class="text-left"></td>
                <td class="text-left"></td>
                <td class="text-left"></td>
                <td class="text-left"></td>
                <td class="text-left"></td>
                <td class="text-left"></td>
                <td class="text-left"></td>
                <td class="text-left"></td>
                <td class="text-left"></td>
            </tr>


            </tbody> -->
        </table>

      <!--  <div id="Data">
            <table id="tblclientes"></table>
            <div id="paginacion"> </div>
        </div>-->
    </div>
    <div class="clear"></div>
    <footer>Administración de Centros de Cómputo</footer>
</body>
</html>
