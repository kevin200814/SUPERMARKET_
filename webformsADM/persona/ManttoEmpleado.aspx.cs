using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Vistas_ManttoEmpleado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string idempleado = Request.QueryString["ID_EMPLEADO"];
        if (!IsPostBack)
        {
            EMPLEADO_DTO objPermisos = EMPLEADO_BLL.MostrarID(Convert.ToInt32(idempleado));
            if (objPermisos != null)
            {
                txt_ID_EMPLEADO.Text = "" + objPermisos.ID_EMPLEADO;
                txt_FECHA_CONTRATACION_EMPLEADO.Text = "" + objPermisos.FECHA_CONTRATACION_EMPLEADO;
                txt_HORAS_LABORALES_MENSUALES_EMPLEADO.Text = "" + objPermisos.HORAS_LABORALES_MENSUALES_EMPLEADO;
                txt_ID_PERSONA_EMPLEADO.Text = "" + objPermisos.ID_PERSONA_EMPLEADO;
                DropDownList1.SelectedItem.Value = "" + objPermisos.ID_CARGO_LABORAL_EMPLEADO;
                DropDownList2.SelectedItem.Value = "" + objPermisos.ID_SUCURSAL_EMPLEADO;

            }

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int ID_EMPLEADO = Convert.ToInt32(txt_ID_EMPLEADO.Text);
        DateTime FECHA_CONTRATACION_EMPLEADO = DateTime.ParseExact(txt_FECHA_CONTRATACION_EMPLEADO.Text, "yyyy/MM/dd", null);
        int HORAS_LABORALES_MENSUALES_EMPLEADO = Convert.ToInt32(txt_HORAS_LABORALES_MENSUALES_EMPLEADO.Text);
        int ID_PERSONA_EMPLEADO = Convert.ToInt32(txt_ID_PERSONA_EMPLEADO.Text);
        int ID_CARGO_LABORAL_EMPLEADO = Convert.ToInt32(DropDownList1.SelectedItem.Value);
        int ID_SUCURSAL_EMPLEADO = Convert.ToInt32(DropDownList2.SelectedItem.Value);

        try
        {
            EMPLEADO_BLL.Insertar(ID_EMPLEADO, FECHA_CONTRATACION_EMPLEADO, HORAS_LABORALES_MENSUALES_EMPLEADO, ID_PERSONA_EMPLEADO,
        ID_CARGO_LABORAL_EMPLEADO, ID_SUCURSAL_EMPLEADO);
            Response.Redirect("~/webformsADM/persona/indexEmpleado.aspx");
        }
        catch (Exception ex)
        {
            
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        int ID_EMPLEADO = Convert.ToInt32(txt_ID_EMPLEADO.Text);
        DateTime FECHA_CONTRATACION_EMPLEADO = DateTime.ParseExact(txt_FECHA_CONTRATACION_EMPLEADO.Text, "yyyy/MM/dd", null);
        int HORAS_LABORALES_MENSUALES_EMPLEADO = Convert.ToInt32(txt_HORAS_LABORALES_MENSUALES_EMPLEADO.Text);
        int ID_PERSONA_EMPLEADO = Convert.ToInt32(txt_ID_PERSONA_EMPLEADO.Text);
        int ID_CARGO_LABORAL_EMPLEADO = Convert.ToInt32(DropDownList1.SelectedItem.Value);
        int ID_SUCURSAL_EMPLEADO = Convert.ToInt32(DropDownList2.SelectedItem.Value);
        try
        {
            EMPLEADO_BLL.Actualizar(ID_EMPLEADO, FECHA_CONTRATACION_EMPLEADO, HORAS_LABORALES_MENSUALES_EMPLEADO, ID_PERSONA_EMPLEADO,
        ID_CARGO_LABORAL_EMPLEADO, ID_SUCURSAL_EMPLEADO);
            Response.Redirect("~/webformsADM/persona/indexEmpleado.aspx");
        }
        catch (Exception ex)
        {

        }
    }
}