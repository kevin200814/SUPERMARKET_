using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CIUDAD_BLL
/// </summary>
public class CIUDAD_BLL
{
    public CIUDAD_BLL()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
    public static List<CIUDAD_DTO> MostrarTodos()
    {
        List<CIUDAD_DTO> mostrarciudades = new List<CIUDAD_DTO>();
        MARKET_DSTableAdapters.CIUDADTableAdapter adto = new MARKET_DSTableAdapters.CIUDADTableAdapter();
        MARKET_DS.CIUDADDataTable tabla = adto.MostrarCiudades();
        foreach (MARKET_DS.CIUDADRow fila in tabla)
        {
            mostrarciudades.Add(filaSDTO(fila));
        }
        return mostrarciudades;
    }

    private static CIUDAD_DTO filaSDTO(MARKET_DS.CIUDADRow fila)
    {
        CIUDAD_DTO objCiudades = new CIUDAD_DTO();
        objCiudades.ID_CIUDAD = fila.ID_CIUDAD;
        objCiudades.NOMBRE_CIUDAD = fila.NOMBRE_CIUDAD;
        objCiudades.ID_DEPARTAMENTO = fila.ID_DEPARTAMENTO_CIUDAD;
        return objCiudades;
    }

    public static CIUDAD_DTO MostrarID(int CodCiudad)
    {
        MARKET_DSTableAdapters.CIUDADTableAdapter adto = new MARKET_DSTableAdapters.CIUDADTableAdapter();
        MARKET_DS.CIUDADDataTable tabla = adto.MostrarCiudadID(CodCiudad);
        if (tabla.Rows.Count == 0)
        {
            return null;
        }
        return filaSDTO(tabla[0]);
    }

    public static void Insertar(int CodCiudad, string nom_ciudad, int CodDepart)
    {
        MARKET_DSTableAdapters.CIUDADTableAdapter adto = new MARKET_DSTableAdapters.CIUDADTableAdapter();
        adto.Insert(CodCiudad, nom_ciudad, CodDepart);
    }

    public static void Borrar(int CodCiudad)
    {
        MARKET_DSTableAdapters.CIUDADTableAdapter adto = new MARKET_DSTableAdapters.CIUDADTableAdapter();
        adto.Delete(CodCiudad);
    }

    public static void Actualizar(int CodCiudad, string nom_ciudad, int CodDepart)
    {
        MARKET_DSTableAdapters.CIUDADTableAdapter adto = new MARKET_DSTableAdapters.CIUDADTableAdapter();
        adto.Update(nom_ciudad, CodDepart, CodCiudad);
    }
}