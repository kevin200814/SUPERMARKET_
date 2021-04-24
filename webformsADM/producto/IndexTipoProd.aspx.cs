using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class webformsADM_IndexTipoProd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnNuevo_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/webformsADM/producto/ManttoTipoProd.aspx");
        
    }



    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        LinkButton btnEliminar = (LinkButton)sender;
        int ID_TIPO_PRODUCTO = Convert.ToInt32(btnEliminar.CommandArgument);
        TIPROD_BLL.Borrar(ID_TIPO_PRODUCTO);
        GridView1.DataBind();
    }
}