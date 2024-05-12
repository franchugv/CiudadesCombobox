using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiudadesCombobox
{
    public static class Validacion
    {
        public static void ValidarRepeticon(string nombre, string[]Lista)
        {

            nombre = nombre.Trim().ToLower();

            for(int indice = 0; indice < Lista.Length; indice++)
            {
                Lista[indice] = Lista[indice].Trim().ToLower();
            }

            for (int indice = 0; indice < Lista.Length; indice++)
            {
                if (nombre.Contains(Lista[indice])) throw new FormatException("Localidad repetida");
            }

        }

        public static void ValidarCadena(string cadena)
        {
            const int MIN_TAM = 3;

            if (cadena.Length < MIN_TAM) throw new FormatException("La cadena tiene un tamaño inferior al permitido");
        }
    }
}
