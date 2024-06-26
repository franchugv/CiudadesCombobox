﻿using CiudadesCombobox.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiudadesCombobox
{
    public partial class FormCiudades : Form
    {
        public FormCiudades()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Recursos
            string mensajeError = "";
            bool esValido = true; // Inicializado previamente

            try
            {

                // En caso de que no exista, se creará automaticamente
                APICiudad.ValidarExistenciaDirectorio();

                // Asignará el contenido del directorio al combobox
                comboBoxProvincias.Items.AddRange(API.APICiudad.ConsultarDirectorio());

            }
            catch (Exception error) 
            { 
                esValido = false;
                mensajeError = error.Message;
            }
            finally
            {
                if (!esValido) UI.MostrarError(mensajeError);
            }
        }

        private void Controlador_Click(object sender, EventArgs e)
        {
            // Recursos
            string mensajeError = "";
            bool esValido = true; // Inicializado previamente

            // Inicializar variables con el contenido de los contenedores

            // Inicializamos un array con el contenido del comboBox de ciudades: Málaga, Sevilla...
            string[] ListaCiudades = comboBoxCiudades.Items.Cast<string>().ToArray();

            // Inicializamos esta cadena con el contenido del textBox: Cabra, Baena...
            string ContenidoAgregarCiudad = textBoxAgregarCiudad.Text;

            // Inicializamos esta cadena con el Item seleleccionado del comBoBox provincias
            string ContenidoSeleccionadoCBProvincias = comboBoxProvincias.SelectedItem.ToString();

            Button boton = (Button)sender;


            // Inicializamos los objetos a false
            buttonAgregar.Enabled = false;
            textBoxAgregarCiudad.Enabled = false;
            comboBoxCiudades.Enabled = false;


            try
            {
                switch (boton.Name)
                {
                    case "buttonAgregar":
                        AgregarCiudad(ListaCiudades, ContenidoAgregarCiudad, ContenidoSeleccionadoCBProvincias);
                        textBoxAgregarCiudad.Clear();
                        break;
                }              
            }
            catch (Exception error)
            {
                esValido = false;
                mensajeError = error.Message;
            }
            finally
            {
                if (!esValido) UI.MostrarError(mensajeError);
            }
        }


        private void comboBoxProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Recurosos
            string mensajeError = "";
            bool esValido = true; // Inicializado previamente

            comboBoxCiudades.Items.Clear(); // Limpiamos el comboBox cada vez que cambiemos de provincia
            comboBoxCiudades.Text = "";

            try 
            { 
            // Cargar valores del archivo provincia en ComboBoxCiudades
            comboBoxCiudades.Items.AddRange(APICiudad.ConsultarFichero(comboBoxProvincias.SelectedItem.ToString()));
            }
            catch (Exception error)
            {
                esValido = false;
                mensajeError = error.Message;
            }
            finally
            {
                if (!esValido) UI.MostrarError(mensajeError);
                else
                {
                    buttonAgregar.Enabled = true; // Activa el botón una vez seleccionemos una provincia
                    textBoxAgregarCiudad.Enabled = true;
                    comboBoxCiudades.Enabled = true;
                }
            }

        }

        private void textBoxAgregarCiudad_Leave(object sender, EventArgs e)
        {
            // Recursos
            labelError.Text = "";
            string mensajeError = "";
            bool esValido = true; // Inicializado previamente

            try
            {
                Validacion.ValidarCadena(textBoxAgregarCiudad.Text);
            }
            catch (Exception error)
            {
                esValido = false;
                mensajeError = error.Message;
            }
            finally
            {
                if (!esValido)
                {
                    labelError.Text = mensajeError;
                    textBoxAgregarCiudad.Clear(); // Lo limpiamos para que el usuario no pueda guardar cadenas incorrectas
                    // textBoxAgregarCiudad.Focus(); Es demasiado molesto

                }
            }
        }


        // Funcionalidades Botones
        private static void AgregarCiudad(string[] ListaCiudades, string ContenidoAgregarCiudad, string ContenidoSeleccionadoCBProvincias)
        {
            // Validar Nombre de ciudad, Bien --> Málaga, Mal --> a o ""
            Validacion.ValidarCadena(ContenidoAgregarCiudad);

            // Valida que no se repita la ciudad proporcionada
            Validacion.ValidarRepeticon(ContenidoAgregarCiudad, ListaCiudades);

            // Añade una ciudad en el fichero seleccionado
            APICiudad.EscribirFichero(ContenidoSeleccionadoCBProvincias, ContenidoAgregarCiudad);

            // Muestra un mensaje de enhorabuenaz
            UI.MostrarMensaje($"La Ciudad {ContenidoAgregarCiudad} a sido agregada correctamente");
        }


    }
}

