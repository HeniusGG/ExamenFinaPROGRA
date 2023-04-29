<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ingresar.aspx.cs" Inherits="ExamenFinal.Ingresar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
		body {
			text-align: center;
		}
        img {
			display: block;
			margin: auto;
		}
	</style>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nombre de Usuario:
            <asp:TextBox ID="nombre_usuario" runat="server"></asp:TextBox>
            <br />
            <br />
            Clave:
            <asp:TextBox ID="clave_usuario" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="ingre" runat="server" OnClick="ingre_Click" style="height: 26px" Text="Ingresar" />

        </div>
        <img src="Imagenes/veterinarian-dog-clinic-conceptual-illustration-260nw-1955710519.jpg" />
    </form>
</body>
</html>
