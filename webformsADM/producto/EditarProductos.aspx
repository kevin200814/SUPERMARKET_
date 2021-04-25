<%@ Page Title="" Language="C#" MasterPageFile="~/Template/PrincipClien.master" AutoEventWireup="true" CodeFile="EditarProductos.aspx.cs" Inherits="webformsADM_producto_EditarProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <div class="container body-content">
            <h2>Registrar Nuevo Producto</h2>
            <div class="form-horizontal">
                <br />
                 <div class="form-group">
                    ID Producto &nbsp;<asp:Image ID="Image1" runat="server" />
                    <br />
                    <div class="col-md-10">
                        
                        <asp:TextBox ID="TxtId" Height="32px" Width="944px" runat="server" placeholder="Ingrese el id del producto"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                   
                    <div class="col-md-10">
                        <asp:Label ID="Label1" runat="server" Text="Label"> Nombre Producto</asp:Label>
                        <asp:TextBox ID="txtNombre" Height="32px" Width="944px" runat="server" placeholder="Ingrese el Nombre del producto"></asp:TextBox>
                    </div>
                </div>

                  <div class="form-group">
                  
                    <div class="col-md-10">
                        <asp:Label ID="Label2" runat="server" Text="Label">  Fecha de Elaboracion</asp:Label>
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

                    <div class="form-group">
                   
                    <div class="col-md-10">
                        <asp:Label ID="Label3" runat="server" Text="Label">Fecha de Vencimiento</asp:Label>
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

                <div class="form-group">
                 
                    <div class="col-md-10">
                        <asp:Label ID="Label4" runat="server" Text="Label">Venta Producto</asp:Label>
                        <asp:TextBox ID="TxtVent" runat="server" placeholder="Ingrese la Venta del producto"></asp:TextBox>
                    </div>
                </div>

                 <div class="form-group">
                    
                    <div class="col-md-10">
                        <asp:Label ID="Label5" runat="server" Text="Label">Cantidad Producto</asp:Label>
                        <asp:TextBox ID="TxtCant" Height="32px" Width="944px" runat="server" placeholder="Ingrese la Cantidad del producto"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                    
                    <div class="col-md-10">
                            <asp:Label ID="Label6" runat="server" Text="Label">Selecciona el tipo de producto:</asp:Label>
                            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="odsproducto" DataTextField="TIPO_PRODUCTO" DataValueField="ID_TIPO_PRODUCTO"></asp:DropDownList>
                            <asp:ObjectDataSource ID="odsproducto" runat="server" SelectMethod="MostrarTodos" TypeName="TIPROD_BLL"></asp:ObjectDataSource>
                    </div>
                </div>

                <div class="form-group">
                    
                    <div class="col-md-10">
                      
                       
                        <asp:Label ID="Label10" runat="server" Text="Label">Selecciona Sucursal Producto</asp:Label>
                        <asp:DropDownList Height="32px" Width="944px" ID="DropDownList2" runat="server" DataSourceID="odsSucursal" DataTextField="NOMBRE_SUCURSAL" DataValueField="ID_SUCURSAL"></asp:DropDownList>
                        <asp:ObjectDataSource ID="odsSucursal" runat="server" SelectMethod="MostrarTodos" TypeName="SUCURSAL_BLL"></asp:ObjectDataSource>
                    </div>
                </div>

                 <div class="form-group">
                    
                    <div class="col-md-10">
                        
                            <asp:Label ID="Label7" runat="server" Text="Label">Precio del producto</asp:Label>
                            <asp:TextBox ID="TxtPrecio" Height="32px" Width="944px" runat="server" placeholder="$"></asp:TextBox>
                        
                    </div>
                </div>

                <div class="form-group">
                    
                    <div class="col-md-10">
                        <asp:Label ID="Label8" runat="server" Text="Label">Descripcion del producto</asp:Label>
                        <asp:TextBox ID="TxtDescripcion" Height="32px" Width="944px" runat="server" placeholder="Ingrese la descripcion del producto"></asp:TextBox>
                    </div>
                </div>

                  <div class="form-group">
                   
                    <div class="col-md-10">
                        <asp:Label ID="Label9" runat="server" Text="Label">Seleccione la Imagen</asp:Label>
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </div>
                </div>

                   <div class="form-group">
                    <div class="col-md-offset-2 col-md-10">
                        
                        <asp:LinkButton ID="BtnGuardar"  OnClick="BtnGuardar_Click" CssClass="btn btn-success" runat="server">Insertar</asp:LinkButton>
                        <asp:LinkButton ID="btnActualizar"  OnClick="btnActualizar_Click" CssClass="btn btn-success" runat="server">Editar</asp:LinkButton>
                       
                    </div>
                </div>
                </div>
</div>
</asp:Content>

