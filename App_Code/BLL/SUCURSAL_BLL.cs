using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de SUCURSAL_BLL
/// </summary>
public class SUCURSAL_BLL
{
    public SUCURSAL_BLL()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public static List<SUCURSAL_DTO> MostrarTodos()
    {
        List<SUCURSAL_DTO> mostrarsucursales = new List<SUCURSAL_DTO>();
        MARKET_DSTableAdapters.SUCURSALTableAdapter adto = new MARKET_DSTableAdapters.SUCURSALTableAdapter();
        MARKET_DS.SUCURSALDataTable tabla = adto.MostrarSucursales();
        foreach (MARKET_DS.SUCURSALRow fila in tabla)
        {
            mostrarsucursales.Add(filaSDTO(fila));
        }
        return mostrarsucursales;
    }

    private static SUCURSAL_DTO filaSDTO(MARKET_DS.SUCURSALRow fila)
    {
        SUCURSAL_DTO objSucursal = new SUCURSAL_DTO();
        objSucursal.ID_SUCURSAL = fila.ID_SUCURSAL;
        objSucursal.NOMBRE_SUCURSAL = fila.NOMBRE_SUCURSAL;
        objSucursal.ID_CIUDAD = fila.ID_CIUDAD_SUCURSAL;
        return objSucursal;
    }

    public static SUCURSAL_DTO MostrarID(int CodSucursal)
    {
        MARKET_DSTableAdapters.SUCURSALTableAdapter adto = new MARKET_DSTableAdapters.SUCURSALTableAdapter();
        MARKET_DS.SUCURSALDataTable tabla = adto.MostrarSucursalID(CodSucursal);
        if (tabla.Rows.Count == 0)
        {
            return null;
        }
        return filaSDTO(tabla[0]);
    }

    public static void Insertar(int CodSucursal, string nom_sucursal, int CodCiudad)
    {
        MARKET_DSTableAdapters.SUCURSALTableAdapter adto = new MARKET_DSTableAdapters.SUCURSALTableAdapter();
        adto.Insert(CodCiudad, nom_sucursal, CodCiudad);
    }

    public static void Borrar(int CodCiudad)
    {
        MARKET_DSTableAdapters.SUCURSALTableAdapter adto = new MARKET_DSTableAdapters.SUCURSALTableAdapter();
        adto.Delete(CodCiudad);
    }

    public static void Actualizar(int CodSucursal, string nom_sucursal, int CodCiudad)
    {
        MARKET_DSTableAdapters.SUCURSALTableAdapter adto = new MARKET_DSTableAdapters.SUCURSALTableAdapter();
        adto.Update(nom_sucursal, CodCiudad, CodSucursal);
    }
}