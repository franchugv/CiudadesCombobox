﻿using System;
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
            // En caso de que no exista, se creará automáticamente
            if (!Directory.Exists(DIRECTORIO)) CrearDirectorio();
        }

        public static string[] ConsultarDirectorio()
        {
            // RECURSOS 

            string[] ListaDirectorio;
            string cadena;

            ListaDirectorio = Directory.GetFiles(DIRECTORIO);

            // Pasar de: Ciudades\Ciudad.txt a Ciudad
            for (int indice = 0; indice < ListaDirectorio.Length; indice++)
            {
                cadena = ListaDirectorio[indice];

                cadena = cadena.Substring(cadena.IndexOf("\\") + 1);
                cadena = cadena.Substring(0, cadena.IndexOf(".")); // Con es 0 estamos estableciendo el Índice desde el principio

                ListaDirectorio[indice] = cadena;
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




        public static void EscribirFichero(string nombre, string texto)
        {
            // Recursos
            StreamWriter escritor;

            
            escritor = File.AppendText(DIRECTORIO + nombre + EXTENSION);

            escritor.WriteLine(texto);

            escritor.Close();
        }

    }
}
