using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PRODUCTOS_DTO
/// </summary>
public class PRODUCTOS_DTO
{
    public PRODUCTOS_DTO()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public int ID_PRODUCTO { get; set; }
    public string NOMBRE_PRODUCTO { get; set; }
    public DateTime FECHA_ELABORACION_PRODUCTO { get; set; }
    public DateTime FECHA_VENCIMIENTO_PRODUCTO { get; set; }
    // public double COMPRA_PRODUCTO { get; set; } NO ESTA EN TABLE ADAPTER
    public double VENTA_PRODUCTO { get; set; }
    public int CANTIDAD_PRODUCTO { get; set; }
    public string DESCRIPCION_PRODUCTO { get; set; }
    public int ID_TIPO_PRODUCTO { get; set; }
    public int ID_SUCURSAL_PRODUCTO { get; set; }
    public string IMG { get; set; }
    public double PRECIO { get; set; }
}