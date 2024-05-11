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

                // Asignará el contenido del direcotio al combobox
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
            Button boton = (Button)sender;

            try
            {
                switch (boton.Name)
                {
                    case "buttonAgregar":
                        APICiudad.EscribirFichero(comboBoxProvincias.SelectedItem.ToString(), textBoxAgregarCiudad.Text);
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
            }

        }
    }
}
