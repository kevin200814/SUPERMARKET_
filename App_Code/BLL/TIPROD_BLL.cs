using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de TIPROD_BLL
/// </summary>
public class TIPROD_BLL
{
    public TIPROD_BLL()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public static List<TIPROD_DTO> MostrarTodos()
    {
        List<TIPROD_DTO> mostrarroles = new List<TIPROD_DTO>();
        MARKET_DSTableAdapters.TIPO_PRODUCTOTableAdapter adto = new MARKET_DSTableAdapters.TIPO_PRODUCTOTableAdapter();
        MARKET_DS.TIPO_PRODUCTODataTable tabla = adto.MostrarTProductos();
        foreach (MARKET_DS.TIPO_PRODUCTORow fila in tabla)
        {
            mostrarroles.Add(filaSDTO(fila));
        }

        return mostrarroles;
    }

    private static TIPROD_DTO filaSDTO(MARKET_DS.TIPO_PRODUCTORow fila)
    {
        TIPROD_DTO objTprod = new TIPROD_DTO();
        objTprod.ID_TIPO_PRODUCTO = fila.ID_TIPO_PRODUCTO;
        objTprod.TIPO_PRODUCTO = fila.TIPO_PRODUCTO;
        objTprod.DESCRIPCION_TIPO_PRODUCTO = fila.DESCRIPCION_TIPO_PRODUCTO;
        return objTprod;
    }

    public static TIPROD_DTO MostrarID(int CodPro)
    {
        MARKET_DSTableAdapters.TIPO_PRODUCTOTableAdapter adto = new MARKET_DSTableAdapters.TIPO_PRODUCTOTableAdapter();
        MARKET_DS.TIPO_PRODUCTODataTable tabla = adto.MostrarTprodID(CodPro);
        if (tabla.Rows.Count == 0)
        {
            return null;
        }
        return filaSDTO(tabla[0]);
    }

    public static void Insertar(int codTprod, string Tprod, string desProd)
    {
        MARKET_DSTableAdapters.TIPO_PRODUCTOTableAdapter adto = new MARKET_DSTableAdapters.TIPO_PRODUCTOTableAdapter();
        adto.Insert(codTprod, Tprod, desProd);
    }

    public static void Borrar(int codTpro)
    {
        MARKET_DSTableAdapters.TIPO_PRODUCTOTableAdapter adto = new MARKET_DSTableAdapters.TIPO_PRODUCTOTableAdapter();
        adto.Delete(codTpro);
    }

    public static void Actualizar(int codTpro, string Tprod, string desProd)
    {
        MARKET_DSTableAdapters.TIPO_PRODUCTOTableAdapter adto = new MARKET_DSTableAdapters.TIPO_PRODUCTOTableAdapter();
        adto.Update(Tprod, desProd, codTpro);
    }
}