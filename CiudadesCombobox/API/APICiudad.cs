using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiudadesCombobox.API
{
    public static class APICiudad
    {

        // Directorio

        private const string DIRECTORIO = "Ciudades";

        public static string[] ConsultarDirectorio()
        {
            // RECURSOS 

            string[] ListaDirectorio;

            ListaDirectorio = Directory.GetFiles(DIRECTORIO);

            return ListaDirectorio;
        }

    }
}
