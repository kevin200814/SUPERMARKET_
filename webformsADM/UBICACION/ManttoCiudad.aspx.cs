using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ManttoCiudad : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string idPprod = Request.QueryString["ID_CIUDAD"];
        if (!IsPostBack)
        {
            if (idPprod != null)
            {
                CIUDAD_DTO objPermisos = CIUDAD_BLL.MostrarID(Convert.ToInt32(idPprod));
                if (objPermisos != null)
                {
                    txtCodCiudad.Text = "" + objPermisos.ID_CIUDAD;
                    txtNomCiudad.Text = "" + objPermisos.NOMBRE_CIUDAD;
                    DropDownList1.Text = "" + objPermisos.ID_DEPARTAMENTO;
                }
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int idCiudad = Convert.ToInt32(txtCodCiudad.Text);
        string nombrCiudad = txtNomCiudad.Text;
        int idDepart = int.Parse(DropDownList1.SelectedItem.Value);


        try
        {
            CIUDAD_BLL.Insertar(idCiudad, nombrCiudad, idDepart);
            Response.Redirect("~/webformsADM/UBICACION/IndexCiudad.aspx");
        }
        catch (Exception ex) { }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        int idCiudad = Convert.ToInt32(txtCodCiudad.Text);
        string nombrCiudad = txtNomCiudad.Text;
        int idDepart = int.Parse(DropDownList1.SelectedItem.Value);

        try
        {
            CIUDAD_BLL.Actualizar(idCiudad, nombrCiudad, idDepart);
            Response.Redirect("~/webformsADM/UBICACION/IndexCiudad.aspx");
        }
        catch (Exception ex) { }
    }
}