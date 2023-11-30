<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="ProyectoRopaDeportiva.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <p>
        Bienvenido a Ropa Deportiva Utap<br />
    </p>
    <p>
        Seleccione la opción que desea modificar:</p>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Clientes" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Vendedores" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Text="Productos" />
            <br />
            <br />
            Si desea comprar productos o consultar facturas:<br />
            <br />
            <asp:Button ID="Button4" runat="server" Text="Facturas" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button5" runat="server" Text="Comprar" />
        </div>
    </form>
</body>
</html>
