using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class IndexPais : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //Botones de acción de Pais
    protected void btnEliminarPais_Click(object sender, EventArgs e)
    {
        LinkButton btnEliminarPais = (LinkButton)sender;
        int ID_PAIS = Convert.ToInt32(btnEliminarPais.CommandArgument);
        PAIS_BLL.Borrar(ID_PAIS);
        GridView1.DataBind();
    }

    protected void btnNuevoPais_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/webformsADM/UBICACION/ManttoPais.aspx");
    }

}