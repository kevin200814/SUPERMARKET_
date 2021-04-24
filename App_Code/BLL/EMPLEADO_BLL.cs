using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de EMPLEADO_BLL
/// </summary>
public class EMPLEADO_BLL
{
    public EMPLEADO_BLL()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    static MARKET_DSTableAdapters.EMPLEADOTableAdapter adto = new MARKET_DSTableAdapters.EMPLEADOTableAdapter();

    public static List<EMPLEADO_DTO> MostrarTodos()
    {
        List<EMPLEADO_DTO> mostraroles = new List<EMPLEADO_DTO>();

        MARKET_DS.EMPLEADODataTable tabla = adto.MostrartodoEmpleado();
        foreach (MARKET_DS.EMPLEADORow fila in tabla)
        {
            mostraroles.Add(filaSDTO(fila));
        }
        return mostraroles;
    }

    private static EMPLEADO_DTO filaSDTO(MARKET_DS.EMPLEADORow fila)
    {
        EMPLEADO_DTO objTprod = new EMPLEADO_DTO();
        objTprod.ID_EMPLEADO = fila.ID_EMPLEADO;
        objTprod.FECHA_CONTRATACION_EMPLEADO = fila.FECHA_CONTRATACION_EMPLEADO;
        objTprod.HORAS_LABORALES_MENSUALES_EMPLEADO = fila.HORAS_LABORALES_MENSUALES_EMPLEADO;
        objTprod.ID_PERSONA_EMPLEADO = fila.ID_PERSONA_EMPLEADO;
        objTprod.ID_CARGO_LABORAL_EMPLEADO = fila.ID_CARGO_LABORAL_EMPLEADO;
        objTprod.ID_SUCURSAL_EMPLEADO = fila.ID_SUCURSAL_EMPLEADO;


        return objTprod;
    }

    public static EMPLEADO_DTO MostrarID(int ID_EMPLEADO)
    {
        MARKET_DS.EMPLEADODataTable tabla = adto.MostrartodoIDEmpleado(ID_EMPLEADO);
        if (tabla.Rows.Count == 0)
        {
            return null;
        }

        return filaSDTO(tabla[0]);
    }

    public static void Insertar(int ID_EMPLEADO, DateTime FECHA_CONTRATACION_EMPLEADO, int HORAS_LABORALES_MENSUALES_EMPLEADO, int ID_PERSONA_EMPLEADO,
        int ID_CARGO_LABORAL_EMPLEADO, int ID_SUCURSAL_EMPLEADO)
    {
        adto.Insert(ID_EMPLEADO, FECHA_CONTRATACION_EMPLEADO, HORAS_LABORALES_MENSUALES_EMPLEADO, ID_PERSONA_EMPLEADO,
        ID_CARGO_LABORAL_EMPLEADO, ID_SUCURSAL_EMPLEADO);
    }

    public static void Borrar(int ID_EMPLEADO)
    {
        adto.Delete(ID_EMPLEADO);
    }

    public static void Actualizar(int ID_EMPLEADO, DateTime FECHA_CONTRATACION_EMPLEADO, int HORAS_LABORALES_MENSUALES_EMPLEADO, int ID_PERSONA_EMPLEADO,
        int ID_CARGO_LABORAL_EMPLEADO, int ID_SUCURSAL_EMPLEADO)
    {
        adto.Update(FECHA_CONTRATACION_EMPLEADO, HORAS_LABORALES_MENSUALES_EMPLEADO, ID_PERSONA_EMPLEADO,
        ID_CARGO_LABORAL_EMPLEADO, ID_SUCURSAL_EMPLEADO, ID_EMPLEADO);
    }

}