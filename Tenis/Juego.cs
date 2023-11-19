using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenis
{
    public partial class Juego : Form
    {
        List<Puntaje> mejoresPuntajes = new List<Puntaje>();
        int velocidadHorizontal = 1;
        int velocidadVertical = 1;
        bool puntoJugador;

        // Constructor que inicializa el formulario y muestra los jugadores
        public Juego(String[] nickname)
        {
            InitializeComponent();
            lblJugador1.Text = nickname[0];
            lblJugador2.Text = nickname[1];
        }

        // Maneja el evento KeyDown para mover la raqueta1 con las teclas W y S
        private void Juego_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                raqueta1.Top = raqueta1.Top - 33;
            }

            if (e.KeyCode == Keys.S)
            {
                raqueta1.Top = raqueta1.Top + 33;
            }
        }

        // Maneja el evento MouseMove para mover la raqueta2 con el movimiento del ratón
        private void Juego_MouseMove(object sender, MouseEventArgs e)
        {
            raqueta2.Top = e.Location.Y;
        }

        // Maneja el evento Tick del temporizador para actualizar la posición de la pelota y verificar colisiones
        private void timer_Tick(object sender, EventArgs e)
        {
            pelota.Left = pelota.Left + velocidadHorizontal;
            pelota.Top = pelota.Top + velocidadVertical;
            colisiones();
            terminarJuego();
        }

        // Verifica las colisiones entre la pelota, las raquetas y los bordes de la ventana
        private void colisiones()
        {
            // Crear objetos de colisión para la raqueta izquierda, la raqueta derecha, la pelota y los bordes de la ventana
            Colision raquetaIzquierda = new Colision(raqueta1.Left, raqueta1.Left + raqueta1.Width, raqueta1.Top, raqueta1.Top + raqueta1.Height);
            Colision raquetaDerecha = new Colision(raqueta2.Left, raqueta2.Left + raqueta2.Width, raqueta2.Top, raqueta2.Top + raqueta2.Height);
            Colision bola = new Colision(pelota.Left, pelota.Left + pelota.Width, pelota.Top, pelota.Top + pelota.Height);
            Colision ventana = new Colision(0, this.Size.Width - pelota.Width - 13, 0, this.Size.Height - pelota.Height - 37);

            // Colision de la pelota con la raqueta izquierda
            if (bola.izquierda <= raquetaIzquierda.derecha && bola.derecha >= raquetaIzquierda.izquierda && bola.arriba <= raquetaIzquierda.abajo && bola.abajo >= raquetaIzquierda.arriba)
            {
                velocidadHorizontal = (velocidadHorizontal + 1);
            }

            // Colision de la pelota con la raqueta derecha
            if (bola.izquierda <= raquetaDerecha.derecha && bola.derecha >= raquetaDerecha.izquierda && bola.arriba <= raquetaDerecha.abajo && bola.abajo >= raquetaDerecha.arriba)
            {
                velocidadHorizontal = ((velocidadHorizontal + 1) * (-1));
            }

            // Colision de la pelota con el lado izquierdo de la ventana
            if (pelota.Left <= ventana.izquierda)
            {
                reiniciar();
                puntoJugador = false;
                actualizarPuntaje();
            }

            // Colision de la pelota con el lado derecho de la ventana
            if (pelota.Left >= ventana.derecha)
            {
                reiniciar();
                puntoJugador = true;
                actualizarPuntaje();
            }

            // Colision de la pelota con el lado superior de la ventana
            if (pelota.Top <= ventana.arriba)
            {
                velocidadVertical = (velocidadVertical + 1);
            }

            // Colision de la pelota con el lado inferior de la ventana
            if (pelota.Top >= ventana.abajo)
            {
                velocidadVertical = ((velocidadVertical + 1) * (-1));
            }
        }

        // Actualiza los puntajes en la interfaz de usuario
        public void actualizarPuntaje()
        {
            int nuevoValor;

            if (puntoJugador)
            {
                nuevoValor = int.Parse(lblPuntos1.Text) + 1;
                lblPuntos1.Text = nuevoValor.ToString();
            }
            if (!puntoJugador)
            {
                nuevoValor = int.Parse(lblPuntos2.Text) + 1;
                lblPuntos2.Text = nuevoValor.ToString();
            }
        }

        // Registra el puntaje actual y actualiza el archivo de mejores puntajes
        private void registrarPuntaje()
        {
            // Lee el archivo .txt para cargar la lista de puntajes existente en la lista mejoresPuntajes
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

            // Agregar el puntaje actual a la lista de puntajes
            Puntaje nuevoPuntaje = new Puntaje(lblJugador1.Text, int.Parse(lblPuntos1.Text), lblJugador2.Text, int.Parse(lblPuntos2.Text), DateTime.Now);
            mejoresPuntajes.Add(nuevoPuntaje);

            // Ordenar la lista de puntajes de mejor a peor, si la lista contiene más de 5 puntajes, eliminar el puntaje más bajo
            mejoresPuntajes = mejoresPuntajes.OrderBy(p => Math.Min(p.puntuacion1, p.puntuacion2)).ToList();
            if (mejoresPuntajes.Count > 5)
            {
                mejoresPuntajes.RemoveAt(5);
            }

            using (StreamWriter writer = new StreamWriter("mejores_puntajes.txt"))
            {
                // Recorre la lista de puntajes y escribe cada puntaje en una línea del archivo .txt
                foreach (Puntaje puntaje in mejoresPuntajes)
                {
                    String linea = $"{puntaje.nickname1},{puntaje.puntuacion1},{puntaje.nickname2},{puntaje.puntuacion2},{puntaje.fecha}";
                    writer.WriteLine(linea);
                }
            }
        }

        // Finaliza el juego cuando se alcanza un puntaje de 10 y muestra el formulario Final.
        public void terminarJuego()
        {
            if (int.Parse(lblPuntos1.Text) == 10 || int.Parse(lblPuntos2.Text) == 10)
            {
                String ganador = "Nadie";
                timer.Enabled = false;
                registrarPuntaje();

                if (int.Parse(lblPuntos1.Text) == 10)
                {
                    ganador = lblJugador1.Text;
                }
                if (int.Parse(lblPuntos2.Text) == 10)
                {
                    ganador = lblJugador2.Text;
                }

                // Crea una instancia del formulario Final, pasando el nombre del ganador como parámetro
                Final final = new Final(ganador);
                final.Show();
                this.Close();
            }
        }

        // Reinicia la posición de la pelota y asigna una dirección aleatoria.
        private void reiniciar()
        {
            pelota.Left = 300;
            pelota.Top = 180;

            Random random = new Random();
            velocidadHorizontal = random.Next(0, 2) == 0 ? -1 : 1;
            velocidadVertical = random.Next(0, 2) == 0 ? -1 : 1;
        }
    }
}
