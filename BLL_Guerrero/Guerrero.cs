using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Guerrero
{
    public abstract class Guerrero
    {
        protected int idGuerrero;
        protected string nombre;
        protected int edad;
        protected int fuerza;
        protected bool herido;
        protected bool muerto;
        protected int tipoGuerrero;
        protected int ataque;
        protected static int i;

        public Guerrero()
        {
            
            Edad = 15;
            Fuerza = 1;
            this.nombre = "Guerrero" + ++i;
        }

        public Guerrero(string nombre, int edad, int fuerza)
        {
            this.nombre = nombre;

            if (ComprobarEdad(edad))
            {
                Edad = edad;
            }
            else
            {
                Edad = 25;
            }

            if (ComprobarFuerza(fuerza))
            {
                Fuerza = fuerza;
            }
            else
            {
                Fuerza = 5;
            }
        }


        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }

            set
            {
                edad = value;
            }
        }

        public int Fuerza
        {
            get
            {
                return fuerza;
            }

            set
            {
                fuerza = value;
            }
        }

        public bool Herido
        {
            get
            {
                return herido;
            }

            set
            {
                herido = value;
            }
        }

        public bool Muerto
        {
            get
            {
                return muerto;
            }

            set
            {
                muerto = value;
            }
        }

        public int TipoGuerrero
        {
            get
            {
                return tipoGuerrero;
            }

            set
            {
                tipoGuerrero = value;
            }
        }

        public int IdGuerrero { get => idGuerrero; set => idGuerrero = value; }
        public int Ataque { get => ataque; set => ataque = value; }

        public abstract bool retirarse();        

        public bool ComprobarEdad(int edad)
        {
            bool checkAge = false;

            if (edad <= 60 && edad >= 15)
            {                
                checkAge = true;
            }

            return checkAge;
        }

        public bool ComprobarFuerza(int fuerza)
        {
            bool checkForce = false;

            if (fuerza <= 10 && fuerza >= 1)
            {
                checkForce = true;
            }

            return checkForce;
        }
        
    }
}
