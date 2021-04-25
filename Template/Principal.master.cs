using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Template_Principal : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*if (this.Session["USUARIO"] == null)
        {
            Response.Redirect("~/webformsADM/LOGIN/Login.aspx");
        }
        else
        {
            string sess = Session["USUARIO"].ToString();
            Label1.Text = sess;
        }
        */
    }

    protected void CerrarSesion(object sender, EventArgs e)
    {
        //      Remove[] o Abandon()
        Session.Clear();
        Response.Redirect("~/webformsADM/LOGIN/Login.aspx");
    }
}
