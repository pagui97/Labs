<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="boleta.aspx.cs" Inherits="WcfService1.boleta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Boleta de solicitud</title>
	<link rel="stylesheet" type="text/css" href="css/styleBoleta.css"/>
	<link href="https://fonts.googleapis.com/css?family=Questrial" rel="stylesheet"/>
</head>
<body>
    <header>
	<img src="images/programming.png"/>
	<h1>Mantenimientos de Laboratorios</h1>
	<div class="clear"></div>
</header>
<div id="content">
	<center>
		<div class="boleta">
			<h2>Laboratorio Solicitado</h2>
			<form>
				<fieldset>
					<label>Número de aula:</label><input class="txt" type="text" name=""/>
					<label>Fecha:</label><input class="txt" type=text"" name=""/>
					<label>Hora:</label><input class="txt" type="text" name=""/>
				</fieldset>
			</form>
		</div>
	<div class="clear"></div>
	<div class="boton"><input class="btnE" type="submit" name="" value="Enviar"/></div>
	</center>
</div>
<footer>Administración de Centros de Cómputo</footer>
</body>
</html>
