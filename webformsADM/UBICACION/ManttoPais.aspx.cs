using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ManttoPais : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string idPprod = Request.QueryString["ID_PAIS"];
        if (!IsPostBack)
        {
            if (idPprod != null)
            {
                PAIS_DTO objPermisos = PAIS_BLL.MostrarID(Convert.ToInt32(idPprod));
                if (objPermisos != null)
                {
                    txtCodPais.Text = "" + objPermisos.ID_PAIS;
                    txtPnombre.Text = "" + objPermisos.NOMBRE_PAIS;
                }
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int idPais = Convert.ToInt32(txtCodPais.Text);
        string nombrPais = txtPnombre.Text;

        try
        {
            PAIS_BLL.Insertar(idPais, nombrPais);
            Response.Redirect("~/webformsADM/UBICACION/IndexPais.aspx");
        }
        catch (Exception ex) { }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        int idPais = Convert.ToInt32(txtCodPais.Text);
        string nombrPais = txtPnombre.Text;

        try
        {
            PAIS_BLL.Actualizar(idPais, nombrPais);
            Response.Redirect("~/webformsADM/UBICACION/IndexPais.aspx");
        }
        catch (Exception ex) { }
    }
}