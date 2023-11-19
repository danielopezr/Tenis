using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenis
{
    // La clase Colision representa los límites de colisión de un objeto bidimensional con cuatro lados
    internal class Colision
    {
        public float izquierda { get; set; }
        public float derecha { get; set; }
        public float arriba { get; set; }
        public float abajo { get; set; }

        // Constructor de la clase que inicializa los límites de colisión con valores proporcionados
        public Colision (float izquierda, float derecha, float arriba, float abajo)
        {
            this.izquierda = izquierda;
            this.derecha = derecha;
            this.arriba = arriba;
            this.abajo = abajo;
        }
    }
}
