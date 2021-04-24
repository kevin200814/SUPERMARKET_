using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de SEXO_BLL
/// </summary>
public class SEXO_BLL
{
    public SEXO_BLL()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    static MARKET_DSTableAdapters.SEXOTableAdapter adto = new MARKET_DSTableAdapters.SEXOTableAdapter();

    public static List<SEXO_DTO> MostrarTodos()
    {
        List<SEXO_DTO> mostraroles = new List<SEXO_DTO>();
        
        MARKET_DS.SEXODataTable tabla = adto.MostrarTodoSexo();
        foreach (MARKET_DS.SEXORow fila in tabla)
        {
            mostraroles.Add(filaSDTO(fila));
        }
        return mostraroles;
    }

    private static SEXO_DTO filaSDTO(MARKET_DS.SEXORow fila)
    {
        SEXO_DTO objTprod = new SEXO_DTO();
        objTprod.ID_SEXO = fila.ID_SEXO;
        objTprod.SEXO = fila.SEXO;

        return objTprod;
    }

    public static SEXO_DTO MostrarID(int ID_SEXO)
    {
        MARKET_DS.SEXODataTable tabla = adto.MostrarSexoPorID(ID_SEXO);
        if (tabla.Rows.Count == 0)
        {
            return null;
        }

        return filaSDTO(tabla[0]);
    }

    public static void Insertar(int ID_SEXO, string SEXO)
    {
        adto.Insert(ID_SEXO, SEXO);
    }

    public static void Borrar(int ID_SEXO)
    {
        adto.Delete(ID_SEXO);
    }

    public static void Actualizar(int ID_SEXO, string SEXO)
    {
        adto.Update(SEXO, ID_SEXO);
    }
}