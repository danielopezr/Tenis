using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Tenis
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        // Maneja el evento Click del botón "Inicio" para ir al formulario de juego.
        private void btnInicio_Click(object sender, EventArgs e)
        {
            // Verifica si los espacios de texto están vacíos y asigna valores predeterminados
            if (string.IsNullOrWhiteSpace(nickname1.Text))
            {
                nickname1.Text = "GHEST1";
            }
            if (string.IsNullOrWhiteSpace(nickname2.Text))
            {
                nickname2.Text = "GHEST2";
            }

            // Crea una instancia del formulario Juego, pasando el array con los nombres de usuario como parámetro
            String[] nickname = { nickname1.Text, nickname2.Text };
            Juego juego = new Juego(nickname);
            juego.Show();
            this.Hide();
        }

        // Evita que se ingresen caracteres que no son letras (excepto la tecla de retroceso)
        private void nickname1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            if (nickname1.Text.Length >= 5 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void nickname2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            if (nickname2.Text.Length >= 5 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        // Convierte automáticamente el texto ingresado a mayúsculas y establece el cursor al final del texto
        private void nickname1_TextChanged(object sender, EventArgs e)
        {
            nickname1.Text = nickname1.Text.ToUpper();
            nickname1.SelectionStart = nickname1.Text.Length;
        }

        private void nickname2_TextChanged(object sender, EventArgs e)
        {
            nickname2.Text = nickname2.Text.ToUpper();
            nickname2.SelectionStart = nickname2.Text.Length;
        }
    }
}
