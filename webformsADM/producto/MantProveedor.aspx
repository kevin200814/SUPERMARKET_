<%@ Page Title="" Language="C#" MasterPageFile="~/Template/PrincipClien.master" AutoEventWireup="true" CodeFile="MantProveedor.aspx.cs" Inherits="webformsADM_MantProveedor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <div class="container body-content">
         <h2>Proveedores</h2>
      <br />
               <div class="form-horizontal">
                <div class="form-group">
                    <div class="col-md-10">
                           <asp:Label ID="Label2" runat="server" Text="Label">Id Proveedor</asp:Label>
                        <asp:TextBox  ID="txtidprov" CssClass="form-control"  Height="32px" Width="944px" Rows="5" runat="server" placeholder="Ingrese el ID" TextMode="Number"></asp:TextBox>
                    </div>
                </div>

            <div class="form-group">
                <br />
                <div class="col-md-10">
                       <asp:Label ID="Label1" runat="server" Text="Label"> Nombre Proveedor</asp:Label>
                <asp:TextBox ID="txtNombreProv" CssClass="form-control"  Height="32px" Width="944px" Rows="5"  runat="server" placeholder="Ingrese el Nombre del Proveedor"></asp:TextBox>
                </div>
            </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <br />
                <asp:LinkButton ID="Insertar" CssClass="btn btn-success" OnClick="Insertar_Click" runat="server">
                 <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-plus-square" viewBox="0 0 16 16">
                  <path d="M14 1a1 1 0 0 1 1 1v12a1 1 0 0 1-1 1H2a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1h12zM2 0a2 2 0 0 0-2 2v12a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V2a2 2 0 0 0-2-2H2z"/>
                  <path d="M8 4a.5.5 0 0 1 .5.5v3h3a.5.5 0 0 1 0 1h-3v3a.5.5 0 0 1-1 0v-3h-3a.5.5 0 0 1 0-1h3v-3A.5.5 0 0 1 8 4z"/>
                </svg> Insertar</asp:LinkButton>

                <asp:LinkButton ID="Actualizar" CssClass="btn btn-warning" OnClick="Actualizar_Click" runat="server">
                  <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-arrow-clockwise" viewBox="0 0 16 16">
                  <path fill-rule="evenodd" d="M8 3a5 5 0 1 0 4.546 2.914.5.5 0 0 1 .908-.417A6 6 0 1 1 8 2v1z"/>
                  <path d="M8 4.466V.534a.25.25 0 0 1 .41-.192l2.36 1.966c.12.1.12.284 0 .384L8.41 4.658A.25.25 0 0 1 8 4.466z"/>
                </svg> Actualizar</asp:LinkButton>
            </div>
        </div>
    </div>
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

