using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Vistas_ManttoSexo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string idsexo = Request.QueryString["ID_SEXO"];
        if (!IsPostBack)
        {
            SEXO_DTO objPermisos = SEXO_BLL.MostrarID(Convert.ToInt32(idsexo));
            if (objPermisos != null)
            {
                txt_ID_SEXO.Text = "" + objPermisos.ID_SEXO;
                txt_SEXO.Text = objPermisos.SEXO;
            }

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int ID_SEXO = Convert.ToInt32(txt_ID_SEXO.Text);
        string SEXO = txt_SEXO.Text;
        try
        {
            SEXO_BLL.Insertar(ID_SEXO,SEXO);
            Response.Redirect("~/webformsADM/persona/IndexSexo.aspx");
        }
        catch (Exception ex)
        {

        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        int ID_SEXO = Convert.ToInt32(txt_ID_SEXO.Text);
        string SEXO = txt_SEXO.Text;
        try
        {
            SEXO_BLL.Actualizar(ID_SEXO, SEXO);
            Response.Redirect("~/webformsADM/persona/IndexSexo.aspx");
        }
        catch (Exception ex)
        {

        }
    }
}