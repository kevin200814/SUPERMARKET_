using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Vistas_ManttoCargoLaboral : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string idcargo = Request.QueryString["ID_CARGO_LABORAL"];
        if (!IsPostBack)
        {
            CARGOLABORAL_DTO objPermisos = CARGOLABORAL_BLL.MostrarID(Convert.ToInt32(idcargo));
            if (objPermisos != null)
            {
                txt_ID_CARGO_LABORAL.Text = "" + objPermisos.ID_CARGO_LABORAL;
                txt_CARGO_LABORAL.Text = objPermisos.CARGO_LABORAL;
                txt_DESCRIPCION_CARGO_LABORAL.Text = objPermisos.DESCRIPCION_CARGO_LABORAL;
                txt_SALARIO_MENSUAL_CARGO_LABORAL.Text = "" + objPermisos.SALARIO_MENSUAL_CARGO_LABORAL;
            }

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int ID_CARGO_LABORAL = Convert.ToInt32(txt_ID_CARGO_LABORAL.Text);
        string CARGO_LABORAL = txt_CARGO_LABORAL.Text;
        string DESCRIPCION_CARGO_LABORAL = txt_DESCRIPCION_CARGO_LABORAL.Text;
        double SALARIO_MENSUAL_CARGO_LABORAL = Convert.ToDouble(txt_SALARIO_MENSUAL_CARGO_LABORAL.Text);
        try
        {
            CARGOLABORAL_BLL.Insertar(ID_CARGO_LABORAL, CARGO_LABORAL, DESCRIPCION_CARGO_LABORAL, SALARIO_MENSUAL_CARGO_LABORAL);
            Response.Redirect("~/webformsADM/persona/IndexCargoLaboral.aspx");
        }
        catch (Exception ex)
        {

        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        int ID_CARGO_LABORAL = Convert.ToInt32(txt_ID_CARGO_LABORAL.Text);
        string CARGO_LABORAL = txt_CARGO_LABORAL.Text;
        string DESCRIPCION_CARGO_LABORAL = txt_DESCRIPCION_CARGO_LABORAL.Text;
        double SALARIO_MENSUAL_CARGO_LABORAL = Convert.ToDouble(txt_SALARIO_MENSUAL_CARGO_LABORAL.Text);
        try
        {
            CARGOLABORAL_BLL.Actualizar(ID_CARGO_LABORAL, CARGO_LABORAL, DESCRIPCION_CARGO_LABORAL, SALARIO_MENSUAL_CARGO_LABORAL);
            Response.Redirect("~/webformsADM/persona/IndexCargoLaboral.aspx");
        }
        catch (Exception ex)
        {

        }
    }
}