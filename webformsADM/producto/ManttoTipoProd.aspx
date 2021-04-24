<%@ Page Title="" Language="C#" MasterPageFile="~/Template/PrincipClien.master" AutoEventWireup="true" CodeFile="ManttoTipoProd.aspx.cs" Inherits="webformsADM_ManttoTipoProd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

       <div class="container body-content">
            <h2>Tipos de Productos</h2>
            <div class="form-horizontal">
                <br />
                <div class="form-group"> 
                    <div class="col-md-10">
                         <asp:Label ID="Label2" runat="server" Text="Label"> Codigo producto</asp:Label>
                        <asp:TextBox ID="txtCodProd" Height="32px" Width="944px" class="form-control" Rows="5" runat="server" placeholder="Ingrese el Nombre del producto" ></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-10">
                        <asp:Label ID="Label1" runat="server" Text="Label">Nombre del producto</asp:Label>
                        <asp:TextBox ID="txtNombreProd" Height="32px" Width="944px" Placeholder="Nombre del producto" class="form-control" Rows="5"   runat="server"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                   
                    <div class="col-md-10">
                        <asp:Label ID="Label3" runat="server" Text="Label">Descripción</asp:Label>
                        <asp:TextBox ID="txtDescrip" Width="944px" TextMode="Multiline"  Placeholder="Descripcion del producto" class="form-control" Rows="5"  runat="server"></asp:TextBox>
                    </div>
                </div>
               <div class="form-group">
                    <div class="col-md-offset-2 col-md-10">
                        <br />
                        <asp:linkbutton ID="Button1" Cssclass="btn btn-success" runat="server" Onclick="Button1_Click" ><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-plus-circle" viewBox="0 0 16 16">
                          <path d="M8 15A7 7 0 1 1 8 1a7 7 0 0 1 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z"/>
                          <path d="M8 4a.5.5 0 0 1 .5.5v3h3a.5.5 0 0 1 0 1h-3v3a.5.5 0 0 1-1 0v-3h-3a.5.5 0 0 1 0-1h3v-3A.5.5 0 0 1 8 4z"/>
                        </svg> Insertar</asp:linkbutton>

                        <asp:LinkButton runat="server" ID="Button2" Cssclass="btn btn-warning" OnClick="Button2_Click" ><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-pencil-square" viewBox="0 0 16 16">
                          <path d="M15.502 1.94a.5.5 0 0 1 0 .706L14.459 3.69l-2-2L13.502.646a.5.5 0 0 1 .707 0l1.293 1.293zm-1.75 2.456l-2-2L4.939 9.21a.5.5 0 0 0-.121.196l-.805 2.414a.25.25 0 0 0 .316.316l2.414-.805a.5.5 0 0 0 .196-.12l6.813-6.814z"/>
                          <path fill-rule="evenodd" d="M1 13.5A1.5 1.5 0 0 0 2.5 15h11a1.5 1.5 0 0 0 1.5-1.5v-6a.5.5 0 0 0-1 0v6a.5.5 0 0 1-.5.5h-11a.5.5 0 0 1-.5-.5v-11a.5.5 0 0 1 .5-.5H9a.5.5 0 0 0 0-1H2.5A1.5 1.5 0 0 0 1 2.5v11z"/>
                        </svg> Actualizar</asp:LinkButton>
                    </div>
                </div>
    </div>
    </div>
    <br />
    <br />
    <br />
    <br />
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

