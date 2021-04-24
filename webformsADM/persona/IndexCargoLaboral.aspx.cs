using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Vistas_IndexCargoLaboral : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        LinkButton btnEliminar = (LinkButton)sender;
        int ID_CARGO_LABORAL = Convert.ToInt32(btnEliminar.CommandArgument);
        CARGOLABORAL_BLL.Borrar(ID_CARGO_LABORAL);
        GridView1.DataBind();
    }

    protected void btnActualizar_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/webformsADM/persona/ManttoCargoLaboral.aspx");
    }

    protected void btnNuevo_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/webformsADM/persona/ManttoCargoLaboral.aspx");
    }
}