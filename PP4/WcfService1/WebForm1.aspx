<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WcfService1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <meta name="description" content=""/>
    <meta name="author" content=""/>

    <title>Laboratorios</title>

    <!-- Bootstrap Core CSS -->
    <link href="css/cssMante/bootstrap.min.css" rel="stylesheet"/>

    <!-- Custom CSS -->
    <link href="css/cssMante/logo-nav.css" rel="stylesheet"/>
    <link rel="stylesheet" type="text/css" href="css/cssMante/styleMantenimientos.css"/>
    <link href="https://fonts.googleapis.com/css?family=Questrial" rel="stylesheet"/>
    <script src="jquery-3.2.1.min.js" type="text/javascript"></script>
</head>
<body>
     <!-- Navegacion-->
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
                <h2>Laboratorio</h2>
                <form>
                    <fieldset>
                        <label>Número de aula:</label><input class="txt" type="text" id="txtId"/>
                        <label>Cantidad de computadoras:</label><input class="txt" type="text" id="txtCant"/>
                        <label>Piso:</label><input class="txt" type="text" id="txtPiso"/>
                        <label><input type="checkbox" id="aire"/> Aire Acondicionado</label>
                        <label><input type="checkbox" id="video"/> Video Beam</label>
                        <label><input type="checkbox" id="disponible"/> Disponible</label>
                    </fieldset>
                </form>
            </div>
            <div class="lab">
                <h2>Equipo</h2>
                <form>
                    <fieldset>
                        <label>Configuración de equipo:</label><input class="txt" type="text" id="txtConfig"/>
                        <label>Software Instalado:</label><input class="txt" type="text" id="txtSoftw"/>
                        <label>Sistema Operativo:</label><input class="txt" type="text" id="txtSisOp"/>
                        <label>Servidores:</label><input class="txt" type="text" id="txtServer"/>
                    </fieldset>
                </form>

        </div>
        </div>
        <div id="botones">
            <div class="boton"><input class="btnA" type="submit" id="botonInsertar" value="Insertar"/></div>
            <div class="boton"><input class="btnE" type="submit" name="" value="Eliminar"/></div>
            <div class="boton"><input class="btnA" type="submit" name="" value="Buscar"/></div>
            <div class="boton"><input class="btnE" type="submit" name="" value="Actualizar"/></div>
        </div>
    </div>
    <div class="clear"></div>

    <footer>Administración de Centros de Cómputo</footer>
    <script type="text/javascript">
        function InsertarLab() {
            if ($('#aire').is(':checked')) {
                var aire = 1;
            } else {
                aire = 0;
            }
            if ($('#video').is(':checked')) {
                var video = 1;
            } else {
                video = 0;
            }
            if ($('#disponible').is(':checked')) {
                var disponible = 1;
            } else {
                disponible = 0;
            }
            var id_lab = $("#txtId").val();
            var cantCompu = $("#txtCant").val();
            var piso = $("#txtPiso").val();
            $.ajax({
                url: "http://localhost:51116/Service1.svc/JSON/Registrar_Laboratorio?id_lab=" + id_lab + "&cantCompu=" + cantCompu + "&piso=" + piso + "&aire=" + aire + "&videoBeam=" + video + "&disponible=" + disponible,
                type: "GET",
                contentType: "application/json;charset= utf-8",
                dataType: "JSON",
                success: function (data) {
                    alert("Resgistrado con éxito")
                },
                error:function(e) {
                    alert(JSON.stringify(e));
            }
            });
        }

        $(document).ready(function() {
            $("#botonInsertar").click(function() {
                InsertarLab();
            })
        })
    </script>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>
