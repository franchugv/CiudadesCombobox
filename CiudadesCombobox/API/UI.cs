using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiudadesCombobox.API
{
    public static class UI
    {
        public static void MostrarError(string error)
        {
            MessageBox.Show($"Error: {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
