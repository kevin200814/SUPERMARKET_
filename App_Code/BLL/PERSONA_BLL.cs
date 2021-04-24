using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de PERSONA_BLL
/// </summary>
public class PERSONA_BLL
{
    public PERSONA_BLL()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public static List<PERSONA_DTO> MostrarTodos()
    {
        List<PERSONA_DTO> mostrarpersona = new List<PERSONA_DTO>();
        MARKET_DSTableAdapters.PERSONATableAdapter adto = new MARKET_DSTableAdapters.PERSONATableAdapter();
        MARKET_DS.PERSONADataTable tabla = adto.MostrarPersona();
        foreach(MARKET_DS.PERSONARow fila in tabla)
        {
            mostrarpersona.Add(filaSDTO(fila));
        }

        return mostrarpersona;
    }
    
    private static PERSONA_DTO filaSDTO(MARKET_DS.PERSONARow fila)
    {
        PERSONA_DTO objPersona = new PERSONA_DTO();
        objPersona.ID_PERSONA = fila.ID_PERSONA;
        objPersona.PRIMER_NOMBRE_PERSONA = fila.PRIMER_NOMBRE_PERSONA;
        objPersona.SEGUNDO_NOMBRE_PERSONA = fila.SEGUNDO_NOMBRE_PERSONA;
        objPersona.PRIMER_APELLIDO_PERSONA = fila.PRIMER_APELLIDO_PERSONA;
        objPersona.SEGUNDO_APELLIDO_PERSONA = fila.SEGUNDO_APELLIDO_PERSONA;
        objPersona.FECHA_NACIMIENTO_PERSONA = fila.FECHA_NACIMIENTO_PERSONA;
        objPersona.NUMERO_IDENTIDAD_PERSONA = fila.NUMERO_IDENTIDAD_PERSONA;
        objPersona.DIRECCION_RESIDENCIA_PERSONA = fila.DIRECCION_RESIDENCIA_PERSONA;
        objPersona.ID_CIUDAD_RESIDENCIA_PERSONA = fila.ID_CIUDAD_RESIDENCIA_PERSONA;
        objPersona.ID_SEXO_PERSONA = fila.ID_SEXO_PERSONA;
        return objPersona;
    }

    public static PERSONA_DTO MostrarID(int codPersona)
    {
        MARKET_DSTableAdapters.PERSONATableAdapter adto = new MARKET_DSTableAdapters.PERSONATableAdapter();
        MARKET_DS.PERSONADataTable tabla = adto.MostrarPersonaID(codPersona);
        if(tabla.Rows.Count == 0)
        {
            return null;
        }
        return filaSDTO(tabla[0]);
    }

    public static void Insertar(int idPersona, string Pnombre, string Snombre, string Papellido, string Sapellido, DateTime FechaN, string NumIden, string Direccion, int idCiudad, int idSexo)
    {
        MARKET_DSTableAdapters.PERSONATableAdapter adto = new MARKET_DSTableAdapters.PERSONATableAdapter();
        adto.Insert(idPersona, Pnombre, Snombre, Papellido, Sapellido, FechaN, NumIden, Direccion, idCiudad, idSexo);
    }

    public static void Borrar(int codPersona)
    {
        MARKET_DSTableAdapters.PERSONATableAdapter adto = new MARKET_DSTableAdapters.PERSONATableAdapter();
        adto.Delete(codPersona);

    }

    public static void Actualizar(int idPersona, string Pnombre, string Snombre, string Papellido, string Sapellido, DateTime FechaN, string NumIden, string Direccion, int idCiudad, int idSexo)
    {
        MARKET_DSTableAdapters.PERSONATableAdapter adto = new MARKET_DSTableAdapters.PERSONATableAdapter();
        adto.Update(Pnombre, Snombre, Papellido, Sapellido, FechaN, NumIden, Direccion, idCiudad, idSexo, idPersona);
    }
}