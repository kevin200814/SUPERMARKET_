using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Vistas_ManttoPersona : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string idpersona = Request.QueryString["ID_PERSONA"];
        if (!IsPostBack)
        {
            PERSONA_DTO objPermisos = PERSONA_BLL.MostrarID(Convert.ToInt32(idpersona));
            if (objPermisos != null)
            {
                txt_ID_PERSONA.Text = "" + objPermisos.ID_PERSONA;
                txt_PRIMER_NOMBRE_PERSONA.Text = objPermisos.PRIMER_NOMBRE_PERSONA;
                txt_SEGUNDO_NOMBRE_PERSONA.Text = objPermisos.SEGUNDO_NOMBRE_PERSONA;
                txt_PRIMER_APELLIDO_PERSONA.Text = objPermisos.PRIMER_APELLIDO_PERSONA;
                txt_SEGUNDO_APELLIDO_PERSONA.Text = objPermisos.SEGUNDO_APELLIDO_PERSONA;
                txt_FECHA_NACIMIENTO_PERSONA.Text = "" + objPermisos.FECHA_NACIMIENTO_PERSONA;
                txt_NUMERO_IDENTIDAD_PERSONA.Text = objPermisos.NUMERO_IDENTIDAD_PERSONA;
                txt_DIRECCION_RESIDENCIA_PERSONA.Text = objPermisos.DIRECCION_RESIDENCIA_PERSONA;
                DropDownList1.SelectedItem.Value = "" + objPermisos.ID_CIUDAD_RESIDENCIA_PERSONA;
                DropDownList2.SelectedItem.Value = "" + objPermisos.ID_SEXO_PERSONA;


            }

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int ID_PERSONA = Convert.ToInt32(txt_ID_PERSONA.Text);
        string PRIMER_NOMBRE_PERSONA = txt_PRIMER_NOMBRE_PERSONA.Text;
        string SEGUNDO_NOMBRE_PERSONA = txt_SEGUNDO_NOMBRE_PERSONA.Text;
        string PRIMER_APELLIDO_PERSONA = txt_PRIMER_APELLIDO_PERSONA.Text;
        string SEGUNDO_APELLIDO_PERSONA = txt_SEGUNDO_APELLIDO_PERSONA.Text;
        DateTime FECHA_NACIMIENTO_PERSONA = DateTime.Parse(txt_FECHA_NACIMIENTO_PERSONA.Text);
        string NUMERO_IDENTIDAD_PERSONA = txt_NUMERO_IDENTIDAD_PERSONA.Text;
        string DIRECCION_RESIDENCIA_PERSONA = txt_DIRECCION_RESIDENCIA_PERSONA.Text;
        int ID_CIUDAD_RESIDENCIA_PERSONA = Convert.ToInt32(DropDownList1.SelectedItem.Value);
        int ID_SEXO_PERSONA = Convert.ToInt32(DropDownList2.SelectedItem.Value);
        try
        {
            PERSONA_BLL.Insertar(ID_PERSONA, PRIMER_NOMBRE_PERSONA, SEGUNDO_NOMBRE_PERSONA, PRIMER_APELLIDO_PERSONA,
        SEGUNDO_APELLIDO_PERSONA, FECHA_NACIMIENTO_PERSONA, NUMERO_IDENTIDAD_PERSONA, DIRECCION_RESIDENCIA_PERSONA,
        ID_CIUDAD_RESIDENCIA_PERSONA, ID_SEXO_PERSONA);
            Response.Redirect("~/webformsADM/persona/IndexPersona.aspx");
        }
        catch (Exception ex)
        {

        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        int ID_PERSONA = Convert.ToInt32(txt_ID_PERSONA.Text);
        string PRIMER_NOMBRE_PERSONA = txt_PRIMER_NOMBRE_PERSONA.Text;
        string SEGUNDO_NOMBRE_PERSONA = txt_SEGUNDO_NOMBRE_PERSONA.Text;
        string PRIMER_APELLIDO_PERSONA = txt_PRIMER_APELLIDO_PERSONA.Text;
        string SEGUNDO_APELLIDO_PERSONA = txt_SEGUNDO_APELLIDO_PERSONA.Text;
        DateTime FECHA_NACIMIENTO_PERSONA = DateTime.ParseExact(txt_FECHA_NACIMIENTO_PERSONA.Text, "yyyy/MM/dd", null);
        string NUMERO_IDENTIDAD_PERSONA = txt_NUMERO_IDENTIDAD_PERSONA.Text;
        string DIRECCION_RESIDENCIA_PERSONA = txt_DIRECCION_RESIDENCIA_PERSONA.Text;
        int ID_CIUDAD_RESIDENCIA_PERSONA = Convert.ToInt32(DropDownList1.SelectedItem.Value);
        int ID_SEXO_PERSONA = Convert.ToInt32(DropDownList2.SelectedItem.Value);
        try
        {
            PERSONA_BLL.Actualizar(ID_PERSONA, PRIMER_NOMBRE_PERSONA, SEGUNDO_NOMBRE_PERSONA, PRIMER_APELLIDO_PERSONA,
        SEGUNDO_APELLIDO_PERSONA, FECHA_NACIMIENTO_PERSONA, NUMERO_IDENTIDAD_PERSONA, DIRECCION_RESIDENCIA_PERSONA,
        ID_CIUDAD_RESIDENCIA_PERSONA, ID_SEXO_PERSONA);
            Response.Redirect("~/webformsADM/persona/IndexPersona.aspx");
        }
        catch (Exception ex)
        {

        }
    }
}