<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WcfService1.ClienteHtml.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="utf-8"/>
        <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
        <meta name="viewport" content="width=device-width, initial-scale=1"/>
        <meta name="description" content="/>
        <meta name="author" content=""/>

        <title>Administración de Laboratorios</title>

        <!-- Bootstrap Core CSS -->
        <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet"/>

        <!-- Font Awesome CSS -->
        <link href="css/font-awesome.min.css" rel="stylesheet"/>

        <!-- Custom CSS -->
        <link href="css/style.css" rel="stylesheet"/>
</head>
<body>
    <!-- Seccion de encabezado -->
        <section id="logo-section" class="text-center">
            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <div class="logo text-center">
                            <h1>Universidad Internacional de las Américas</h1>
                            <span>Administración de laboratorios</span>
                        </div>
                    </div>
                </div>

            </div>
        </section>
        <!-- fin seccion de encabezado -->
        
        
        <!-- parte principal -->
        <div class="mainbody-section text-center">
            <div class="container">
                <div class="row">
                    
                    <div class="col-md-3">
                        
                        <div class="menu-item blue">
                            <a href="UsuariosMan.aspx">

                                <p>Mantenimientos Usuarios</p>
                            </a>
                        </div>
                        
                        <div class="menu-item green">
                           <a href="WebForm1.aspx" >

                                <p>Mantenimientos Laboratorios</p>
                            </a>
                        </div>
                    </div>

                    <div class="col-md-6">
                        <div class="home-slider">
                            <div id="carousel-example-generic" class="carousel slide" data-ride="carousel" style="padding-bottom: 30px;">
                                <!-- Wrapper for slides -->
                                <div class="carousel-inner">
                                    <div class="item active">
                                        <img src="images/uia.jpg" class="img-responsive" alt=""/>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    
                    <div class="col-md-3">
                        
                        <div class="menu-item light-red">
                            <a href="Consultas.aspx" data-toggle="modal">

                                <p>Consultas</p>
                            </a>
                        </div>
                        
                        <div class="menu-item color">
                            <a href="Asignacion.aspx" data-toggle="modal">

                                <p>Asignación</p>
                            </a>
                        </div>
                        <div class="menu-item green">
                            <a href="Login.html" >

                                <p>Salir</p>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- fin parte principal-->
        
        <!-- footer -->
        <div class="copyright text-center">
            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <div>Programación IV</div>
                    </div>
                </div>
            </div>
        </div>
        <!-- fin footer -->
</body>
</html>
