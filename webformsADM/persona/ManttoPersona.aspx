<%@ Page Title="" Language="C#" MasterPageFile="~/Template/PrincipClien.master" AutoEventWireup="true" CodeFile="ManttoPersona.aspx.cs" Inherits="Vistas_ManttoPersona" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container body-content">
            <h2>Personas Registradas</h2>
            <div class="form-horizontal">
                <br />
            <div class="form-group">
             
                <div class="col-md-10">
                    <asp:Label ID="Label1" runat="server" Text="Label"> Codigo Persona</asp:Label>
                    <asp:TextBox runat="server" Height="32px" Width="944px" CssClass="form-control" Rows="5" ID="txt_ID_PERSONA" placeholder="Ingrese ID" TextMode="Number"></asp:TextBox>
                </div>
            </div>

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
    

            <div class="form-group">
                <br />
                <div class="col-md-10">
                    <asp:LinkButton ID="Button1" runat="server" class="btn btn-success" onClick="Button1_Click">
                        <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-plus-circle" viewBox="0 0 16 16">
                        <path d="M8 15A7 7 0 1 1 8 1a7 7 0 0 1 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z"/>
                        <path d="M8 4a.5.5 0 0 1 .5.5v3h3a.5.5 0 0 1 0 1h-3v3a.5.5 0 0 1-1 0v-3h-3a.5.5 0 0 1 0-1h3v-3A.5.5 0 0 1 8 4z"/>
                        </svg>Insertar
                    </asp:LinkButton>

                    <asp:LinkButton ID="Button2" runat="server" class="btn btn-warning" OnClick="Button2_Click">
                        <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-arrow-repeat" viewBox="0 0 16 16">
                        <path d="M11.534 7h3.932a.25.25 0 0 1 .192.41l-1.966 2.36a.25.25 0 0 1-.384 0l-1.966-2.36a.25.25 0 0 1 .192-.41zm-11 2h3.932a.25.25 0 0 0 .192-.41L2.692 6.23a.25.25 0 0 0-.384 0L.342 8.59A.25.25 0 0 0 .534 9z"/>
                        <path fill-rule="evenodd" d="M8 3c-1.552 0-2.94.707-3.857 1.818a.5.5 0 1 1-.771-.636A6.002 6.002 0 0 1 13.917 7H12.9A5.002 5.002 0 0 0 8 3zM3.1 9a5.002 5.002 0 0 0 8.757 2.182.5.5 0 1 1 .771.636A6.002 6.002 0 0 1 2.083 9H3.1z"/>
                        </svg>Actualizar
                    </asp:LinkButton>
                </div>
            </div>
        </div>
     </div>

</asp:Content>

