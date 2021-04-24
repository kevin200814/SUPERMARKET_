using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de EMPLEADO_DTO
/// </summary>
public class EMPLEADO_DTO
{
    public EMPLEADO_DTO()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public int ID_EMPLEADO { get; set; }

    public DateTime FECHA_CONTRATACION_EMPLEADO { get; set; }

    public int HORAS_LABORALES_MENSUALES_EMPLEADO { get; set; }

    public int ID_PERSONA_EMPLEADO { get; set; }

    public int ID_CARGO_LABORAL_EMPLEADO { get; set; }

    public int ID_SUCURSAL_EMPLEADO { get; set; }
}