using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de UR_BD_BLL
/// </summary>
public class UR_BD_BLL
{
    public UR_BD_BLL()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public static List<UR_BD_DTO> MostrarTodos()
    {
        List<UR_BD_DTO> mostrar = new List<UR_BD_DTO>();
        MARKET_DSTableAdapters.USUARIO_ROL_BDTableAdapter adto = new MARKET_DSTableAdapters.USUARIO_ROL_BDTableAdapter();
        MARKET_DS.USUARIO_ROL_BDDataTable tabla = adto.MostrarRUBD();
        foreach (MARKET_DS.USUARIO_ROL_BDRow fila in tabla)
        {
            mostrar.Add(filaSDTO(fila));
        }
        return mostrar;
    }

    private static UR_BD_DTO filaSDTO(MARKET_DS.USUARIO_ROL_BDRow fila)
    {
        UR_BD_DTO obj = new UR_BD_DTO();
        obj.ID_USUARIO = fila.ID_USUARIO;
        obj.ID_ROL_BD = fila.ID_ROL_BD;
        return obj;
    }

    public static UR_BD_DTO MostrarID(int CodUsuario,int CodRolBD)
    {
        MARKET_DSTableAdapters.USUARIO_ROL_BDTableAdapter adto = new MARKET_DSTableAdapters.USUARIO_ROL_BDTableAdapter();
        MARKET_DS.USUARIO_ROL_BDDataTable tabla = adto.MostrarRUBD_ID(CodUsuario,CodRolBD);
        if (tabla.Rows.Count == 0)
        {
            return null;
        }
        return filaSDTO(tabla[0]);
    }

    public static void Insertar(int CodUsuario, int CodRolBD)
    {
        MARKET_DSTableAdapters.USUARIO_ROL_BDTableAdapter adto = new MARKET_DSTableAdapters.USUARIO_ROL_BDTableAdapter();
        adto.Insert(CodUsuario, CodRolBD);
    }

    /*
    public static void Borrar(int CodUsuario)
    {
        MARKET_DSTableAdapters.USUARIO_ROL_BDTableAdapter adto = new MARKET_DSTableAdapters.USUARIO_ROL_BDTableAdapter();
        adto.Delete(CodUsuario);
    }
    */

    public static void Actualizar(int CodUsuario, int CodRolBD)
    {
        MARKET_DSTableAdapters.USUARIO_ROL_BDTableAdapter adto = new MARKET_DSTableAdapters.USUARIO_ROL_BDTableAdapter();
        adto.Update(CodUsuario, CodRolBD);
    }

}