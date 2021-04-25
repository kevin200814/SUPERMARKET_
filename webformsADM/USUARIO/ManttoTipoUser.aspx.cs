using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class USUARIO_ManttoTipoUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string idPprod = Request.QueryString["ID_TIPO_USUARIO"];
        if (!IsPostBack)
        {
            if (idPprod != null)
            {
                TIPO_USUARIO_DTO objPermisos = TIPO_USUARIO_BLL.MostrarID(Convert.ToInt32(idPprod));
                if (objPermisos != null)
                {
                    txtCodTipoUser.Text = "" + objPermisos.ID_TIPO_USUARIO;
                    txtDescripTipoUser.Text = "" + objPermisos.DESCRIPCION_TIPO_USUARIO;
                }
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int idTipoUser = Convert.ToInt32(txtCodTipoUser.Text);
        string descrip = txtDescripTipoUser.Text;

        try
        {
            TIPO_USUARIO_BLL.Insertar(idTipoUser, descrip);
            Response.Redirect("~/USUARIO/IndexTipoUser.aspx");
        }
        catch (Exception ex) { }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        int idTipoUser = Convert.ToInt32(txtCodTipoUser.Text);
        string descrip = txtDescripTipoUser.Text;

        try
        {
            TIPO_USUARIO_BLL.Actualizar(idTipoUser, descrip);
            Response.Redirect("~/USUARIO/IndexTipoUser.aspx");
        }
        catch (Exception ex) { }
    }
}