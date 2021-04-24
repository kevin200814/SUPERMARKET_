using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class IndexDepartamento : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //Botones de acción de Departamento
    protected void btnNuevoDepartamento_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/webformsADM/UBICACION/ManttoDepartamento.aspx");
    }

    protected void btnEliminarDepartamento_Click(object sender, EventArgs e)
    {
        LinkButton btnEliminarDepar = (LinkButton)sender;
        int ID_DEPARTAMENTO = Convert.ToInt32(btnEliminarDepar.CommandArgument);
        DEPARTAMENTO_BLL.Borrar(ID_DEPARTAMENTO);
        GridView1.DataBind();
    }

}