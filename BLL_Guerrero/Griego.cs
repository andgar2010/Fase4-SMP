using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Guerrero
{
    public class Griego : Guerrero
    {
        public Griego()
        {
            tipoGuerrero = 1;
        }

        public Griego(string nombre, int edad, int fuerza) :base(nombre, edad, fuerza)
        {
            tipoGuerrero = 1;
        }

        public override bool retirarse()
        {
            if (Herido)
            {
                Muerto = true;
            }

            return Muerto;
        }
    }
}
