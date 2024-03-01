using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planetss
{
    internal class Pianeta
    {
        public double Massa { get; set; }
        public Vector Posizione { get; set; }
        public Vector Velocita { get; set; }
        public Vector Accelerazione { get; set; }
        public Color Colore { get; set; }

        public Pianeta(double massa, Vector posizione, Vector velocita, Color colore)
        {
            Massa = massa;
            Posizione = posizione;
            Velocita = velocita;
            Colore = colore;
        }

    }
}
