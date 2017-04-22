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
                        <label>Nombre de Usuario:</label><input class="txt" type="text" id="txtUsername"/>
                        <label>Contrasena:</label><input class="txt" type="text" id="txtContrasena"/>
                    </fieldset>
                </form>
            </div>
            
        </div>
        <div id="botones">
            <div class="boton"><input class="btnA" type="submit" id="botonLogIn" value="LogIn"/></div>
            
        </div>
    </div>
    <div class="clear"></div>
    <footer>Administración de Centros de Cómputo</footer>
    <script type="text/javascript">
        function Login() {
            
            var username = $("#txtUsername").val();
            var contrasena = $("#txtContrasena").val();
            
            $.ajax({
                url: "http://localhost:51116/Service1.svc/JSON/validarLogIn?username=" + username + "&contrasena=" ,
                type: "GET",
                contentType: "application/json;charset= utf-8",
                dataType: "JSON",
                success: function(data) {
                    alert(data['validarLogInResult']);
                },
                error:function(e) {
                    alert(JSON.stringify(e));
            }
            });
        }
    </script>
</body>
</html>
