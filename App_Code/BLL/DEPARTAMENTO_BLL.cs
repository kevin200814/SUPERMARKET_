using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de DEPARTAMENTO_BLL
/// </summary>
public class DEPARTAMENTO_BLL
{
    public DEPARTAMENTO_BLL()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public static List<DEPARTAMENTO_DTO> MostrarTodos()
    {
        List<DEPARTAMENTO_DTO> mostrardepartamentos = new List<DEPARTAMENTO_DTO>();
        MARKET_DSTableAdapters.DEPARTAMENTOTableAdapter adto = new MARKET_DSTableAdapters.DEPARTAMENTOTableAdapter();
        MARKET_DS.DEPARTAMENTODataTable tabla = adto.MostrarDepartamentos();
        foreach (MARKET_DS.DEPARTAMENTORow fila in tabla)
        {
            mostrardepartamentos.Add(filaSDTO(fila));
        }
        return mostrardepartamentos;
    }

    private static DEPARTAMENTO_DTO filaSDTO(MARKET_DS.DEPARTAMENTORow fila)
    {
        DEPARTAMENTO_DTO objTdepartamentos = new DEPARTAMENTO_DTO();
        objTdepartamentos.ID_DEPARTAMENTO = fila.ID_DEPARTAMENTO;
        objTdepartamentos.NOMBRE_DEPARTAMENTO = fila.NOMBRE_DEPARTAMENTO;
        objTdepartamentos.ID_PAIS = fila.ID_PAIS_DEPARTAMENTO;
        return objTdepartamentos;
    }

    public static DEPARTAMENTO_DTO MostrarID(int CodDepartamento)
    {
        MARKET_DSTableAdapters.DEPARTAMENTOTableAdapter adto = new MARKET_DSTableAdapters.DEPARTAMENTOTableAdapter();
        MARKET_DS.DEPARTAMENTODataTable tabla = adto.MostrarDepartamentoID(CodDepartamento);
        if (tabla.Rows.Count == 0)
        {
            return null;
        }
        return filaSDTO(tabla[0]);
    }

    public static void Insertar(int CodDepartamento, string departa_nom, int CodPais)
    {
        MARKET_DSTableAdapters.DEPARTAMENTOTableAdapter adto = new MARKET_DSTableAdapters.DEPARTAMENTOTableAdapter();
        adto.Insert(CodDepartamento, departa_nom, CodPais);
    }

    public static void Borrar(int CodDepartamento)
    {
        MARKET_DSTableAdapters.DEPARTAMENTOTableAdapter adto = new MARKET_DSTableAdapters.DEPARTAMENTOTableAdapter();
        adto.Delete(CodDepartamento);
    }

    public static void Actualizar(int CodDepartamento, string departa_nom, int CodPais)
    {
        MARKET_DSTableAdapters.DEPARTAMENTOTableAdapter adto = new MARKET_DSTableAdapters.DEPARTAMENTOTableAdapter();
        adto.Update(departa_nom, CodPais, CodDepartamento);
    }
}