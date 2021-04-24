using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class webformsADM_ManttoTipoProd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string idProd = Request.QueryString["ID_TIPO_PRODUCTO"];
        if (!IsPostBack)
        {
            if (idProd != null)
            {
                TIPROD_DTO objPermisos = TIPROD_BLL.MostrarID(Convert.ToInt32(idProd));
                if (objPermisos != null)
                {
                    txtCodProd.Text = "" + objPermisos.ID_TIPO_PRODUCTO;
                    txtNombreProd.Text = objPermisos.TIPO_PRODUCTO;
                    txtDescrip.Text = objPermisos.DESCRIPCION_TIPO_PRODUCTO;
                }
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //BOTON GUARDAR
        int idProd = Convert.ToInt32(txtCodProd.Text);
        string nombreProd = txtNombreProd.Text;
        string descProd = txtDescrip.Text;
        try
        {
            TIPROD_BLL.Insertar(idProd, nombreProd, descProd);
            Response.Redirect("~/webformsADM/producto/IndexTipoProd.aspx");
        }
        catch (Exception ex)
        {

        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //BOTON ACTUALIZAR
        int idProd = Convert.ToInt32(txtCodProd.Text);
        string nombreProd = txtNombreProd.Text;
        string descProd = txtDescrip.Text;
        try
        {
            TIPROD_BLL.Actualizar(idProd, nombreProd, descProd);
            Response.Redirect("~/webformsADM/producto/IndexTipoProd.aspx");

        }
        catch (Exception ex)
        {

        }
    }
}