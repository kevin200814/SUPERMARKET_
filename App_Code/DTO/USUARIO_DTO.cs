using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de USUARIO_DTO
/// </summary>
public class USUARIO_DTO
{
    public USUARIO_DTO()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public int ID_USUARIO { get; set; }
    public string NOMBRE_USUARIO { get; set; }
    public string CONTRASENA_USUARIO { get; set; }
    public int ID_TIPO_USUARIO { get; set; }
    public int ID_PERSONA_USUARIO { get; set; }
}