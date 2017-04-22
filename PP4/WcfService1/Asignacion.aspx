<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Asignacion.aspx.cs" Inherits="WcfService1.ClienteHtml.Asignacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
    <title>Reportes</title>
    <link rel="stylesheet" type="text/css" media="screen" href="css/flick/jquery-ui-1.8.16.custom.css" />
    <link rel="stylesheet" type="text/css" media="screen" href="jqgrid/css/ui.jqgrid.css" />

    <!-- Bootstrap Core CSS -->
    <link href="css/cssMante/bootstrap.min.css" rel="stylesheet"/>
    <link href="css/style.css" rel="stylesheet"/>
    <!-- Custom CSS --/>
    <link href="css/font-awesome.min.css" rel="stylesheet">
    <link href="css/animate.css" rel="stylesheet">
    <link href="css/cssMante/logo-nav.css" rel="stylesheet">
    <!--<link rel="stylesheet" type="text/css" href="css/flick/styleConsulta.css">
    <link href="https://fonts.googleapis.com/css?family=Questrial" rel="stylesheet"> -->
    <link href="https://fonts.googleapis.com/css?family=Questrial" rel="stylesheet"/>
    <link rel="stylesheet" type="text/css" href="css/styleLab.css"/>
    <link href='http://fonts.googleapis.com/css?family=Lobster' rel='stylesheet' type='text/css'/>
    <script src="http://code.jquery.com/jquery-latest.js"></script>
    <script type="text/javascript">
        function Reporte_Solicitud_id() {
            var id;
            $("#piso2 .popup-link").click(function () {
                id = $(this).html();
            })
            $("#piso3 .popup-link").click(function () {
                id = $(this).html();
            })
            $("#piso4 .popup-link").click(function () {
                id = $(this).html();
            })
            $.ajax({
                url: "http://localhost:51116/Service1.svc/JSON/Reporte_Solicitud_ID_Lab?id=" + id,
                type: "GET",
                dataType: "JSON",
                success: function (data) {
                    alert(JSON.stringify(data));
                    $.each(data, function(key,value) {
                        $("#cuerpoTabla").append("<tr><td>" + value + "</td>")
                    })
                    
                },
                error: function (e) {
                    alert(e.responseText);
                }
            })
        }
        function aprobar() {
            var valor = $("#valor").val();
            var bit = true;
            $.ajax({
                url: "http://localhost:51116/Service1.svc/JSON/Aprobar_Denegar?activo="+bit +"&id_lab="+valor, 
                type: "GET",
                contentType: "application/json;charset= utf-8",
                dataType: "JSON",
                success: function (data) {
                    alert("Aprobado con éxito")
                },
                error: function (e) {
                    alert(JSON.stringify(e));
                }
            });
            }
        $(document).ready(function () {
            $(".popup-link").click(function () {
                Reporte_Solicitud_id();
            })
                
            $("#boton").click(function () {
                aprobar();
            })

        });
       

    </script>
</head>
<body>
    <nav class="navbar navbar-inverse navbar-fixed-top" role="navigation">
    <div class="container">
        <div class="navbar-header">
            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
            </button>
            <a class="navbar-brand" href="index.html">
                <img src="images/programming.png" alt=""/>
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
                    <a href="Asignacion.php">Asignación</a>
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

<div id="piso2">
    <h3>Piso 2</h3>
    <center>
        <div id="content">
            <div id="aulas1">
                <img class="icon" src="images/stairs_up.png"/>
                <img class="icon" src="images/up.png"/>
                <img class="icon" src="images/stairs_down.png"/>
                <div class="soda"></div>
                <div class="lab">
                    <a  href="#popup" class="popup-link">1202</a>
                    <img src="images/door.png"/>
                </div>
                <div class="lab" id="first">
                    <a  href="#popup" class="popup-link">1201</a>
                    <img src="images/door.png"/>
                </div>
                <div class="clear"></div>
            </div>
            <div id="pasillo">
                <h3>PASILLO</h3>
            </div>
            <div id="aulas2">
                <div class="lab" id="fin">
                    <a  href="#popup" class="popup-link">1205</a>
                    <img class="izq" src="images/door.png"/>
                </div>
                <div class="lab">
                    <a  href="#popup" class="popup-link">1204</a>
                    <img class="izq" src="images/door.png"/>
                </div>
                <div class="aula">
                    <a>1203</a>
                    <img class="dcha" src="images/door.png"/>
                </div>
                <div class="clear"></div>
            </div>
        </div>
    </center>
