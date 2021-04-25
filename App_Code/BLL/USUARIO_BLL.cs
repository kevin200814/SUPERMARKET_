using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de USUARIO_BLL
/// </summary>
public class USUARIO_BLL
{
    public USUARIO_BLL()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public static List<USUARIO_DTO> MostrarTodos()
    {
        List<USUARIO_DTO> mostrarpaises = new List<USUARIO_DTO>();
        MARKET_DSTableAdapters.USUARIOTableAdapter adto = new MARKET_DSTableAdapters.USUARIOTableAdapter();
        MARKET_DS.USUARIODataTable tabla = adto.MostrarUsuarios();
        foreach (MARKET_DS.USUARIORow fila in tabla)
        {
            mostrarpaises.Add(filaSDTO(fila));
        }
        return mostrarpaises;
    }

    private static USUARIO_DTO filaSDTO(MARKET_DS.USUARIORow fila)
    {
        USUARIO_DTO obj = new USUARIO_DTO();
        obj.ID_USUARIO = fila.ID_USUARIO;
        obj.NOMBRE_USUARIO = fila.NOMBRE_USUARIO;
        obj.CONTRASENA_USUARIO = fila.CONTRASENA_USUARIO.ToString();
        obj.ID_TIPO_USUARIO = fila.ID_TIPO_USUARIO;
        obj.ID_PERSONA_USUARIO = fila.ID_PERSONA_USUARIO;
        return obj;
    }

    public static USUARIO_DTO MostrarID(int CodUsuario)
    {
        MARKET_DSTableAdapters.USUARIOTableAdapter adto = new MARKET_DSTableAdapters.USUARIOTableAdapter();
        MARKET_DS.USUARIODataTable tabla = adto.MostrarUsuarioID(CodUsuario);
        if (tabla.Rows.Count == 0)
        {
            return null;
        }
        return filaSDTO(tabla[0]);
    }

    public static void Insertar(int CodUsuario, string Nombre, byte[] contrasena, int idtuser, int idPusu)
    {
        MARKET_DSTableAdapters.USUARIOTableAdapter adto = new MARKET_DSTableAdapters.USUARIOTableAdapter();
        adto.Insert(CodUsuario, Nombre, contrasena, idtuser, idPusu);
    }

    public static void Borrar(int CodUsuario)
    {
        MARKET_DSTableAdapters.USUARIOTableAdapter adto = new MARKET_DSTableAdapters.USUARIOTableAdapter();
        adto.Delete(CodUsuario);
    }

    public static void Actualizar(int CodUsuario, string Nombre, byte[] contrasena, int idtuser, int idPusu)
    {
        MARKET_DSTableAdapters.USUARIOTableAdapter adto = new MARKET_DSTableAdapters.USUARIOTableAdapter();
        adto.Update(Nombre, contrasena,idtuser,idPusu, CodUsuario);
    }
}