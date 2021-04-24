using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CARGOLABORAL_BLL
/// </summary>
public class CARGOLABORAL_BLL
{
    public CARGOLABORAL_BLL()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    static MARKET_DSTableAdapters.CARGO_LABORALTableAdapter adto = new MARKET_DSTableAdapters.CARGO_LABORALTableAdapter();

    public static List<CARGOLABORAL_DTO> MostrarTodos()
    {
        List<CARGOLABORAL_DTO> mostraroles = new List<CARGOLABORAL_DTO>();
        
        MARKET_DS.CARGO_LABORALDataTable tabla = adto.MostrarTodoCargoLaboral();
        foreach (MARKET_DS.CARGO_LABORALRow fila in tabla)
        {
            mostraroles.Add(filaSDTO(fila));
        }
        return mostraroles;
    }

    private static CARGOLABORAL_DTO filaSDTO(MARKET_DS.CARGO_LABORALRow fila)
    {
        CARGOLABORAL_DTO objTprod = new CARGOLABORAL_DTO();
        objTprod.ID_CARGO_LABORAL = fila.ID_CARGO_LABORAL;
        objTprod.CARGO_LABORAL = fila.CARGO_LABORAL;
        objTprod.DESCRIPCION_CARGO_LABORAL = fila.DESCRIPCION_CARGO_LABORAL;
        objTprod.SALARIO_MENSUAL_CARGO_LABORAL = fila.SALARIO_MENSUAL_CARGO_LABORAL;

        return objTprod;
    }

    public static CARGOLABORAL_DTO MostrarID(int ID_CARGO_LABORAL)
    {
        MARKET_DS.CARGO_LABORALDataTable tabla = adto.MostrarCargoLaboralid(ID_CARGO_LABORAL);
        if (tabla.Rows.Count == 0)
        {
            return null;
        }

        return filaSDTO(tabla[0]);
    }

    public static void Insertar(int ID_CARGO_LABORAL, string CARGO_LABORAL, string DESCRIPCION_CARGO_LABORAL, double SALARIO_MENSUAL_CARGO_LABORAL)
    {
        adto.Insert(ID_CARGO_LABORAL, CARGO_LABORAL, DESCRIPCION_CARGO_LABORAL, SALARIO_MENSUAL_CARGO_LABORAL);
    }

    public static void Borrar(int ID_CARGO_LABORAL)
    {
        adto.Delete(ID_CARGO_LABORAL);
    }

    public static void Actualizar(int ID_CARGO_LABORAL, string CARGO_LABORAL, string DESCRIPCION_CARGO_LABORAL, double SALARIO_MENSUAL_CARGO_LABORAL)
    {
        adto.Update(CARGO_LABORAL, DESCRIPCION_CARGO_LABORAL, SALARIO_MENSUAL_CARGO_LABORAL, ID_CARGO_LABORAL);
    }

}