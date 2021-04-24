<%@ Page Title="" Language="C#" MasterPageFile="~/Template/PrincipClien.master" AutoEventWireup="true" CodeFile="IndexTipoProd.aspx.cs" Inherits="webformsADM_IndexTipoProd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="container body-content">
          <h2>Tipos de Productos</h2>
           <br />
           <br />
            <p>
                
            <asp:LinkButton ID="btnNuevo" runat="server" Onclick="btnNuevo_Click"><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-plus-circle" viewBox="0 0 16 16">
              <path d="M8 15A7 7 0 1 1 8 1a7 7 0 0 1 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z"/>
              <path d="M8 4a.5.5 0 0 1 .5.5v3h3a.5.5 0 0 1 0 1h-3v3a.5.5 0 0 1-1 0v-3h-3a.5.5 0 0 1 0-1h3v-3A.5.5 0 0 1 8 4z"/>
             </svg>  Nuevo tipo de producto</asp:LinkButton>
           </p> 
           <br />
           <br />
   
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="odsproducto">
        <Columns>
            <asp:BoundField DataField="ID_TIPO_PRODUCTO" HeaderText="ID_TIPO_PRODUCTO" SortExpression="ID_TIPO_PRODUCTO" />
            <asp:BoundField DataField="TIPO_PRODUCTO" HeaderText="TIPO_PRODUCTO" SortExpression="TIPO_PRODUCTO" />
            <asp:BoundField DataField="DESCRIPCION_TIPO_PRODUCTO" HeaderText="DESCRIPCION_TIPO_PRODUCTO" SortExpression="DESCRIPCION_TIPO_PRODUCTO" />
       <asp:TemplateField>
           <ItemTemplate>
                <asp:LinkButton ID="btnEliminar" CommandArgument='<%#Eval("ID_TIPO_PRODUCTO") %>' Onclick="btnEliminar_Click" runat="server"><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-cart4" viewBox="0 0 16 16">
                <path d="M0 2.5A.5.5 0 0 1 .5 2H2a.5.5 0 0 1 .485.379L2.89 4H14.5a.5.5 0 0 1 .485.621l-1.5 6A.5.5 0 0 1 13 11H4a.5.5 0 0 1-.485-.379L1.61 3H.5a.5.5 0 0 1-.5-.5zM3.14 5l.5 2H5V5H3.14zM6 5v2h2V5H6zm3 0v2h2V5H9zm3 0v2h1.36l.5-2H12zm1.11 3H12v2h.61l.5-2zM11 8H9v2h2V8zM8 8H6v2h2V8zM5 8H3.89l.5 2H5V8zm0 5a1 1 0 1 0 0 2 1 1 0 0 0 0-2zm-2 1a2 2 0 1 1 4 0 2 2 0 0 1-4 0zm9-1a1 1 0 1 0 0 2 1 1 0 0 0 0-2zm-2 1a2 2 0 1 1 4 0 2 2 0 0 1-4 0z"/>
                </svg> Eliminar</asp:LinkButton>
            </ItemTemplate>
       </asp:TemplateField> 
       <asp:TemplateField>
            <ItemTemplate>
                <asp:HyperLink NavigateUrl='<%#"~/webformsADM/producto/ManttoTipoProd.aspx?ID_TIPO_PRODUCTO="+ Eval("ID_TIPO_PRODUCTO")%>' runat="server"><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-pencil-square" viewBox="0 0 16 16">
                <path d="M15.502 1.94a.5.5 0 0 1 0 .706L14.459 3.69l-2-2L13.502.646a.5.5 0 0 1 .707 0l1.293 1.293zm-1.75 2.456l-2-2L4.939 9.21a.5.5 0 0 0-.121.196l-.805 2.414a.25.25 0 0 0 .316.316l2.414-.805a.5.5 0 0 0 .196-.12l6.813-6.814z"/>
                <path fill-rule="evenodd" d="M1 13.5A1.5 1.5 0 0 0 2.5 15h11a1.5 1.5 0 0 0 1.5-1.5v-6a.5.5 0 0 0-1 0v6a.5.5 0 0 1-.5.5h-11a.5.5 0 0 1-.5-.5v-11a.5.5 0 0 1 .5-.5H9a.5.5 0 0 0 0-1H2.5A1.5 1.5 0 0 0 1 2.5v11z"/>
                </svg> Editar</asp:HyperLink>
            </ItemTemplate>
        </asp:TemplateField>
        </Columns>
      
    </asp:GridView>
    <asp:ObjectDataSource ID="odsproducto" runat="server" SelectMethod="MostrarTodos" TypeName="TIPROD_BLL"></asp:ObjectDataSource>
</div>
    <br />
    <br />
    


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

