using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de TIPOTELEFONO_BLL
/// </summary>
public class TIPOTELEFONO_BLL
{
    public TIPOTELEFONO_BLL()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    static MARKET_DSTableAdapters.TIPO_TELEFONOTableAdapter adto = new MARKET_DSTableAdapters.TIPO_TELEFONOTableAdapter();

    public static List<TIPOTELEFONO_DTO> MostrarTodos()
    {
        List<TIPOTELEFONO_DTO> mostraroles = new List<TIPOTELEFONO_DTO>();
        //MARKET_DSTableAdapters.TIPO_TELEFONOTableAdapter adto = new MARKET_DSTableAdapters.TIPO_TELEFONOTableAdapter();
        MARKET_DS.TIPO_TELEFONODataTable tabla = adto.MostrarTodoTipoTelefono();
        foreach (MARKET_DS.TIPO_TELEFONORow fila in tabla)
        {
            mostraroles.Add(filaSDTO(fila));
        }
        return mostraroles;
    }

    private static TIPOTELEFONO_DTO filaSDTO(MARKET_DS.TIPO_TELEFONORow fila)
    {
        TIPOTELEFONO_DTO objTprod = new TIPOTELEFONO_DTO();
        objTprod.ID_TIPO_TELEFONO = fila.ID_TIPO_TELEFONO;
        objTprod.TIPO_TELEFONO = fila.TIPO_TELEFONO;
        objTprod.DESCRIPCION_TIPO_TELEFONO = fila.DESCRIPCION_TIPO_TELEFONO;

        return objTprod;
    }

    public static TIPOTELEFONO_DTO MostrarID(int ID_TIPO_TELEFONO)
    {
        MARKET_DS.TIPO_TELEFONODataTable tabla = adto.MostrarTipoTelefonoPorID(ID_TIPO_TELEFONO);
        if (tabla.Rows.Count == 0)
        {
            return null;
        }

        return filaSDTO(tabla[0]);
    }

    public static void Insertar(int ID_TIPO_TELEFONO, string TIPO_TELEFONO, string DESCRIPCION_TIPO_TELEFONO)
    {
        adto.Insert(ID_TIPO_TELEFONO, TIPO_TELEFONO, DESCRIPCION_TIPO_TELEFONO);
    }

    public static void Borrar(int ID_TIPO_TELEFONO)
    {
        adto.Delete(ID_TIPO_TELEFONO);
    }

    public static void Actualizar(int ID_TIPO_TELEFONO, string TIPO_TELEFONO, string DESCRIPCION_TIPO_TELEFONO)
    {
        adto.Update(TIPO_TELEFONO, DESCRIPCION_TIPO_TELEFONO, ID_TIPO_TELEFONO);
    }


}

