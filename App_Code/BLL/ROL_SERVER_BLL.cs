using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ROL_SERVER_BLL
/// </summary>
public class ROL_SERVER_BLL
{
    public ROL_SERVER_BLL()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public static List<ROL_SERVER_DTO> MostrarTodos()
    {
        List<ROL_SERVER_DTO> mostrar = new List<ROL_SERVER_DTO>();
        MARKET_DSTableAdapters.ROL_SERVIDORTableAdapter adto = new MARKET_DSTableAdapters.ROL_SERVIDORTableAdapter();
        MARKET_DS.ROL_SERVIDORDataTable tabla = adto.MostrarRolesServer();
        foreach (MARKET_DS.ROL_SERVIDORRow fila in tabla)
        {
            mostrar.Add(filaSDTO(fila));
        }
        return mostrar;
    }

    private static ROL_SERVER_DTO filaSDTO(MARKET_DS.ROL_SERVIDORRow fila)
    {
        ROL_SERVER_DTO obj = new ROL_SERVER_DTO();
        obj.ID_ROL_SERVIDOR = fila.ID_ROL_SERVIDOR;
        obj.DESCRIPCION_ROL_SERVIDOR = fila.DESCRIPCION_ROL_SERVIDOR;
        return obj;
    }

    public static ROL_SERVER_DTO MostrarID(int CodRolServer)
    {
        MARKET_DSTableAdapters.ROL_SERVIDORTableAdapter adto = new MARKET_DSTableAdapters.ROL_SERVIDORTableAdapter();
        MARKET_DS.ROL_SERVIDORDataTable tabla = adto.MostrarRolServerID(CodRolServer);
        if (tabla.Rows.Count == 0)
        {
            return null;
        }
        return filaSDTO(tabla[0]);
    }

    public static void Insertar(int CodRolServer, string Descrip_rol_server)
    {
        MARKET_DSTableAdapters.ROL_SERVIDORTableAdapter adto = new MARKET_DSTableAdapters.ROL_SERVIDORTableAdapter();
        adto.Insert(CodRolServer, Descrip_rol_server);
    }

    public static void Borrar(int CodRolServer)
    {
        MARKET_DSTableAdapters.ROL_SERVIDORTableAdapter adto = new MARKET_DSTableAdapters.ROL_SERVIDORTableAdapter();
        adto.Delete(CodRolServer);
    }

    public static void Actualizar(int CodRolServer, string Descrip_rol_server)
    {
        MARKET_DSTableAdapters.ROL_SERVIDORTableAdapter adto = new MARKET_DSTableAdapters.ROL_SERVIDORTableAdapter();
        adto.Update(Descrip_rol_server, CodRolServer);
    }
}