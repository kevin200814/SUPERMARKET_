using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de PAIS_BLL
/// </summary>
public class PAIS_BLL
{
    public PAIS_BLL()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public static List<PAIS_DTO> MostrarTodos()
    {
        List<PAIS_DTO> mostrarpaises = new List<PAIS_DTO>();
        MARKET_DSTableAdapters.PAISTableAdapter adto = new MARKET_DSTableAdapters.PAISTableAdapter();
        MARKET_DS.PAISDataTable tabla = adto.MostrarPaisTodos();
        foreach (MARKET_DS.PAISRow fila in tabla)
        {
            mostrarpaises.Add(filaSDTO(fila));
        }
        return mostrarpaises;
    }

    private static PAIS_DTO filaSDTO(MARKET_DS.PAISRow fila)
    {
        PAIS_DTO objTpaises = new PAIS_DTO();
        objTpaises.ID_PAIS = fila.ID_PAIS;
        objTpaises.NOMBRE_PAIS = fila.NOMBRE_PAIS;
        return objTpaises;
    }

    public static PAIS_DTO MostrarID(int CodPais)
    {
        MARKET_DSTableAdapters.PAISTableAdapter adto = new MARKET_DSTableAdapters.PAISTableAdapter();
        MARKET_DS.PAISDataTable tabla = adto.MostrarPaisID(CodPais);
        if (tabla.Rows.Count == 0)
        {
            return null;
        }
        return filaSDTO(tabla[0]);
    }

    public static void Insertar(int CodPais, string Pnombre)
    {
        MARKET_DSTableAdapters.PAISTableAdapter adto = new MARKET_DSTableAdapters.PAISTableAdapter();
        adto.Insert(CodPais, Pnombre);
    }

    public static void Borrar(int CodPais)
    {
        MARKET_DSTableAdapters.PAISTableAdapter adto = new MARKET_DSTableAdapters.PAISTableAdapter();
        adto.Delete(CodPais);
    }

    public static void Actualizar(int CodPais, string Pnombre)
    {
        MARKET_DSTableAdapters.PAISTableAdapter adto = new MARKET_DSTableAdapters.PAISTableAdapter();
        adto.Update(Pnombre, CodPais);
    }


}