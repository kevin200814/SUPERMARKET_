using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de PERSONA_DTO
/// </summary>
public class PERSONA_DTO
{
    public PERSONA_DTO()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public int ID_PERSONA { get; set; }

    public string PRIMER_NOMBRE_PERSONA { get; set; }

    public string SEGUNDO_NOMBRE_PERSONA { get; set; }

    public string PRIMER_APELLIDO_PERSONA { get; set; }

    public string SEGUNDO_APELLIDO_PERSONA { get; set; }

    public DateTime FECHA_NACIMIENTO_PERSONA { get; set; }

    public string NUMERO_IDENTIDAD_PERSONA { get; set; }

    public string DIRECCION_RESIDENCIA_PERSONA { get; set; }

    public int ID_CIUDAD_RESIDENCIA_PERSONA { get; set; }

    public int ID_SEXO_PERSONA { get; set; }
}