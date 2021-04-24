﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Template/PrincipClien.master" AutoEventWireup="true" CodeFile="indexPersona.aspx.cs" Inherits="Vistas_indexPersona" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <div class="container  body-content">
    <h2>Personas</h2>
    <br />
    <br />
     <asp:LinkButton ID="btnNuevo" OnClick="btnNuevo_Click" runat="server"> <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-plus-circle" viewBox="0 0 16 16">
              <path d="M8 15A7 7 0 1 1 8 1a7 7 0 0 1 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z"/>
              <path d="M8 4a.5.5 0 0 1 .5.5v3h3a.5.5 0 0 1 0 1h-3v3a.5.5 0 0 1-1 0v-3h-3a.5.5 0 0 1 0-1h3v-3A.5.5 0 0 1 8 4z"/>
              </svg> Nueva Persona</asp:LinkButton>
     <br />
     <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="odsPersona">
        <Columns>
            <asp:BoundField DataField="ID_PERSONA" HeaderText="ID_PERSONA" SortExpression="ID_PERSONA" />
            <asp:BoundField DataField="PRIMER_NOMBRE_PERSONA" HeaderText="PRIMER_NOMBRE_PERSONA" SortExpression="PRIMER_NOMBRE_PERSONA" />
            <asp:BoundField DataField="SEGUNDO_NOMBRE_PERSONA" HeaderText="SEGUNDO_NOMBRE_PERSONA" SortExpression="SEGUNDO_NOMBRE_PERSONA" />
            <asp:BoundField DataField="PRIMER_APELLIDO_PERSONA" HeaderText="PRIMER_APELLIDO_PERSONA" SortExpression="PRIMER_APELLIDO_PERSONA" />
            <asp:BoundField DataField="SEGUNDO_APELLIDO_PERSONA" HeaderText="SEGUNDO_APELLIDO_PERSONA" SortExpression="SEGUNDO_APELLIDO_PERSONA" />
            <asp:BoundField DataField="FECHA_NACIMIENTO_PERSONA" HeaderText="FECHA_NACIMIENTO_PERSONA" SortExpression="FECHA_NACIMIENTO_PERSONA" />
            <asp:BoundField DataField="NUMERO_IDENTIDAD_PERSONA" HeaderText="NUMERO_IDENTIDAD_PERSONA" SortExpression="NUMERO_IDENTIDAD_PERSONA" />
            <asp:BoundField DataField="DIRECCION_RESIDENCIA_PERSONA" HeaderText="DIRECCION_RESIDENCIA_PERSONA" SortExpression="DIRECCION_RESIDENCIA_PERSONA" />
            <asp:BoundField DataField="ID_CIUDAD_RESIDENCIA_PERSONA" HeaderText="ID_CIUDAD_RESIDENCIA_PERSONA" SortExpression="ID_CIUDAD_RESIDENCIA_PERSONA" />
            <asp:BoundField DataField="ID_SEXO_PERSONA" HeaderText="ID_SEXO_PERSONA" SortExpression="ID_SEXO_PERSONA" />
        
        <asp:TemplateField>
            <ItemTemplate>
                <asp:LinkButton ID="btnEliminar" OnClick="btnEliminar_Click" CommandArgument='<%#Eval("ID_PERSONA") %>' runat="server"> <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-trash" viewBox="0 0 16 16">
                    <path d="M5.5 5.5A.5.5 0 0 1 6 6v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm2.5 0a.5.5 0 0 1 .5.5v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm3 .5a.5.5 0 0 0-1 0v6a.5.5 0 0 0 1 0V6z"/>
                    <path fill-rule="evenodd" d="M14.5 3a1 1 0 0 1-1 1H13v9a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2V4h-.5a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1H6a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1h3.5a1 1 0 0 1 1 1v1zM4.118 4L4 4.059V13a1 1 0 0 0 1 1h6a1 1 0 0 0 1-1V4.059L11.882 4H4.118zM2.5 3V2h11v1h-11z"/>
                    </svg> Eliminar</asp:LinkButton>
            </ItemTemplate>
        </asp:TemplateField>

        <asp:TemplateField>
            <ItemTemplate>
                <asp:HyperLink NavigateUrl='<%#"~/webformsADM/persona/ManttoPersona.aspx?ID_PERSONA="+Eval("ID_PERSONA")%>' runat="server"> <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-pencil" viewBox="0 0 16 16">
                    <path d="M12.146.146a.5.5 0 0 1 .708 0l3 3a.5.5 0 0 1 0 .708l-10 10a.5.5 0 0 1-.168.11l-5 2a.5.5 0 0 1-.65-.65l2-5a.5.5 0 0 1 .11-.168l10-10zM11.207 2.5L13.5 4.793 14.793 3.5 12.5 1.207 11.207 2.5zm1.586 3L10.5 3.207 4 9.707V10h.5a.5.5 0 0 1 .5.5v.5h.5a.5.5 0 0 1 .5.5v.5h.293l6.5-6.5zm-9.761 5.175l-.106.106-1.528 3.821 3.821-1.528.106-.106A.5.5 0 0 1 5 12.5V12h-.5a.5.5 0 0 1-.5-.5V11h-.5a.5.5 0 0 1-.468-.325z"/>
                    </svg> Editar</asp:HyperLink>
            </ItemTemplate>
        </asp:TemplateField>
        </Columns>

     </asp:GridView>
     <asp:ObjectDataSource ID="odsPersona" runat="server" SelectMethod="MostrarTodos" TypeName="PERSONA_BLL"></asp:ObjectDataSource>
 </div>
</asp:Content>
