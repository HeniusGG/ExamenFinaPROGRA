<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="ExamenFinal.inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            Veterinaria Sol</p>
<p class="auto-style1">
    <asp:Image ID="Image1" runat="server" Height="288px" ImageUrl="~/Imagenes/VETERINARIODOG.jpg" Width="268px" />
</p>
            <p class="auto-style1">
                <asp:Button ID="Usuarios" runat="server" OnClick="Usuarios_Click" Text="Reportes Usuarios" />
&nbsp;&nbsp;
                <asp:Button ID="Mascotas" runat="server" OnClick="Mascotas_Click" Text="Reporte Mascotas" />
&nbsp;&nbsp;
                <asp:Button ID="Citas" runat="server" OnClick="Citas_Click" Text="Reportes Citas" />
&nbsp;&nbsp;
                <asp:Button ID="Salir" runat="server" OnClick="Salir_Click" Text="Salir" />
</p>
            <p class="auto-style1">
                &nbsp;</p>
<p>
    &nbsp;</p>

        </div>
    </form>
</body>
</html>
