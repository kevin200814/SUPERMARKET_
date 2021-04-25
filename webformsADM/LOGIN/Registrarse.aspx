<%@ Page Title="" Language="C#" MasterPageFile="~/Template/PrincipClien.master" AutoEventWireup="true" CodeFile="Registrarse.aspx.cs" Inherits="LOGIN_Registrarse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="container">
        <div class="col-md-8">
        <div class="panel panel-default">
        <div class="panel-heading">
            <h2>R E G I S T R A R S E</h2>
        </div>
        <div class="panel-body">

            <div class="form-group">
                <br />
                <div class="col-md-10">
                    <asp:Label ID="Label2" runat="server" Text="Label">Primer Nombre</asp:Label>
                    <asp:TextBox runat="server" Height="32px" Width="944px" CssClass="form-control" Rows="5" ID="txt_PRIMER_NOMBRE_PERSONA" placeholder="Ingrese Primer Nombre"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <br />
                <div class="col-md-10">
                    <asp:Label ID="Label3" runat="server" Text="Label">Segundo Nombre</asp:Label>
                    <asp:TextBox runat="server" Height="32px" Width="944px" CssClass="form-control" Rows="5" ID="txt_SEGUNDO_NOMBRE_PERSONA" placeholder="Ingrese Segundo Nombre"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <br />
                <div class="col-md-10">
                    <asp:Label ID="Label4" runat="server" Text="Label">Primer Apellido</asp:Label>
                    <asp:TextBox runat="server" Height="32px" Width="944px" CssClass="form-control" Rows="5" ID="txt_PRIMER_APELLIDO_PERSONA" placeholder="Ingrese Primer Apellido"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <br />
                <div class="col-md-10">
                    <asp:Label ID="Label5" runat="server" Text="Label">Segundo Apellido</asp:Label>
                    <asp:TextBox runat="server" Height="32px" Width="944px" CssClass="form-control" Rows="5" ID="txt_SEGUNDO_APELLIDO_PERSONA" placeholder="Ingrese Segundo Apellido"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <br />
                <div class="col-md-10">
                    <asp:Label ID="Label6" runat="server" Text="Label">Fecha de Nacimiento</asp:Label>
                    <asp:TextBox runat="server" Height="32px" Width="944px" CssClass="form-control" Rows="5" ID="txt_FECHA_NACIMIENTO_PERSONA" placeholder="Ingrese Fecha Nacimiento" TextMode="Date"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <br />
                <div class="col-md-10">
                    <asp:Label ID="Label7" runat="server" Text="Label">Numero de identidad</asp:Label>
                    <asp:TextBox runat="server" Height="32px" Width="944px" CssClass="form-control" Rows="5" ID="txt_NUMERO_IDENTIDAD_PERSONA" placeholder="Ingrese Numero Identidad"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <br />
                <div class="col-md-10">
                    <asp:Label ID="Label10" runat="server" Text="Label">Direccion de Residencia</asp:Label>
                    <asp:TextBox runat="server" Height="32px" Width="944px" CssClass="form-control" Rows="5" ID="txt_DIRECCION_RESIDENCIA_PERSONA" placeholder="Ingrese Residencia"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <br />
                <div class="col-md-10">
                    <asp:Label ID="Label8" runat="server" Text="Label">Ciudad de Residencia</asp:Label>
                    <asp:DropDownList ID="DropDownList1" Height="32px" Width="944px"  runat="server" DataSourceID="odsCiudad" DataTextField="NOMBRE_CIUDAD" DataValueField="ID_CIUDAD"></asp:DropDownList>
                    <asp:ObjectDataSource ID="odsCiudad" runat="server" SelectMethod="MostrarTodos" TypeName="CIUDAD_BLL"></asp:ObjectDataSource>
                    
                </div>
            </div>

            <div class="form-group">
                <br />
                <div class="col-md-10">
                    <asp:Label ID="Label9" runat="server" Text="Label">Sexo</asp:Label>
                    <asp:DropDownList ID="DropDownList2" runat="server" Height="32px" Width="944px" DataSourceID="odsSexo" DataTextField="SEXO" DataValueField="ID_SEXO"></asp:DropDownList>
                    <asp:ObjectDataSource ID="odsSexo" runat="server" SelectMethod="MostrarTodos" TypeName="SEXO_BLL"></asp:ObjectDataSource>
                  
                </div>
            </div>
            <br />
            <!-- User -->

            <div class="form-group">
                <br/>
                <div class="col-m-10">
                    <asp:Label ID="Label11" runat="server" Text="Label">ID</asp:Label>
                    <asp:TextBox runat="server" Height="32px" Width="944px" CssClass="form-control" Rows="5" ID="txtCodUser" placeholder="Ingrese el ID"></asp:TextBox>
                </div>
            </div>
            
            <div class="form-group">
                <br/>
                <div class="col-m-10">
                    <asp:Label ID="Label12" runat="server" Text="Label">Usuario</asp:Label>
                    <asp:TextBox runat="server" Height="32px" Width="944px" CssClass="form-control" Rows="5" ID="txtNom" placeholder="Ingrese el nombre usuario"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <br/>
                <div class="col-m-10">
                    <asp:Label ID="Label13" runat="server" Text="Label">Contraseña</asp:Label>
                    <asp:TextBox runat="server" Height="32px" Width="944px" CssClass="form-control" Rows="5" ID="txtPass" placeholder="Ingrese su contraseña" TextMode="Password"></asp:TextBox>
                </div>
            </div>

            
        </div>
        <div class="panel-footer">
            <asp:LinkButton ID="Button1" runat="server" CssClass="btn btn-success" OnClick="Button1_Click">
                Registrarse
            </asp:LinkButton>
        </div>
    </div>
    </div>
    </div>
    
     
    <br />
    <br />
    <br />
    <br />

</asp:Content>

