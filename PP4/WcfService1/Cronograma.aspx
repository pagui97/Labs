<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cronograma.aspx.cs" Inherits="WcfService1.Cronograma" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cronograma</title>
	<link rel="stylesheet" type="text/css" href="css/styleCronograma.css"/>
	<link href="https://fonts.googleapis.com/css?family=Questrial" rel="stylesheet"/>
</head>
<body>
    <header>
		<img src="images/programming.png"/>
		<h1>Solicitud de Laboratorio</h1>
		<div class="clear"></div>
	</header>
    <div class="content">
		<center>
			<table id="ctl00_cphBody_tblCitaHuecos" class="tramos" cellpadding="0" cellspacing="0">
				<tbody>
					<tr>
						<td rowspan="3" class="encb"></td>
						<td colspan="10" class="encb">Horario de mañana</td>
						<td colspan="18" class="encb">Horario de tarde</td>				
					</tr>
					<tr class="horas">
						<td colspan="2">8<br/>horas</td>
						<td colspan="2">9<br/>horas</td>
						<td colspan="2">10<br/>horas</td>
						<td colspan="2">11<br/>horas</td>
						<td colspan="2">12<br/>horas</td>
						<td colspan="2">13<br/>horas</td>
						<td colspan="2">14<br/>horas</td>
						<td colspan="2">15<br/>horas</td>
						<td colspan="2">16<br/>horas</td>
						<td colspan="2">17<br/>horas</td>
						<td colspan="2">18<br/>horas</td>
						<td colspan="2">19<br/>horas</td>
						<td colspan="2">20<br/>horas</td>
						<td colspan="2">21<br/>horas</td>
					</tr>
					<tr class="medios">
						<td>00</td>
						<td class="dch">30</td>
						<td>00</td>
						<td class="dch">30</td>
						<td>00</td>
						<td class="dch">30</td>
						<td>00</td>
						<td class="dch">30</td>
						<td>00</td>
						<td class="dch">30</td>
						<td>00</td>
						<td class="dch">30</td>
						<td>00</td>
						<td class="dch">30</td>
						<td>00</td>
						<td class="dch">30</td>
						<td>00</td>
						<td class="dch">30</td>
						<td>00</td>
						<td class="dch">30</td>
						<td>00</td>
						<td class="dch">30</td>
						<td>00</td>
						<td class="dch">30</td>
						<td>00</td>
						<td class="dch">30</td>
						<td>00</td>
						<td class="dch">30</td>
						</tr>
					<tr>
						<td class="dia">Domingo 23/04</td>
						<td colspan="28">DOMINGO</td>
					</tr>
					<tr>
						<td class="dia">Lunes 24/04</td>
						<td id="cita"><a href="boleta.aspx">p</a></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
					</tr>
					<tr>
						<td class="dia">Martes 25/04</td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
					</tr>
					<tr>
						<td class="dia">Miércoles 26/04</td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
					</tr>
					<tr>
						<td class="dia">Jueves 27/04</td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
					</tr>
					<tr>
						<td class="dia">Viernes 28/04</td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
					</tr>
					<tr>
						<td class="dia">Sábado 29/04</td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td> 
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
					</tr>
					<tr>
						<td class="dia">Domingo 30/04</td>
						<td colspan="28">DOMINGO</td>
					</tr>
					<tr>
						<td class="dia">Lunes 1/05</td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
					</tr>
					<tr>
						<td class="dia">Martes 2/05</td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
					</tr>
					<tr>
						<td class="dia">Miércoles 3/05</td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
					</tr>
					<tr>
						<td class="dia">Jueves 4/05</td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
						<td id="cita"></td>
						<td id="cita" class="dch"></td>
					</tr>
				</tbody>
			</table>
		</center>
	</div>
</body>
</html>
