using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class webformsADM_producto_EditarProductos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextCalend1.Text = Calendar1.SelectedDate.ToString();
        TextCalend2.Text = Calendar2.SelectedDate.ToString();
        string idprod = Request.QueryString["ID_PRODUCTO"];
        if (!IsPostBack)
        {
            if (idprod != null)
            {
                PRODUCTOS_DTO objpermisos = PRODUCTOS_BLL.MostrarID(Convert.ToInt32(idprod));
                if (objpermisos != null)
                {
                    TxtId.Text = "" + objpermisos.ID_PRODUCTO;
                    txtNombre.Text = "" + objpermisos.NOMBRE_PRODUCTO;
                    TextCalend1.Text = "" + objpermisos.FECHA_ELABORACION_PRODUCTO;
                    TextCalend2.Text = "" + objpermisos.FECHA_VENCIMIENTO_PRODUCTO;
                    TxtVent.Text = "" + objpermisos.VENTA_PRODUCTO;
                    TxtCant.Text = "" + objpermisos.CANTIDAD_PRODUCTO;
                    DropDownList1.Text = "" + objpermisos.ID_TIPO_PRODUCTO;
                    DropDownList2.Text = "" + objpermisos.ID_SUCURSAL_PRODUCTO;
                    TxtPrecio.Text = "" + objpermisos.PRECIO;
                    TxtDescripcion.Text = "" + objpermisos.DESCRIPCION_PRODUCTO;
                    Image1.ImageUrl = "../../img/" + objpermisos.IMG.ToString();
                }
            }
        }

    }

  
    protected void BtnGuardar_Click(object sender, EventArgs e)
    {

        string exten;
        int tamano;
        string nomIMG;
        //string formatfechaelab = TextCalend1.Text.ToString() + " 00:00:00";
        //string formatfechven = TextCalend2.Text.ToString() + " 00:00:00";

        int codprod = Convert.ToInt32(TxtId.Text);
        string nombreprod = txtNombre.Text;
        DateTime fechaelab = Convert.ToDateTime(TextCalend1.Text);
        DateTime fechaven = Convert.ToDateTime(TextCalend2.Text);
        double vent = Convert.ToDouble(TxtVent.Text);
        int cant = Convert.ToInt32(TxtCant.Text);
        int tiprod = Convert.ToInt32(DropDownList1.SelectedItem.Value);
        int sucprod = Convert.ToInt32(DropDownList2.SelectedItem.Value);
        double prec = Convert.ToDouble(TxtPrecio.Text);
        string descprod = TxtDescripcion.Text;

        if (FileUpload1.HasFile)
        {
            exten = System.IO.Path.GetExtension(FileUpload1.FileName);
            exten = exten.ToLower();
            tamano = FileUpload1.PostedFile.ContentLength;
            Response.Write(exten + "," + tamano);
            nomIMG = FileUpload1.FileName;

            FileUpload1.SaveAs(Server.MapPath("../../img/" + FileUpload1.FileName));

            try
            {
                PRODUCTOS_BLL.Insertar(codprod, nombreprod, fechaelab, fechaven, vent, cant, descprod, tiprod, sucprod, nomIMG, prec);
                Response.Redirect("~/webformsADM/producto/ProductosAdmin.aspx");
            }
            catch (Exception ex)
            {

            }

        }
        else
        {
            Response.Write("Seleccione una imagen");
        }


    }

    

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        TextCalend1.Text = Calendar1.SelectedDate.ToString();
        Calendar1.Visible = !Calendar1.Visible;
    }



    protected void Calendar2_SelectionChanged(object sender, EventArgs e)
    {
        TextCalend2.Text = Calendar2.SelectedDate.ToString();
        Calendar2.Visible = !Calendar2.Visible;
    }

   
    protected void btnActualizar_Click(object sender, EventArgs e)
    {

        string exten;
        int tamano;
        string nomIMG;
        //string formatfechaelab = TextCalend1.Text.ToString() + " 00:00:00";
        //string formatfechven = TextCalend2.Text.ToString() + " 00:00:00";

        int codprod = Convert.ToInt32(TxtId.Text);
        string nombreprod = txtNombre.Text;
        DateTime fechaelab = Convert.ToDateTime(TextCalend1.Text);
        DateTime fechaven = Convert.ToDateTime(TextCalend2.Text);
        double vent = Convert.ToDouble(TxtVent.Text);
        int cant = Convert.ToInt32(TxtCant.Text);
        int tiprod = Convert.ToInt32(DropDownList1.SelectedItem.Value);
        int sucprod = Convert.ToInt32(DropDownList1.SelectedItem.Value);
        double prec = Convert.ToDouble(TxtPrecio.Text);
        string descprod = TxtDescripcion.Text;

        if (FileUpload1.HasFile)
        {
            exten = System.IO.Path.GetExtension(FileUpload1.FileName);
            exten = exten.ToLower();
            tamano = FileUpload1.PostedFile.ContentLength;
            Response.Write(exten + "," + tamano);
            nomIMG = FileUpload1.FileName;

            FileUpload1.SaveAs(Server.MapPath("../../img/" + FileUpload1.FileName));

            try
            {
                PRODUCTOS_BLL.Actualizar(codprod, nombreprod, fechaelab, fechaven, vent, cant, descprod, tiprod, sucprod, nomIMG, prec);
                Response.Redirect("~/webformsADM/producto/ProductosAdmin.aspx");
            }
            catch (Exception ex)
            {

            }

        }
        else
        {
            Response.Write("Seleccione una imagen");
        }
    }
}