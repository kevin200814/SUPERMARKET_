using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de URS_BLL
/// </summary>
public class URS_BLL
{
    public URS_BLL()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public static List<URS_DTO> MostrarTodos()
    {
        List<URS_DTO> mostrar = new List<URS_DTO>();
        MARKET_DSTableAdapters.USUARIO_ROL_SERVIDORTableAdapter adto = new MARKET_DSTableAdapters.USUARIO_ROL_SERVIDORTableAdapter();
        MARKET_DS.USUARIO_ROL_SERVIDORDataTable tabla = adto.MostrarURS();
        foreach (MARKET_DS.USUARIO_ROL_SERVIDORRow fila in tabla)
        {
            mostrar.Add(filaSDTO(fila));
        }
        return mostrar;
    }

    private static URS_DTO filaSDTO(MARKET_DS.USUARIO_ROL_SERVIDORRow fila)
    {
        URS_DTO obj = new URS_DTO();
        obj.ID_USUARIO = fila.ID_USUARIO;
        obj.ID_ROL_SERVIDOR = fila.ID_ROL_SERVIDOR;
        return obj;
    }

    public static URS_DTO MostrarID(int CodUsuario, int CodRolServer)
    {
        MARKET_DSTableAdapters.USUARIO_ROL_SERVIDORTableAdapter adto = new MARKET_DSTableAdapters.USUARIO_ROL_SERVIDORTableAdapter();
        MARKET_DS.USUARIO_ROL_SERVIDORDataTable tabla = adto.MostrarURS_ID(CodUsuario, CodRolServer);
        if (tabla.Rows.Count == 0)
        {
            return null;
        }
        return filaSDTO(tabla[0]);
    }

    public static void Insertar(int CodUsuario, int CodRolServer)
    {
        MARKET_DSTableAdapters.USUARIO_ROL_SERVIDORTableAdapter adto = new MARKET_DSTableAdapters.USUARIO_ROL_SERVIDORTableAdapter();
        adto.Insert(CodUsuario, CodRolServer);
    }

    /*
    public static void Borrar(int CodUsuario)
    {
        MARKET_DSTableAdapters.USUARIO_ROL_BDTableAdapter adto = new MARKET_DSTableAdapters.USUARIO_ROL_BDTableAdapter();
        adto.Delete(CodUsuario);
    }
    */

    public static void Actualizar(int CodUsuario, int CodRolServer)
    {
        MARKET_DSTableAdapters.USUARIO_ROL_SERVIDORTableAdapter adto = new MARKET_DSTableAdapters.USUARIO_ROL_SERVIDORTableAdapter();
        adto.Update(CodUsuario, CodRolServer);
    }
}