using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PROVEEDOR_BLL
/// </summary>
public class PROVEEDOR_BLL
{
    public PROVEEDOR_BLL()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    static MARKET_DSTableAdapters.PROVEEDORTableAdapter adto = new MARKET_DSTableAdapters.PROVEEDORTableAdapter();

    public static List<PROVEEDOR_DTO> MostrarTodos()
    {
        List<PROVEEDOR_DTO> mostrarprov = new List<PROVEEDOR_DTO>();
        MARKET_DS.PROVEEDORDataTable table = adto.MostrarProveedor();
        foreach(MARKET_DS.PROVEEDORRow fila in table)
        {
            mostrarprov.Add(filaSTDO(fila));
        }
        return mostrarprov;
    }

    private static PROVEEDOR_DTO filaSTDO(MARKET_DS.PROVEEDORRow fila)
    {
        PROVEEDOR_DTO objProv = new PROVEEDOR_DTO();
        objProv.ID_PROVEEDOR = fila.ID_PROVEEDOR;
        objProv.NOMBRE_PROVEEDOR = fila.NOMBRE_PROVEEDOR;
        return objProv;
    }

    public static PROVEEDOR_DTO MostrarID(int codprove)
    {
        MARKET_DS.PROVEEDORDataTable table = adto.MostrarProvee(codprove);
        if(table.Rows.Count == 0)
        {
            return null;
        }
        return filaSTDO(table[0]);
    }
    
  


    //Mantenimientos

    public static void Insertar(int ID_PROVEEDOR, string NOMBRE_PROVEEDOR)
    {
        adto.Insert(ID_PROVEEDOR, NOMBRE_PROVEEDOR);
    }

    public static void Borrar( int ID_PROVEEDOR)
    {
        adto.Delete(ID_PROVEEDOR);
    }

    public static void Actualizar(int ID_PROVEEDOR, string NOMBRE_PROVEEDOR)
    {
        adto.Update( NOMBRE_PROVEEDOR, ID_PROVEEDOR);
    }

}