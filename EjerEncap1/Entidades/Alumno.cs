using System;

namespace Entidades
{
    public class Alumno
    {
        private int nota1;
        private int nota2;
        private string apellido;
        private string nombre;
        private int legajo;
        public Alumno(string apellido, string nombre, int legajo)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
        }

        public int Nota1
        {
            get 
            {
                return nota1;
            }
            
            set
            {
                if(value >= 0 && value <= 10)
                {
                    nota1 = value;
                }
                else
                {
                    nota1 = 0;
                }
            }
        }

        public int Nota2
        {
            get
            {
                return nota2;
            }

            set
            {
                if (value >= 0 && value <= 10)
                {
                    nota2 = value;
                }
                else
                {
                    nota2 = 0;
                }
            }
        }

        public string Apellido
        { 
            get {
                return apellido;
            }
        }
        public string Nombre
        {
            get {
                return nombre;
            }
        }
        public int Legajo
        {
            get {
                return legajo;
            }
        }

        public int CalcularNotaFinal()
        {
            if (nota1 > 4 && nota2 > 4)
            {
                return (nota1 + nota2) / 2; 
            }
            else
            {
                return 2; 
            }
        }
    }
}
