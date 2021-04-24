using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

/// <summary>
/// Descripción breve de Encriptar
/// </summary>
public class Encriptar
{
    public Encriptar()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }


    public static string Encrip(String texto)
    {
        using (SHA1Managed sha1 = new SHA1Managed())
        {
            var textSHA = sha1.ComputeHash(Encoding.UTF8.GetBytes(texto));
            var sb = new StringBuilder(textSHA.Length * 2);
            foreach (byte b in textSHA)
            {
                sb.Append(b.ToString("X2"));
            }
            return sb.ToString();
        }
    }
}