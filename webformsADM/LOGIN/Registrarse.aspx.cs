using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LOGIN_Registrarse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string idPprod = Request.QueryString["ID_USUARIO"];
        if (!IsPostBack)
        {
            if (idPprod != null)
            {
                USUARIO_DTO objPermisos = USUARIO_BLL.MostrarID(Convert.ToInt32(idPprod));
                if (objPermisos != null)
                {
                    txtCodUser.Text = "" + objPermisos.ID_PERSONA_USUARIO;
                    txtNom.Text = "" + objPermisos.NOMBRE_USUARIO;
                    txtPass.Text = "" + objPermisos.CONTRASENA_USUARIO;
                }
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //Persona 
        int ID_PERSONA = Convert.ToInt32(txtCodUser.Text);
        string PRIMER_NOMBRE_PERSONA = txt_PRIMER_NOMBRE_PERSONA.Text;
        string SEGUNDO_NOMBRE_PERSONA = txt_SEGUNDO_NOMBRE_PERSONA.Text;
        string PRIMER_APELLIDO_PERSONA = txt_PRIMER_APELLIDO_PERSONA.Text;
        string SEGUNDO_APELLIDO_PERSONA = txt_SEGUNDO_APELLIDO_PERSONA.Text;
        DateTime FECHA_NACIMIENTO_PERSONA = DateTime.Parse(txt_FECHA_NACIMIENTO_PERSONA.Text);
        string NUMERO_IDENTIDAD_PERSONA = txt_NUMERO_IDENTIDAD_PERSONA.Text;
        string DIRECCION_RESIDENCIA_PERSONA = txt_DIRECCION_RESIDENCIA_PERSONA.Text;
        int ID_CIUDAD_RESIDENCIA_PERSONA = Convert.ToInt32(DropDownList1.SelectedItem.Value);
        int ID_SEXO_PERSONA = Convert.ToInt32(DropDownList2.SelectedItem.Value);

        //Usuario
        int idUser = Convert.ToInt32(txtCodUser.Text);
        string nom = txtNom.Text;
        byte[] pass = System.Text.Encoding.ASCII.GetBytes(Encriptar.Encrip(txtPass.Text));
        int idtipouser = 3;
        int idpersona = Convert.ToInt32(txtCodUser.Text);
        //Usuario Rol BD
        int idrolbd = 2;
        //Usuario Rol servidor
        int idrolserver = 2;

        try
        {
            PERSONA_BLL.Insertar(ID_PERSONA, PRIMER_NOMBRE_PERSONA, SEGUNDO_NOMBRE_PERSONA, PRIMER_APELLIDO_PERSONA,
        SEGUNDO_APELLIDO_PERSONA, FECHA_NACIMIENTO_PERSONA, NUMERO_IDENTIDAD_PERSONA, DIRECCION_RESIDENCIA_PERSONA,
        ID_CIUDAD_RESIDENCIA_PERSONA, ID_SEXO_PERSONA);

            /*USUARIO_BLL.Insertar(idUser, nom, pass, idtipouser, idpersona);
            UR_BD_BLL.Insertar(idUser, idrolbd);
            URS_BLL.Insertar(idUser, idrolserver);*/

            Response.Redirect("~webformsADM/LOGIN/Login.aspx");
        }
        catch (Exception ex) { }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        /*
        //Usuario
        int idUser = Convert.ToInt32(txtCodUser.Text);
        string nom = txtNom.Text;
        byte[] pass = System.Text.Encoding.ASCII.GetBytes(Encriptar.Encrip(txtPass.Text));
        int idtipouser = int.Parse(tipo_user.SelectedItem.Value);
        int idpersona = int.Parse(persona.SelectedItem.Value);
        //Usuario Rol BD
        int idrolbd = int.Parse(rol_bd.SelectedItem.Value);
        //Usuario Rol servidor
        int idrolserver = int.Parse(rol_server.SelectedItem.Value);

        try
        {
            TIPO_USUARIO_BLL.Actualizar(idTipoUser, descrip);
            Response.Redirect("~/USUARIO/IndexUser.aspx");
        }
        catch (Exception ex) { }
        */
    }

}