using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ROL_BD_BLL
/// </summary>
public class ROL_BD_BLL
{
    public ROL_BD_BLL()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public static List<ROL_BD_DTO> MostrarTodos()
    {
        List<ROL_BD_DTO> mostrar = new List<ROL_BD_DTO>();
        MARKET_DSTableAdapters.ROL_BDTableAdapter adto = new MARKET_DSTableAdapters.ROL_BDTableAdapter();
        MARKET_DS.ROL_BDDataTable tabla = adto.MostrarRolesBD();
        foreach (MARKET_DS.ROL_BDRow fila in tabla)
        {
            mostrar.Add(filaSDTO(fila));
        }
        return mostrar;
    }

    private static ROL_BD_DTO filaSDTO(MARKET_DS.ROL_BDRow fila)
    {
        ROL_BD_DTO obj = new ROL_BD_DTO();
        obj.ID_ROL_BD = fila.ID_ROL_BD;
        obj.DESCRIPCION_ROL_BB = fila.DESCRIPCION_ROL_BD;
        return obj;
    }

    public static ROL_BD_DTO MostrarID(int CodRolBD)
    {
        MARKET_DSTableAdapters.ROL_BDTableAdapter adto = new MARKET_DSTableAdapters.ROL_BDTableAdapter();
        MARKET_DS.ROL_BDDataTable tabla = adto.MostrarRolBDID(CodRolBD);
        if (tabla.Rows.Count == 0)
        {
            return null;
        }
        return filaSDTO(tabla[0]);
    }

    public static void Insertar(int CodRolBD, string Descrip_rol_bd)
    {
        MARKET_DSTableAdapters.ROL_BDTableAdapter adto = new MARKET_DSTableAdapters.ROL_BDTableAdapter();
        adto.Insert(CodRolBD, Descrip_rol_bd);
    }

    public static void Borrar(int CodRolBD)
    {
        MARKET_DSTableAdapters.ROL_BDTableAdapter adto = new MARKET_DSTableAdapters.ROL_BDTableAdapter();
        adto.Delete(CodRolBD);
    }

    public static void Actualizar(int CodRolBD, string Descrip_rol_bd)
    {
        MARKET_DSTableAdapters.ROL_BDTableAdapter adto = new MARKET_DSTableAdapters.ROL_BDTableAdapter();
        adto.Update(Descrip_rol_bd, CodRolBD);
    }

}