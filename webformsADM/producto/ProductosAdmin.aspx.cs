using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class webformsADM_producto_ProductosAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        LinkButton btnEliminar = (LinkButton)sender;
        int ID_PRODUCTO = Convert.ToInt32(btnEliminar.CommandArgument);
        PRODUCTOS_BLL.Borrar(ID_PRODUCTO);
        GridView1.DataBind();
    }

    protected void btnNuevo_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/webformsADM/producto/EditarProductos.aspx");
    }
}