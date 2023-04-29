<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportesUsuarios.aspx.cs" Inherits="ExamenFinal.ReportesUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <div aria-atomic="False">
            <br />
            ID:
            <asp:TextBox ID="ID" runat="server"></asp:TextBox>
            <br />
            <br />
            Login_Usuario: <asp:TextBox ID="Login" runat="server"></asp:TextBox>
            <br />
            <br />
            Clave_Usuario:
            <asp:TextBox ID="Clave" runat="server"></asp:TextBox>
            <br />
            <br />
            Nombre_Usuario:
            <asp:TextBox ID="Nombre" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar" />
&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Modificar" />
&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Eliminar" />
        </div>
    </form>
</body>
</html>
