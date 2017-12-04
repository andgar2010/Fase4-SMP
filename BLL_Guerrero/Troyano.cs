using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Guerrero
{
    public class Troyano : Guerrero
    {
        public Troyano()
        {
            tipoGuerrero = 2;
        }

        public Troyano(string nombre, int edad, int fuerza) : base(nombre, edad, fuerza)
        {
            tipoGuerrero = 2;
        }

        public override bool retirarse()
        {
            return Muerto;
        }
    }
}
