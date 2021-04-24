<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Login.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="webformsADM_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <link href="../css/Style.css" rel="stylesheet"/>
    
    <center>
        <div class="container ">
            <div class="rows">
                <div class="col-md-12 ">
                    <div class="caja">
                        <form id="form1" runat="server">
                       <div class="form-group ">
                           <label style="font-size:20px; font-family:'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif">Usuario</label><br />
                           <asp:TextBox ID="TextBox1" class="form-control in"  placeholder="Escriba su usuario" runat="server"></asp:TextBox>
                           <br />
                       </div>
                       <div class="form-group " >
                           <label style="font-size:20px "  font-family:'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif">Contraseña</label><br />
                           <asp:TextBox ID="TextBox2" class="form-control in" placeholder="Escriba su contraseña" runat="server" TextMode="Password"></asp:TextBox>
                           <br />
                       </div>
                       
                       <div class="col-md-12 text-center ">
                           
                           <asp:Button ID="Button1" class=" btn btn-block btn-primary " runat="server" Text="Login"></asp:Button>
                       </div>
                         <br /> 
                       <div class="form-group">
                           <p class="text-center">¿No tienes cuenta? <a href="#" >Registrate aqui</a></p>
                       </div>
                        <div class="form-group">
                           <p class="text-center"><a href="IndexPrincipal.aspx" >Volver a Inicio</a></p>
                       </div>
                  </form>
              </div>
                    </div>
                      
                </div>
            </div>
    </center>
           

        
           
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />      
</asp:Content>

