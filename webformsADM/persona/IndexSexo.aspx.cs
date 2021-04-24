using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Vistas_IndexSexo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        LinkButton btnEliminar = (LinkButton)sender;
        int ID_SEXO = Convert.ToInt32(btnEliminar.CommandArgument);
        SEXO_BLL.Borrar(ID_SEXO);
        GridView1.DataBind();
    }

    protected void btnActualizar_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/webformsADM/persona/ManttoSexo.aspx");
    }

    protected void btnNuevo_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/webformsADM/persona/ManttoSexo.aspx");
    }
}