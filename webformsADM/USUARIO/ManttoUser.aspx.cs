using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class USUARIO_ManttoUser : System.Web.UI.Page
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
            USUARIO_BLL.Insertar(idUser, nom, pass, idtipouser, idpersona);
            UR_BD_BLL.Insertar(idUser, idrolbd);
            URS_BLL.Insertar(idUser, idrolserver);
            Response.Redirect("~/USUARIO/IndexUsuarios.aspx");
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