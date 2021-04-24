<%@ Page Title="" Language="C#" MasterPageFile="~/Template/PrincipClien.master" AutoEventWireup="true" CodeFile="EditarProductos.aspx.cs" Inherits="webformsADM_producto_EditarProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

 <h2>Registrar un Nuevo Producto</h2>


            <div class="form-horizontal">
                <hr />
               
                 <div class="form-group">
                    ID Producto &nbsp;<asp:Image ID="Image1" runat="server" />
                    <br />
                    <div class="col-md-10">
               
                        <asp:TextBox ID="TxtId" Height="32px" Width="944px" runat="server" placeholder="Ingrese el Id del producto"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="form-group">
                    
                    <div class="col-md-10">
                        <asp:Label ID="Label3" runat="server" Text="Label">Nombre del producto</asp:Label>
                        <asp:TextBox ID="txtNombre" Height="32px" Width="944px" runat="server" placeholder="Ingrese el Nombre del producto"></asp:TextBox>
                    </div>
                </div>
                <br />
                  <div class="form-group">
                  
                    <div class="col-md-10">
                        <asp:Label ID="Label4" runat="server" Text="Label">Fecha de elaboración del producto</asp:Label>
                        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px" OnSelectionChanged="Calendar1_SelectionChanged">
                            <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                            <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                            <OtherMonthDayStyle ForeColor="#999999" />
                            <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                            <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                            <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                            <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                            <WeekendDayStyle BackColor="#CCCCFF" />
                        </asp:Calendar>

                        <asp:TextBox ID="TextCalend1" runat="server" Height="16px" Width="239px"></asp:TextBox>
                    </div>
                </div>
                <br />
                    <div class="form-group">
                    
                    <div class="col-md-10">
                        <asp:Label ID="Label1" runat="server" Text="Label">Fecha de Vencimiento</asp:Label>
                        <asp:Calendar ID="Calendar2" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px" OnSelectionChanged="Calendar2_SelectionChanged">
                            <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                            <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                            <OtherMonthDayStyle ForeColor="#999999" />
                            <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                            <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                            <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                            <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                            <WeekendDayStyle BackColor="#CCCCFF" />
                        </asp:Calendar>

                        <asp:TextBox ID="TextCalend2" runat="server" Height="16px" Width="239px"></asp:TextBox>
                  </div>
                </div>
                <br />
                <div class="form-group">
                    
                    <div class="col-md-10">
                        <asp:Label ID="Label5" runat="server" Text="Label"> Venta Producto</asp:Label>
                        <asp:TextBox ID="TxtVent" Height="32px" Width="944px" runat="server" placeholder="Ingrese la venta del producto"></asp:TextBox>
                    </div>
                </div>
                <br />
                 <div class="form-group">
                    
                    <div class="col-md-10">
                        <asp:Label ID="Label6" runat="server" Text="Label">Cantidad Producto</asp:Label>
                        <asp:TextBox ID="TxtCant" Height="32px" Width="944px" runat="server" placeholder="Ingrese la cantidad del producto"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="form-group">
                   
                    <div class="col-md-10">
                      
                        <asp:Label ID="Label2" runat="server" Text="Label">Selecciona el tipo de producto:</asp:Label>
                            <asp:DropDownList ID="DropDownList1" Height="32px" Width="944px" runat="server" DataSourceID="odsTipoProducto" DataTextField="TIPO_PRODUCTO" DataValueField="ID_TIPO_PRODUCTO"></asp:DropDownList>
                             <asp:ObjectDataSource ID="odsTipoProducto" runat="server" SelectMethod="MostrarTodos" TypeName="TIPROD_BLL"></asp:ObjectDataSource>
                        </div>
                    
                </div>
                <br />
                <div class="form-group">
                    
                    <div class="col-md-10">
                    
                        <asp:Label ID="Label9" runat="server" Text="Label">Selecciona la sucursal del producto:</asp:Label>

                        <asp:DropDownList Height="32px" Width="944px" ID="DropDownList2" runat="server" DataSourceID="odsSucursal" DataTextField="NOMBRE_SUCURSAL" DataValueField="ID_SUCURSAL" ></asp:DropDownList>
                        <asp:ObjectDataSource ID="odsSucursal" runat="server" SelectMethod="MostrarTodos" TypeName="SUCURSAL_BLL"></asp:ObjectDataSource>
                    </div>
                </div>
                <br />
                 <div class="form-group">
                   
                    <div class="col-md-10">
                       
                            <asp:Label ID="Label7" runat="server" Text="Label"> Precio del producto</asp:Label>
                            <asp:TextBox ID="TxtPrecio" Height="32px" Width="944px" runat="server" placeholder="$"></asp:TextBox>
                       
                    </div>
                </div>
                <br />
                <div class="form-group">
  
                    <div class="col-md-10">
                        <asp:Label ID="Label8" runat="server" Text="Label">Descripcion del producto</asp:Label>
                        <asp:TextBox ID="TxtDescripcion" Height="32px" Width="944px" runat="server" placeholder="Ingrese la descripcion del producto"></asp:TextBox>
                    </div>
                </div>
                <br />
                  <div class="form-group">
         
                    <div class="col-md-10">
                        <asp:Label ID="Label10" runat="server" Text="Label">Selecciona la imagen</asp:Label>
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </div>
                </div>
                <br />
                   <div class="form-group">
                    <div class="col-md-offset-2 col-md-10">
                        <asp:LinkButton ID="BtnGuardar" OnClick="BtnGuardar_Click" CssClass="btn btn-success" runat="server"><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-plus-circle" viewBox="0 0 16 16">
                          <path d="M8 15A7 7 0 1 1 8 1a7 7 0 0 1 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z"/>
                          <path d="M8 4a.5.5 0 0 1 .5.5v3h3a.5.5 0 0 1 0 1h-3v3a.5.5 0 0 1-1 0v-3h-3a.5.5 0 0 1 0-1h3v-3A.5.5 0 0 1 8 4z"/>
                        </svg> Insertar</asp:LinkButton>
                        <asp:LinkButton ID="btnActualizar"  OnClick="btnActualizar_Click" Cssclass="btn btn-warning"  runat="server"> <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-pencil-square" viewBox="0 0 16 16">
                          <path d="M15.502 1.94a.5.5 0 0 1 0 .706L14.459 3.69l-2-2L13.502.646a.5.5 0 0 1 .707 0l1.293 1.293zm-1.75 2.456l-2-2L4.939 9.21a.5.5 0 0 0-.121.196l-.805 2.414a.25.25 0 0 0 .316.316l2.414-.805a.5.5 0 0 0 .196-.12l6.813-6.814z"/>
                          <path fill-rule="evenodd" d="M1 13.5A1.5 1.5 0 0 0 2.5 15h11a1.5 1.5 0 0 0 1.5-1.5v-6a.5.5 0 0 0-1 0v6a.5.5 0 0 1-.5.5h-11a.5.5 0 0 1-.5-.5v-11a.5.5 0 0 1 .5-.5H9a.5.5 0 0 0 0-1H2.5A1.5 1.5 0 0 0 1 2.5v11z"/>
                        </svg> Actualizar</asp:LinkButton>
                      
                    </div>
                </div>
                </div>

</asp:Content>

