<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ventas.aspx.cs" Inherits="ProyectoRopaDeportiva.Ventas" EnableEventValidation="false" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ventas - Carrito de Compras</title>
    <!-- Agrega aquí tus enlaces a CSS o scripts si es necesario -->
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Productos Disponibles</h2>
            <asp:Repeater ID="rptProductos" runat="server" EnableViewState="true">
                <ItemTemplate>
                    <div>
                        <h3><%# Eval("Pro_nombre") %></h3>
                        <p>Precio: $<%# Eval("Pro_precio") %></p>
                        <asp:Button ID="btnAgregarAlCarrito" runat="server" Text="Agregar al Carrito" CommandName="AgregarCarrito" CommandArgument='<%# Eval("Pro_id") %>' OnItemCommand="rptProductos_ItemCommand" />
                    </div>
                </ItemTemplate>
            </asp:Repeater>

            <hr />

            <h2>Carrito de Compras</h2>
            <asp:GridView ID="gvCarrito" runat="server" AutoGenerateColumns="False" EnableViewState="false">
                <Columns>
                    <asp:BoundField DataField="Pro_nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="Pro_precio" HeaderText="Precio" />
                    <asp:TemplateField HeaderText="Acciones">
                        <ItemTemplate>
                            <asp:LinkButton ID="lnkEliminar" runat="server" Text="Eliminar" CommandName="EliminarCarrito" CommandArgument='<%# Container.DataItemIndex %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>

            <asp:Button ID="btnRealizarCompra" runat="server" Text="Realizar Compra"/>
        </div>
    </form>
</body>
</html>