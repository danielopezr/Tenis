using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenis
{
    public partial class Final : Form
    {
        List<Puntaje> mejoresPuntajes = new List<Puntaje>();

        // Constructor que inicializa el formulario y muestra al ganador.
        public Final(String ganador)
        {
            InitializeComponent();

            lblGanador.Text = ganador;
            cargarPuntajes();
        }

        // Método que carga los mejores puntajes desde el archivo .txt
        private void cargarPuntajes()
        {
            // Lee el archivo para cargar la lista de puntajes existente en la lista mejoresPuntajes
            using (StreamReader reader = new StreamReader("mejores_puntajes.txt"))
            {
                String linea;

                while ((linea = reader.ReadLine()) != null)
                {
                    String[] partes = linea.Split(',');

                    if (partes.Length == 5)
                    {
                        String nickname1 = partes[0];
                        int puntuacion1 = int.Parse(partes[1]);
                        String nickname2 = partes[2];
                        int puntuacion2 = int.Parse(partes[3]);
                        DateTime fecha = DateTime.Parse(partes[4]);

                        mejoresPuntajes.Add(new Puntaje(nickname1, puntuacion1, nickname2, puntuacion2, fecha));
                    }
                }
            }

            // Construye el texto que muestra los mejores puntajes en la etiqueta lblMejoresPuntajes
            String puntajesTexto = "Mejores puntajes:\n";
            foreach (Puntaje puntaje in mejoresPuntajes)
            {
                string puntajeFormatado = $"{puntaje.nickname1} {puntaje.puntuacion1} - {puntaje.puntuacion2} {puntaje.nickname2} en {puntaje.fecha:yyyy/MM/dd}\n";

                puntajesTexto += puntajeFormatado;
            }
            lblMejoresPuntajes.Text = puntajesTexto;
        }

        // Maneja el evento Click del botón "Volver" para regresar al formulario de inicio
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }
    }
}
