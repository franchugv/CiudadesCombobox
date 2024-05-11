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


        public static void EscribirFichero(string nombre, string texto)
        {
            // Recursos
            StreamWriter escritor;

            escritor = File.AppendText(nombre);

            escritor.WriteLine(texto);

            escritor.Close();
        }

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

            // Pasar de: Ciudades\Ciudad.txt a Ciudad
            for (int indice = 0; indice < ListaDirectorio.Length; indice++)
            {
                ListaDirectorio[indice] = ListaDirectorio[indice].Substring(ListaDirectorio[indice].IndexOf('\\') + 1, ListaDirectorio[indice].IndexOf('.') - ListaDirectorio[indice].IndexOf('\\') - 1);
            }



            return ListaDirectorio;
        }

        public static string[] ConsultarFichero(string nombre)
        {
            // Recursos
            string[] ListaCiudades;


            // Contenido del fichero al array
            ListaCiudades = File.ReadAllLines(DIRECTORIO+nombre+EXTENSION);



            return ListaCiudades;

        }

    }
}