</div>
<div id="piso3">
    <h3>Piso 3</h3>
    <center>
        <div id="content">
            <div id="aulas1">
                <div class="aula" id="fin">
                    <a>Aula 1305</a>
                    <img src="images/door.png"/>
                </div>
                <div class="aula">
                    <a>Aula 1304</a>
                    <img src="images/door.png"/>
                </div>
                <div class="aula">
                    <a>Aula 1303</a>
                    <img src="images/door.png"/>
                </div>
                <div class="aula">
                    <a>Aula 1302</a>
                    <img src="images/door.png"/>
                </div>
                <div class="aula">
                    <a>Aula 1301</a>
                    <img src="images/door.png"/>
                </div>
                <div class="clear"></div>
            </div>
            <div id="pasillo">
                <h3>PASILLO</h3>
            </div>
            <div id="aulas2">
                <div class="lab" id="fin">
                    <a  href="#popup" class="popup-link">1310</a>
                    <img class="izq" src="images/door.png"/>
                </div>
                <div class="lab">
                    <a  href="#popup" class="popup-link">1309</a>
                    <img class="izq" src="images/door.png"/>
                </div>
                <div class="lab">
                    <a  href="#popup" class="popup-link">1308</a>
                    <img class="izq" src="images/door.png"/>
                </div>
                <div class="lab">
                    <a  href="#popup" class="popup-link">1307</a>
                    <img class="izq" src="images/door.png"/>
                </div>
                <div class="lab">
                    <a  href="#popup" class="popup-link">1306</a>
                    <img class="dcha" src="images/door.png"/>
                </div>
                <div class="clear"></div>
            </div>
        </div>
    </center>
</div>
<div id="piso4">
    <h3>Piso 4</h3>
    <center>
        <div id="content">
            <div id="aulas1">
                <div class="aula" id="fin">
                    <a>Aula 1405</a>
                    <img src="images/door.png"/>
                </div>
                <div class="aula">
                    <a>Aula 1404</a>
                    <img src="images/door.png"/>
                </div>
                <div class="aula">
                    <a>Aula 1403</a>
                    <img src="images/door.png"/>
                </div>
                <div class="aula">
                    <a>Aula 1402</a>
                    <img src="images/door.png"/>
                </div>
                <div class="aula">
                    <a>Aula 1401</a>
                    <img src="images/door.png"/>
                </div>
                <div class="clear"></div>
            </div>
            <div id="pasillo">
                <h3>PASILLO</h3>
            </div>
            <div id="aulas2">
                <div class="lab" id="fin">
                    <a href="#popup" class="popup-link">1410</a>
                    <img class="izq" src="images/door.png"/>
                </div>
                <div class="lab">
                    <a  href="#popup" class="popup-link">1409</a>
                    <img class="izq" src="images/door.png"/>
                </div>
                <div class="lab">
                    <a  href="#popup" class="popup-link">1408</a>
                    <img class="izq" src="images/door.png"/>
                </div>
                <div class="lab">
                    <a  href="#popup" class="popup-link">1407</a>
                    <img class="izq" src="images/door.png"/>
                </div>
                <div class="lab">
                    <a  href="#popup" class="popup-link" >1406</a>
                    <img class="dcha" src="images/door.png"/>
                </div>
                <div class="clear"></div>
            </div>
        </div>
    </center>
</div>

<footer>
    Administración de Centros de Cómputo
</footer>


<div class="modal-wrapper" id="popup">
    <div class="popup-contenedor">
        <h2>Solicitudes</h2>

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
                
                -->
            </tbody>
        </table>
        <label>Codigo de solicitud a aprobrar</label>
        <input id="valor" />
        <input type="submit" id="boton" />

        <a class="popup-cerrar" href="#">X</a>
    </div>
</div>
</body>
</html>
