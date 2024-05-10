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

        private const string DIRECTORIO = "Ciudades\\";
        private const string EXTENSION = ".txt";



       private static void CrearDirectorio()
        {
            Directory.CreateDirectory(DIRECTORIO);          
        }
        public static void ValidarExistenciaDirectorio()
        {
            // En caso de que no exista, se creará automaticamente
            if (!Directory.Exists(DIRECTORIO)) CrearDirectorio();
        }

        public static string[] ConsultarDirectorio()
        {
            // RECURSOS 

            string[] ListaDirectorio;


            ListaDirectorio = Directory.GetFiles(DIRECTORIO);

            return ListaDirectorio;
        }

        public static string[] ConsultarFichero(string nombre)
        {
            // Recursos
            string[] ListaCiudades;


            // Contenido del fichero al array
            ListaCiudades = File.ReadAllLines(nombre);

            return ListaCiudades;

        }

    }
}
