using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class USUARIO_IndexTipoUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        LinkButton btnEliminar = (LinkButton)sender;
        int ID_TIPO_USUARIO = Convert.ToInt32(btnEliminar.CommandArgument);
        TIPO_USUARIO_BLL.Borrar(ID_TIPO_USUARIO);
        GridView1.DataBind();
    }

    protected void btnNuevo_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/webformsADM/USUARIO/ManttoTipoUser.aspx");
    }

}