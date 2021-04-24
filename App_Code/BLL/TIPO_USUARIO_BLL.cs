using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de TIPO_USUARIO_BLL
/// </summary>
public class TIPO_USUARIO_BLL
{
    public TIPO_USUARIO_BLL()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public static List<TIPO_USUARIO_DTO> MostrarTodos()
    {
        List<TIPO_USUARIO_DTO> mostrar = new List<TIPO_USUARIO_DTO>();
        MARKET_DSTableAdapters.TIPO_USUARIOTableAdapter adto = new MARKET_DSTableAdapters.TIPO_USUARIOTableAdapter();
        MARKET_DS.TIPO_USUARIODataTable tabla = adto.MostrarTipoUsers();
        foreach (MARKET_DS.TIPO_USUARIORow fila in tabla)
        {
            mostrar.Add(filaSDTO(fila));
        }
        return mostrar;
    }

    private static TIPO_USUARIO_DTO filaSDTO(MARKET_DS.TIPO_USUARIORow fila)
    {
        TIPO_USUARIO_DTO obj = new TIPO_USUARIO_DTO();
        obj.ID_TIPO_USUARIO = fila.ID_TIPO_USUARIO;
        obj.DESCRIPCION_TIPO_USUARIO = fila.DESCRIPCION_TIPO_USUARIO;
        return obj;
    }

    public static TIPO_USUARIO_DTO MostrarID(int CodTipoUser)
    {
        MARKET_DSTableAdapters.TIPO_USUARIOTableAdapter adto = new MARKET_DSTableAdapters.TIPO_USUARIOTableAdapter();
        MARKET_DS.TIPO_USUARIODataTable tabla = adto.MostrarTipoUsuarioID(CodTipoUser);
        if (tabla.Rows.Count == 0)
        {
            return null;
        }
        return filaSDTO(tabla[0]);
    }

    public static void Insertar(int CodTipoUser, string Descrip_tipo_user)
    {
        MARKET_DSTableAdapters.TIPO_USUARIOTableAdapter adto = new MARKET_DSTableAdapters.TIPO_USUARIOTableAdapter();
        adto.Insert(CodTipoUser, Descrip_tipo_user);
    }

    public static void Borrar(int CodTipoUser)
    {
        MARKET_DSTableAdapters.TIPO_USUARIOTableAdapter adto = new MARKET_DSTableAdapters.TIPO_USUARIOTableAdapter();
        adto.Delete(CodTipoUser);
    }

    public static void Actualizar(int CodTipoUser, string Descrip_tipo_user)
    {
        MARKET_DSTableAdapters.TIPO_USUARIOTableAdapter adto = new MARKET_DSTableAdapters.TIPO_USUARIOTableAdapter();
        adto.Update(Descrip_tipo_user, CodTipoUser);
    }

}