using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Vistas_ManttoTipoTelefono : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string idtelefono = Request.QueryString["ID_TIPO_TELFONO"];
        if (!IsPostBack)
        {
            TIPOTELEFONO_DTO objPermisos = TIPOTELEFONO_BLL.MostrarID(Convert.ToInt32(idtelefono));
            if (objPermisos != null)
            {
                txt_ID_TIPO_TELEFONO.Text = "" + objPermisos.ID_TIPO_TELEFONO;
                txt_TIPO_TELEFONO.Text = objPermisos.TIPO_TELEFONO;
                txt_DESCRIPCION_TIPO_TELEFONO.Text = objPermisos.DESCRIPCION_TIPO_TELEFONO;
            }

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int ID_TIPO_TELEFONO = Convert.ToInt32(txt_ID_TIPO_TELEFONO.Text);
        string TIPO_TELEFONO = txt_TIPO_TELEFONO.Text;
        string DESCRIPCION_TIPO_TELEFONO = txt_DESCRIPCION_TIPO_TELEFONO.Text;
        try
        {
            TIPOTELEFONO_BLL.Insertar(ID_TIPO_TELEFONO, TIPO_TELEFONO, DESCRIPCION_TIPO_TELEFONO);
            Response.Redirect("~/webformsADM/persona/IndexTipoTelefono.aspx");
        }
        catch (Exception ex)
        {

        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        int ID_TIPO_TELEFONO = Convert.ToInt32(txt_ID_TIPO_TELEFONO.Text);
        string TIPO_TELEFONO = txt_TIPO_TELEFONO.Text;
        string DESCRIPCION_TIPO_TELEFONO = txt_DESCRIPCION_TIPO_TELEFONO.Text;
        try
        {
            TIPOTELEFONO_BLL.Actualizar(ID_TIPO_TELEFONO, TIPO_TELEFONO, DESCRIPCION_TIPO_TELEFONO);
            Response.Redirect("~/webformsADM/persona/IndexTipoTelefono.aspx");
        }
        catch (Exception ex)
        {

        }
    }
}