<%@ Page Title="" Language="C#" MasterPageFile="~/Template/PrincipClien.master" AutoEventWireup="true" CodeFile="IndexProveedor.aspx.cs" Inherits="webformsADM_IndexProveedor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <div class="container body-content">
        <h2>Proveedores</h2>
          <br />
            <asp:LinkButton ID="BtnNuevo" OnClick="BtnNuevo_Click" runat="server"><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-plus-circle" viewBox="0 0 16 16">
              <path d="M8 15A7 7 0 1 1 8 1a7 7 0 0 1 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z"/>
              <path d="M8 4a.5.5 0 0 1 .5.5v3h3a.5.5 0 0 1 0 1h-3v3a.5.5 0 0 1-1 0v-3h-3a.5.5 0 0 1 0-1h3v-3A.5.5 0 0 1 8 4z"/>
            </svg>
                Nuevo Proveedor</asp:LinkButton>
          <br />
          <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="odsProveedor">
        <Columns>
            <asp:BoundField DataField="ID_PROVEEDOR" HeaderText="ID_PROVEEDOR" SortExpression="ID_PROVEEDOR" />
            <asp:BoundField DataField="NOMBRE_PROVEEDOR" HeaderText="NOMBRE_PROVEEDOR" SortExpression="NOMBRE_PROVEEDOR" />

           
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="BtnEliminar" OnClick="BtnEliminar_Click" CommandArgument='<%#Eval("ID_PROVEEDOR") %>' runat="server">
                       <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-trash-fill" viewBox="0 0 16 16">
                    <path d="M2.5 1a1 1 0 0 0-1 1v1a1 1 0 0 0 1 1H3v9a2 2 0 0 0 2 2h6a2 2 0 0 0 2-2V4h.5a1 1 0 0 0 1-1V2a1 1 0 0 0-1-1H10a1 1 0 0 0-1-1H7a1 1 0 0 0-1 1H2.5zm3 4a.5.5 0 0 1 .5.5v7a.5.5 0 0 1-1 0v-7a.5.5 0 0 1 .5-.5zM8 5a.5.5 0 0 1 .5.5v7a.5.5 0 0 1-1 0v-7A.5.5 0 0 1 8 5zm3 .5v7a.5.5 0 0 1-1 0v-7a.5.5 0 0 1 1 0z"/>
                        </svg> Eliminar</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField>
                <ItemTemplate>
                    <asp:HyperLink NavigateUrl='<%#"~/webformsADM/producto/MantProveedor.aspx?ID_PROVEEDOR="+ Eval("ID_PROVEEDOR")%>' runat="server">Editar</asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateField>
           
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="odsProveedor" runat="server" SelectMethod="MostrarTodos" TypeName="PROVEEDOR_BLL"></asp:ObjectDataSource>
</div>
    <br />
    <br />
    <script src="../../js/jquery.min.js"></script>
    <script src="../../js/main.js"></script>
    <script src="../../js/jquery.scrollex.min.js"></script>
    <script src="../../js/skel.min.js"></script>
    <script src="../../js/util.js"></script>
   
   
   
       <!-- Footer -->
    <footer id="footer">
        <div class="container">
            <ul class="icons">
                <li><a href="#" class="icon fa-twitter"><span class="label">Twitter</span></a></li>
                <li><a href="#" class="icon fa-facebook"><span class="label">Facebook</span></a></li>
                <li><a href="#" class="icon fa-instagram"><span class="label">Instagram</span></a></li>
                <li><a href="#" class="icon fa-envelope-o"><span class="label">Email</span></a></li>
            </ul>
        </div>
        <div class="copyright">
            &copy;2021 - La Tiendita. All rights reserved.- Visitanos en Calle ARCE
        </div>
    </footer>
</asp:Content>

