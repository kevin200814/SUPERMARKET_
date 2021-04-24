using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UBICACION_IndexSucursal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnNuevo_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/webformsADM/UBICACION/ManttoSucursal.aspx");
    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        LinkButton btnEliminarDepar = (LinkButton)sender;
        int ID_SUCURSAL = Convert.ToInt32(btnEliminarDepar.CommandArgument);
        SUCURSAL_BLL.Borrar(ID_SUCURSAL);
        GridView1.DataBind();
    }

}