using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace planetss
{
    internal class Planetario
    {
        public List<Pianeta> Pianeti { get; set; }
        public double G { get; set; } = 6.67;
        public double DeltaT { get; set; }

        public Vector ForzaG(Pianeta p, Pianeta p1)
        {
            double forzag = (G * p.Massa * p1.Massa) / Math.Pow((p1.Posizione - p.Posizione).Modulo(), 2);
            return forzag * (p1.Posizione - p.Posizione).Versore();
        }
         public Vector ForzaTot(Pianeta p)
        {
            Vector ftot = Vector.Parse("0;0");
            foreach(Pianeta p1 in Pianeti)
            {
                if (p1 == p)
                    continue;
                ftot = ftot + ForzaG(p, p1);
            }
            return ftot;
        }

         public void Muovi()
        {
            //nuova posizione per ogni pianeta
            foreach(Pianeta p in Pianeti)
            {
                p.Accelerazione = ForzaTot(p) / p.Massa;
            }
            foreach(Pianeta p in Pianeti)
            {
                p.Posizione = p.Posizione + p.Velocita * DeltaT + 0.5 * p.Accelerazione * DeltaT * DeltaT;
            }
           
        }
    }
}
