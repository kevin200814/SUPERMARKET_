using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ManttoDepartamento : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string idPprod = Request.QueryString["ID_DEPARTAMENTO"];
        if (!IsPostBack)
        {
            if (idPprod != null)
            {
                DEPARTAMENTO_DTO objPermisos = DEPARTAMENTO_BLL.MostrarID(Convert.ToInt32(idPprod));
                if (objPermisos != null)
                {
                    txtCodDepartamento.Text = "" + objPermisos.ID_DEPARTAMENTO;
                    txtDepartaNom.Text = "" + objPermisos.NOMBRE_DEPARTAMENTO;
                    DropDownListPais.Text = "" + objPermisos.ID_PAIS;
                }
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int idDepartamento = Convert.ToInt32(txtCodDepartamento.Text);
        string nombrDepart = txtDepartaNom.Text;
        int idPais = int.Parse(DropDownListPais.SelectedItem.Value); 


        try
        {
            DEPARTAMENTO_BLL.Insertar(idDepartamento, nombrDepart, idPais);
            Response.Redirect("~/webformsADM/UBICACION/IndexDepartamento.aspx");
        }
        catch (Exception ex) { }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        int idDepartamento = Convert.ToInt32(txtCodDepartamento.Text);
        string nombrDepart = txtDepartaNom.Text;
        int idPais = int.Parse(DropDownListPais.SelectedItem.Value);

        try
        {
            DEPARTAMENTO_BLL.Actualizar(idDepartamento, nombrDepart, idPais);
            Response.Redirect("~/webformsADM/UBICACION/IndexDepartamento.aspx");
        }
        catch (Exception ex) { }
    }
}