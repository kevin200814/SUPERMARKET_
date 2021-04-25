<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Login.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="LOGIN_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <br />

    <div class="container">
        <div class="col-md-3"></div>
        <div class="col-md-6">

            <div class="panel panel-default">
                <div class="panel-heading">
                    <h2>Iniciar Sesión</h2>
                </div>
                <div class="panel-body">

                    <div class="form-group">
                        <br/>
                        <div class="col-m-12">                    
                            <asp:TextBox runat="server" id="txtUsuario" CssClass="form-control" type="text" placeholder="Usuario" required="required" data-error="Campo es requerido."></asp:TextBox>
                        </div>
                    </div>

                    <div class="form-group">
                        <br/>
                        <div class="col-m-12">      
                            <asp:TextBox runat="server" id="txtContrasena" CssClass="form-control" type="password" placeholder="Contraseña" required="required" data-error="Campo es requerido."></asp:TextBox>
                        </div>
                    </div>

                    <div class="form-group">
                        <br/>
                        <div class="col-m-12">
                            <asp:HyperLink runat="server" NavigateUrl="~/LOGIN/Registrarse.aspx">Registrarse</asp:HyperLink>
                            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                        </div>
                    </div>
                </div>
                <div class="panel-footer">
                    <asp:Button id="button" type="submit" runat="server" Text="Ingresar" class="btn btn-success" value="Submit" OnClick="entrar" />
                </div>
            </div>
        </div>
        <div class="col-md-3"></div>
    </div>

</asp:Content>

