using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CARGOLABORAL_DTO
/// </summary>
public class CARGOLABORAL_DTO
{
    public CARGOLABORAL_DTO()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public int ID_CARGO_LABORAL { get; set; }

    public string CARGO_LABORAL { get; set; }

    public string DESCRIPCION_CARGO_LABORAL { get; set; }

    public double SALARIO_MENSUAL_CARGO_LABORAL { get; set; }
}