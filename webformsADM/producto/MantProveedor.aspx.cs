using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class webformsADM_MantProveedor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string idProv = Request.QueryString["ID_PROVEEDOR"];
        if (!IsPostBack)
        {
            if (idProv != null)
            {
                PROVEEDOR_DTO objPermisos = PROVEEDOR_BLL.MostrarID(Convert.ToInt32(idProv));
                if (objPermisos != null)
                {
                  
                    txtidprov.Text = "" + objPermisos.ID_PROVEEDOR;
                    txtNombreProv.Text = objPermisos.NOMBRE_PROVEEDOR;
                }
            }
            
        }

    }

    protected void Insertar_Click(object sender, EventArgs e)
    {
        int idprov = Convert.ToInt32(txtidprov.Text);
        string nombreprov = txtNombreProv.Text;

        try
        {
            PROVEEDOR_BLL.Insertar(idprov, nombreprov);
            Response.Redirect("~/webformsADM/producto/IndexProveedor.aspx");
        }
        catch(Exception ex)
        {

        }
    }

    protected void Actualizar_Click(object sender, EventArgs e)
    {
        int idprov = Convert.ToInt32(txtidprov.Text);
        string nombreprov = txtNombreProv.Text;
        try
        {
            PROVEEDOR_BLL.Actualizar(idprov, nombreprov);
            Response.Redirect("~/webformsADM/producto/IndexProveedor.aspx");
        }
        catch(Exception Exx)
        {

        }

    }
}