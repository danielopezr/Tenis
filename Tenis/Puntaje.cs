using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenis
{
    // Clase que representa un registro de puntaje en el juego para dos jugadores, incluyendo sus nicknames, puntajes y la fecha de registro
    internal class Puntaje
    {
        public String nickname1 { get; set; }
        public int puntuacion1 { get; set; }
        public String nickname2 { get; set; }
        public int puntuacion2 { get; set; }
        public DateTime fecha { get; set; }

        // Constructor que inicializa las propiedades del Puntaje
        public Puntaje(String nickname1, int puntuacion1, String nickname2, int puntuacion2, DateTime fecha)
        {
            this.nickname1 = nickname1;
            this.puntuacion1 = puntuacion1;
            this.nickname2 = nickname2;
            this.puntuacion2 = puntuacion2;
            this.fecha = fecha;
        }
    }
}
