<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsuariosMan.aspx.cs" Inherits="WcfService1.UsuariosMan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <meta name="description" content=""/>
    <meta name="author" content=""/>

    <title>Usuarios</title>

    <!-- Bootstrap Core CSS -->
    <link href="css/cssMante/bootstrap.min.css" rel="stylesheet"/>

    <!-- Custom CSS -->
    <link href="css/cssMante/logo-nav.css" rel="stylesheet"/>
    <link rel="stylesheet" type="text/css" href="css/cssMante/styleMantenimientos.css"/>
    <link href="https://fonts.googleapis.com/css?family=Questrial" rel="stylesheet"/>
    <script src="jquery-3.2.1.min.js" type="text/javascript"></script>
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
                <h2>Información Personal</h2>
                <form>
                    <fieldset>
                        <label>Número de Cedula:</label><input class="txt" type="text" id="txtCedula"/>
                        <label>Nombre:</label><input class="txt" type="text" id="txtNombre"/>
                        <label>Primer Apellido:</label><input class="txt" type="text" id="txtApellido1"/>
                        <label>Segundo Apellido:</label><input class="txt" type="text" id="txtApellido2"/>


                    </fieldset>
                </form>
            </div>
            <div class="lab">
                <h2>Usuario</h2>
                <form>
                    <fieldset>
                        <label>Ocupación:</label><input class="txt" type="text" id="txtOcupacion"/>
                        <label>Rol</label>
                        <label><input type="checkbox" id="admi"/>Administrador</label>
                        <label><input type="checkbox" id="prof"/>Profesor</label>
                        <label>Nombre de Usuario:</label><input class="txt" type="text" id="txtUsername"/>
                        <label>Contraseña:</label><input class="txt" type="password" id="txtpassword"/>
                    </fieldset>
                </form>

        </div>
        </div>
        <div id="botones">
            <div class="boton"><input class="btnA" type="submit" id="botonInsertar" value="Insertar"/></div>
            <div class="boton"><input class="btnE" type="submit" name="" value="Buscar"/></div>
            <div class="boton"><input class="btnA" type="submit" id="botonActualizar" value="Actualizar"/></div>
        </div>
    </div>
    <div class="clear"></div>
    <footer>Administración de Centros de Cómputo</footer>
    <script type="text/javascript">
        function InsertarUsuario() {
            if ($('#admi').is(':checked')) {
                var rol = 1;
            } else {
                if ($('#prof').is(':checked')) {
                    rol = 2;
                }
            }
            var cedula = $("#txtCedula").val();
            var nombre = $("#txtNombre").val();
            var apellido1 = $("#txtApellido1").val();
            var apellido2 = $("#txtApellido2").val();
            var ocupacion = $("#txtOcupacion").val();
            var username = $("#txtUsername").val();
            var contraseña = $("#txtpassword").val();
            $.ajax({
                url: "http://localhost:51116/Service1.svc/JSON/Registrar_Usuario?cedula=" + cedula + "&nombre=" + nombre + "&apellido1=" + apellido1 + "&apellido2=" + apellido2 + "&ocupacion=" + ocupacion + "&id_rol=" + rol+"&username="+username+"&contraseña="+contraseña,
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

        function ActualizarUsuario() {
            if ($('#admi').is(':checked')) {
                var rol = 1;
            } else {
                if ($('#prof').is(':checked')) {
                    rol = 2;
                }
            }
            var cedula = $("#txtCedula").val();
            var nombre = $("#txtNombre").val();
            var apellido1 = $("#txtApellido1").val();
            var apellido2 = $("#txtApellido2").val();
            var ocupacion = $("#txtOcupacion").val();
            var username = $("#txtUsername").val();
            var contraseña = $("#txtpassword").val();
            $.ajax({
                url: "http://localhost:51116/Service1.svc/JSON/Actualizar_Usuario?cedula=" + cedula + "&nombre=" + nombre + "&apellido1=" + apellido1 + "&apellido2=" + apellido2 + "&ocupacion=" + ocupacion + "&id_rol=" + rol + "&username=" + username + "&contraseña=" + contraseña,
                type: "GET",
                contentType: "application/json;charset= utf-8",
                dataType: "JSON",
                success: function (data) {
                    alert("Resgistrado con éxito")
                },
                error: function (e) {
                    alert(JSON.stringify(e));
                }
            });
        }

        $(document).ready(function() {
            $("#botonInsertar").click(function() {
                InsertarUsuario();
            })
            $("#botonActualizar").click(function () {
                ActualizarUsuario();
            })
        })
    </script>
</body>
</html>