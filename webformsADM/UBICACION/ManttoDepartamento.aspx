<%@ Page Title="" Language="C#" MasterPageFile="~/Template/PrincipClien.master" AutoEventWireup="true" CodeFile="ManttoDepartamento.aspx.cs" Inherits="ManttoDepartamento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

   <div class="container body-content">
            <h2>Departamentos</h2>
            <br />
            <div class="form-horizontal">
               
                <div class="col-m-10">
                 <asp:Label ID="Label1" runat="server" Text="Label">Id departamento</asp:Label>
                    <asp:TextBox runat="server"  Height="32px" Width="944px" CssClass="form-control" Rows="5" ID="txtCodDepartamento" placeholder="Ingrese el ID"></asp:TextBox>
                </div>
            </div>
            <br />
            <div class="form-group">
                
                <div class="col-m-10">
                    <asp:Label ID="Label2" runat="server" Text="Label">Nombre departamento</asp:Label>
                    <asp:TextBox runat="server"  Height="32px" Width="944px" CssClass="form-control" Rows="5" ID="txtDepartaNom" placeholder="Ingrese el nombre del departamento"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <br/>
                <asp:Label ID="Label3" runat="server" Text="Label">Pais al que pertenece</asp:Label>
                <asp:DropDownList ID="DropDownListPais"  Height="32px" Width="944px" runat="server" DataSourceID="odsPais" DataTextField="NOMBRE_PAIS" DataValueField="ID_PAIS">
                </asp:DropDownList>
                <asp:ObjectDataSource ID="odsPais"   runat="server" SelectMethod="MostrarTodos" TypeName="PAIS_BLL"></asp:ObjectDataSource>
                
            </div>

        <br />

            <asp:LinkButton ID="Button1" runat="server" CssClass="btn btn-success" OnClick="Button1_Click">
                <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-hammer" viewBox="0 0 16 16">
                    <path d="M9.972 2.508a.5.5 0 0 0-.16-.556l-.178-.129a5.009 5.009 0 0 0-2.076-.783C6.215.862 4.504 1.229 2.84 3.133H1.786a.5.5 0 0 0-.354.147L.146 4.567a.5.5 0 0 0 0 .706l2.571 2.579a.5.5 0 0 0 .708 0l1.286-1.29a.5.5 0 0 0 .146-.353V5.57l8.387 8.873A.5.5 0 0 0 14 14.5l1.5-1.5a.5.5 0 0 0 .017-.689l-9.129-8.63c.747-.456 1.772-.839 3.112-.839a.5.5 0 0 0 .472-.334z"/></svg>Insertar
            </asp:LinkButton>
            <asp:LinkButton ID="Button2" runat="server" CssClass="btn btn-warning" OnClick="Button2_Click">
                <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-pencil" viewBox="0 0 16 16">
                    <path d="M12.146.146a.5.5 0 0 1 .708 0l3 3a.5.5 0 0 1 0 .708l-10 10a.5.5 0 0 1-.168.11l-5 2a.5.5 0 0 1-.65-.65l2-5a.5.5 0 0 1 .11-.168l10-10zM11.207 2.5L13.5 4.793 14.793 3.5 12.5 1.207 11.207 2.5zm1.586 3L10.5 3.207 4 9.707V10h.5a.5.5 0 0 1 .5.5v.5h.5a.5.5 0 0 1 .5.5v.5h.293l6.5-6.5zm-9.761 5.175l-.106.106-1.528 3.821 3.821-1.528.106-.106A.5.5 0 0 1 5 12.5V12h-.5a.5.5 0 0 1-.5-.5V11h-.5a.5.5 0 0 1-.468-.325z"/>
                </svg>Actualizar
            </asp:LinkButton>
        </div>

     
    <br />
    <br />
    <br />
    <br />

</asp:Content>

