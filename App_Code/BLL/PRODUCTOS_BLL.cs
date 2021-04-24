using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PRODUCTOS_BLL
/// </summary>
public class PRODUCTOS_BLL
{
    public PRODUCTOS_BLL()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    static MARKET_DSTableAdapters.PRODUCTOTableAdapter adto = new MARKET_DSTableAdapters.PRODUCTOTableAdapter();

    public static List<PRODUCTOS_DTO> Mostarproducto()
    {
        List<PRODUCTOS_DTO> mostrarprod = new List<PRODUCTOS_DTO>();
        MARKET_DS.PRODUCTODataTable tabla = adto.MostrarProductos();
        foreach (MARKET_DS.PRODUCTORow fila in tabla)
        {
            mostrarprod.Add(filasTDO(fila));
        }
        return mostrarprod;
    }

    private static PRODUCTOS_DTO filasTDO(MARKET_DS.PRODUCTORow fila)
    {
        PRODUCTOS_DTO objProd = new PRODUCTOS_DTO();

        objProd.ID_PRODUCTO = fila.ID_PRODUCTO;
        objProd.NOMBRE_PRODUCTO = fila.NOMBRE_PRODUCTO;
        objProd.FECHA_ELABORACION_PRODUCTO = fila.FECHA_ELABORACION_PRODUCTO;
        objProd.FECHA_VENCIMIENTO_PRODUCTO = fila.FECHA_VENCIMIENTO_PRODUCTO;

        objProd.VENTA_PRODUCTO = fila.VENTA_PRODUCTO;
        objProd.CANTIDAD_PRODUCTO = fila.CANTIDAD_PRODUCTO;
        objProd.DESCRIPCION_PRODUCTO = fila.DESCRIPCION_PRODUCTO;
        objProd.ID_TIPO_PRODUCTO = fila.ID_TIPO_PRODUCTO;
        objProd.ID_SUCURSAL_PRODUCTO = fila.ID_SUCURSAL_PRODUCTO;
        objProd.IMG = fila.img;
        objProd.PRECIO = fila.precio;
        return objProd;
    }

     public static PRODUCTOS_DTO MostrarID(int codprod)

     {
         MARKET_DS.PRODUCTODataTable tabla = adto.MostrarProductosID(codprod);
         if (tabla.Rows.Count == 0)
         {
             return null;
         }
         return filasTDO(tabla[0]);
     }

     

    public static void Insertar(int codprod, string nomprod, DateTime fechaelab, DateTime fechacad, double ventprod, int cantprod, string descprod, int idtipoprod, int idsucprod, string image, double prec)
    {
        adto.Insert(codprod, nomprod, fechaelab, fechacad, ventprod, cantprod, descprod, idsucprod, idtipoprod, image, prec);
    }

    public static void Borrar(int codprod)
    {
        adto.Delete(codprod);
    }

    public static void Actualizar(int codprod, string nomprod, DateTime fechaelab, DateTime fechacad, double ventprod, int cantprod, string descprod, int idtipoprod, int idsucprod, string image, double prec)
    {
        adto.Update(nomprod, fechaelab, fechacad, ventprod, cantprod, descprod, idtipoprod, idsucprod, image, prec, codprod);
    }
}