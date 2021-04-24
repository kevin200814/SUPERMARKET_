<%@ Page Title="" Language="C#" MasterPageFile="~/Template/PrincipClien.master" AutoEventWireup="true" CodeFile="ProductosAdmin.aspx.cs" Inherits="webformsADM_producto_ProductosAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <h2>Productos</h2>

      <p>
        <asp:LinkButton  ID="btnNuevo" runat="server"  OnClick="btnNuevo_Click"   ><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-plus-circle" viewBox="0 0 16 16">
  <path d="M8 15A7 7 0 1 1 8 1a7 7 0 0 1 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z"/>
  <path d="M8 4a.5.5 0 0 1 .5.5v3h3a.5.5 0 0 1 0 1h-3v3a.5.5 0 0 1-1 0v-3h-3a.5.5 0 0 1 0-1h3v-3A.5.5 0 0 1 8 4z"/>
</svg> Nuevo Producto</asp:LinkButton>
    </p>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="OdsProductos">
        <Columns>
            <asp:BoundField DataField="ID_PRODUCTO" HeaderText="ID_PRODUCTO" SortExpression="ID_PRODUCTO" />
            <asp:BoundField DataField="NOMBRE_PRODUCTO" HeaderText="NOMBRE_PRODUCTO" SortExpression="NOMBRE_PRODUCTO" />
            <asp:BoundField DataField="FECHA_ELABORACION_PRODUCTO" HeaderText="FECHA_ELABORACION_PRODUCTO" SortExpression="FECHA_ELABORACION_PRODUCTO" />
            <asp:BoundField DataField="FECHA_VENCIMIENTO_PRODUCTO" HeaderText="FECHA_VENCIMIENTO_PRODUCTO" SortExpression="FECHA_VENCIMIENTO_PRODUCTO" />
            <asp:BoundField DataField="VENTA_PRODUCTO" HeaderText="VENTA_PRODUCTO" SortExpression="VENTA_PRODUCTO" />
            <asp:BoundField DataField="CANTIDAD_PRODUCTO" HeaderText="CANTIDAD_PRODUCTO" SortExpression="CANTIDAD_PRODUCTO" />
            <asp:BoundField DataField="DESCRIPCION_PRODUCTO" HeaderText="DESCRIPCION_PRODUCTO" SortExpression="DESCRIPCION_PRODUCTO" />
           
           
            <asp:BoundField DataField="PRECIO" HeaderText="PRECIO" SortExpression="PRECIO" />

             <asp:TemplateField>
             <ItemTemplate>

                 <asp:Image ID="img" ImageUrl='<%#"~/img/"+Eval("IMG") %>' runat="server" />
                 </ItemTemplate>
            </asp:TemplateField>

              <asp:TemplateField>
             <ItemTemplate>
            <asp:LinkButton ID="btnEliminar"   OnClick="btnEliminar_Click" CommandArgument='<%#Eval("ID_PRODUCTO") %>'   runat="server" Text="Eliminar"><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-trash-fill" viewBox="0 0 16 16">
             <path d="M2.5 1a1 1 0 0 0-1 1v1a1 1 0 0 0 1 1H3v9a2 2 0 0 0 2 2h6a2 2 0 0 0 2-2V4h.5a1 1 0 0 0 1-1V2a1 1 0 0 0-1-1H10a1 1 0 0 0-1-1H7a1 1 0 0 0-1 1H2.5zm3 4a.5.5 0 0 1 .5.5v7a.5.5 0 0 1-1 0v-7a.5.5 0 0 1 .5-.5zM8 5a.5.5 0 0 1 .5.5v7a.5.5 0 0 1-1 0v-7A.5.5 0 0 1 8 5zm3 .5v7a.5.5 0 0 1-1 0v-7a.5.5 0 0 1 1 0z"/>
            </svg> Eliminar</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>

                 <asp:TemplateField>
                <ItemTemplate>
                 <asp:HyperLink  runat="server" NavigateUrl='<%#"~/webformsADM/producto/EditarProductos.aspx?ID_PRODUCTO="+Eval("ID_PRODUCTO") %>' ><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-arrow-repeat" viewBox="0 0 16 16">
                <path d="M11.534 7h3.932a.25.25 0 0 1 .192.41l-1.966 2.36a.25.25 0 0 1-.384 0l-1.966-2.36a.25.25 0 0 1 .192-.41zm-11 2h3.932a.25.25 0 0 0 .192-.41L2.692 6.23a.25.25 0 0 0-.384 0L.342 8.59A.25.25 0 0 0 .534 9z"/>
                <path fill-rule="evenodd" d="M8 3c-1.552 0-2.94.707-3.857 1.818a.5.5 0 1 1-.771-.636A6.002 6.002 0 0 1 13.917 7H12.9A5.002 5.002 0 0 0 8 3zM3.1 9a5.002 5.002 0 0 0 8.757 2.182.5.5 0 1 1 .771.636A6.002 6.002 0 0 1 2.083 9H3.1z"/>
                </svg> Editar</asp:HyperLink>
                </ItemTemplate> 
            </asp:TemplateField>


        </Columns>
     </asp:GridView>

     <asp:ObjectDataSource ID="OdsProductos" runat="server" SelectMethod="Mostarproducto" TypeName="PRODUCTOS_BLL"></asp:ObjectDataSource>

</asp:Content>

