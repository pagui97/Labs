<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consultas.aspx.cs" Inherits="WcfService1.ClienteHtml.Consultas" %>

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

        <script type="text/javascript">
            function Reporte_Solicitud_Laboratorio_General() {
                $.ajax({
                    url: "http://localhost:51116/Service1.svc/JSON/Reporte_Solicitud_Laboratorio_General",
                    type: "POST",
                    dataType: "JSON",
                    success: function (data) {
                        var arreglo = [];
                        arreglo = data;
                        arreglo.map(function (item) {
                            $("#cuerpoTabla").append("<tr><th>" + item.Cedula + "</th><th>" + item.Nombre +
                                "</th><th>" + item.Apellido + "</th><th>" + item.ID_lab + "</th><th>" + item.cantidad + "</th><th>" + item.piso +
                                "</th><th>" + item.fecha + "</th><th>" + item.hora_ini + "</th><th>" + item.hora_fin + "</th><th>" + item.curso_ID +
                                "</th><th>" + item.id_solicitud + "</th> <tr>");
                        })
                    },
                    error: function (e) {
                        alert(e.responseText);
                    }
                })
            }

            function Reporte_Solicitud_Cedula() {
                var cedula = $("#cedula").val();
                $.ajax({
                    url: "http://localhost:51116/Service1.svc/JSON/Reporte_Solicitud_Cedula?cedula="+ cedula,
                    type: "POST",
                    dataType: "JSON",
                    success: function (data) {
                        var arreglo = [];
                        arreglo = data;
                        arreglo.map(function (item) {
                            $("#cuerpoTabla").append("<tr><td>" + item.Cedula + "</td><td>" + item.Nombre +
                                "</td><td>" + item.Apellido + "</td><td>" + item.ID_lab + "</td><td>" + item.cantidad + "</td><td>" + item.piso +
                                "</td><td>" + item.fecha + "</td><td>" + item.hora_ini + "</td><td>" + item.hora_fin + "</td><td>" + item.curso_ID +
                                "</td><td>" + item.id_solicitud + "</td> <tr>");
                        })
                    },
                    error: function (e) {
                        alert(e.responseText);
                    }
                })
            }

            function Reporte_Solicitud_Fecha() {
                var fecha = $("#fecha").val();
                $.ajax({
                    url: "http://localhost:51116/Service1.svc/JSON/Reporte_solicitud_Fecha?fecha="+fecha,
                    type: "POST",
                    dataType: "JSON",
                    success: function (data) {
                        var arreglo = [];
                        arreglo = data;
                        arreglo.map(function (item) {
                            $("#cuerpoTabla").append("<tr><td>" + item.Cedula + "</td><td>" + item.Nombre +
                                "</td><td>" + item.Apellido + "</td><td>" + item.ID_lab + "</td><td>" + item.cantidad + "</td><td>" + item.piso +
                                "</td><td>" + item.fecha + "</td><td>" + item.hora_ini + "</td><td>" + item.hora_fin + "</td><td>" + item.curso_ID +
                                "</td><td>" + item.id_solicitud + "</td> <tr>");
                        })
                    },
                    error: function (e) {
                        alert(e.responseText);
                    }
                })
            }

            function Reporte_Solicitud_id() {
                var id = $("#id").val();
                $.ajax({
                    url: "http://localhost:51116/Service1.svc/JSON/Reporte_Solicitud_ID_Lab?id="+id,
                    type: "POST",
                    dataType: "JSON",
                    success: function (data) {
                        var arreglo = [];
                        arreglo = data;
                        arreglo.map(function (item) {
                            $("#cuerpoTabla").append("<tr><td>" + item.Cedula + "</td><td>" + item.Nombre +
                                "</td><td>" + item.Apellido + "</td><td>" + item.ID_lab + "</td><td>" + item.cantidad + "</td><td>" + item.piso +
                                "</td><td>" + item.fecha + "</td><td>" + item.hora_ini + "</td><td>" + item.hora_fin + "</td><td>" + item.curso_ID +
                                "</td><td>" + item.id_solicitud + "</td> <tr>");
                        })
                    },
                    error: function (e) {
                        alert(e.responseText);
                    }
                })
            }

           

            $(document).ready(function () {
                Reporte_Solicitud_Laboratorio_General();
                $("#boton").click(function () {
                     cedula = document.getElementById("cedula").value;
                     fecha = document.getElementById("fecha").value;
                     id = document.getElementById("id").value;
                     if (cedula.length != 0) {
                         Reporte_Solicitud_Cedula();
                     } else if(fecha.length != 0) {
                         Reporte_Solicitud_Fecha();
                     } else if (id.length != 0) {
                         Reporte_Solicitud_id();
                     }
                })
            })

        </script>


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
                        <label>Número de Cedula:</label><input class="txt" type="" name="" id="cedula">
                        <label>ID Laboratorio:</label><input class="txt" type="" name="" id="id">
                        <label>Fecha:</label><input class="txt" type="date" name="" id="fecha">
                        <div class="boton"><input class="btnA" type="submit" name="" value="Buscar" id="boton"></div>
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
            <tbody class="table-hover">
            <!--<tr>
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
