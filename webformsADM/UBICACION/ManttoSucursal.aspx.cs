using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UBICACION_ManttoSucursal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string idPprod = Request.QueryString["ID_SUCURSAL"];
        if (!IsPostBack)
        {
            if (idPprod != null)
            {
                SUCURSAL_DTO objPermisos = SUCURSAL_BLL.MostrarID(Convert.ToInt32(idPprod));
                if (objPermisos != null)
                {
                    txtCodSucursal.Text = "" + objPermisos.ID_SUCURSAL;
                    txtNomSucursal.Text = "" + objPermisos.NOMBRE_SUCURSAL;
                    DropDownList1.Text = "" + objPermisos.ID_CIUDAD;
                }
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int idSucursal = Convert.ToInt32(txtCodSucursal.Text);
        string nombrSucursal = txtNomSucursal.Text;
        int idCiudad = int.Parse(DropDownList1.SelectedItem.Value);


        try
        {
            SUCURSAL_BLL.Insertar(idSucursal, nombrSucursal, idCiudad);
            Response.Redirect("~/webformsADM/UBICACION/IndexSucursal.aspx");
        }
        catch (Exception ex) { }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        int idSucursal = Convert.ToInt32(txtCodSucursal.Text);
        string nombrSucursal = txtNomSucursal.Text;
        int idCiudad = int.Parse(DropDownList1.SelectedItem.Value);

        try
        {
            SUCURSAL_BLL.Actualizar(idSucursal, nombrSucursal, idCiudad);
            Response.Redirect("~/webformsADM/UBICACION/IndexSucursal.aspx");
        }
        catch (Exception ex) { }
    }
}