using CiudadesCombobox.API;
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
    public partial class Form1 : Form
    {
        public Form1()
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

            string[] ListaCiudades = comboBoxCiudades.Items.Cast<string>().ToArray();
            string ContenidoAgregarCiudad = textBoxAgregarCiudad.Text;
            string ContenidoSeleccionadoCBProvincias = comboBoxProvincias.SelectedItem.ToString();

            Button boton = (Button)sender;

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
                }
            }

        }

        private void textBoxAgregarCiudad_Leave(object sender, EventArgs e)
        {
             // Recursos
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
                    UI.MostrarError(mensajeError);
                    textBoxAgregarCiudad.Focus();
                }
            }
        }


        // Funcionalidades Botones
        private static void AgregarCiudad(string[] ListaCiudades, string ContenidoAgregarCiudad, string ContenidoSeleccionadoCBProvincias)
        {
            Validacion.ValidarRepeticon(ContenidoAgregarCiudad, ListaCiudades);
            APICiudad.EscribirFichero(ContenidoSeleccionadoCBProvincias, ContenidoAgregarCiudad);
            UI.MostrarMensaje($"La Ciudad {ContenidoAgregarCiudad} a sido agregada correctamente");
        }


    }
}
