using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LOGIN_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session.Clear();
    }

    protected void entrar(object sender, EventArgs e)
    {
        if(txtUsuario.Text != "" && txtContrasena.Text != "")
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SUPERMARKET;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from USUARIO where NOMBRE_USUARIO=@usuario and CONTRASENA_USUARIO=@pass", con);
            cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            byte[] pass = System.Text.Encoding.ASCII.GetBytes(Encriptar.Encrip(txtContrasena.Text));
            cmd.Parameters.AddWithValue("@pass", pass);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (dt.Rows.Count > 0)
            {
                Session["USUARIO"] = txtUsuario.Text;
                Response.Redirect("~/webformsADM/IndexPrincipal.aspx");
            }
        }
        else
        {
            Label1.Text = "¡Usuario o contraseña ivalidos!";
        }



        /**if (txtUsuario.Text == "admin" && txtContrasena.Text == "1234")
        {
            Session["usuario"] = txtUsuario.Text;
            Response.Redirect("principal.aspx");
        }
        if (txtUsuario.Text == "marcos" && txtContrasena.Text == "1234")
        {
            Session["usuario"] = txtUsuario.Text;
            Response.Redirect("Registrarse.aspx");
        }
        else
        {
            Console.Write("Usuario o contraseña equivocados");
        }*/

    }
}