using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UBICACION_IndexCiudad : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnNuevo_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/webformsADM/UBICACION/ManttoCiudad.aspx");
    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        LinkButton btnEliminarDepar = (LinkButton)sender;
        int ID_DEPARTAMENTO = Convert.ToInt32(btnEliminarDepar.CommandArgument);
        CIUDAD_BLL.Borrar(ID_DEPARTAMENTO);
        GridView1.DataBind();
    }

}