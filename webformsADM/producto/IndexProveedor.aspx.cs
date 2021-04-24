using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class webformsADM_IndexProveedor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnNuevo_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/webformsADM/producto/MantProveedor.aspx");
    }

    protected void BtnEliminar_Click(object sender, EventArgs e)
    {
        LinkButton BtnEliminar = (LinkButton)sender;
        int ID_PROVEEDOR = Convert.ToInt32(BtnEliminar.CommandArgument);
        PROVEEDOR_BLL.Borrar(ID_PROVEEDOR);
        GridView1.DataBind();
    }

   
}