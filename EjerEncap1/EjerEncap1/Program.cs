using Entidades;
using System;

namespace EjerEncap1
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Perez", "Agustin", 12345);
            Alumno alumno2 = new Alumno("Garcia", "Jorge", 12346);
            Alumno alumno3 = new Alumno("Lopez", "Pablo", 12347);

            alumno1.Nota1 = 8;
            alumno2.Nota1 = 7;
            alumno3.Nota1 = 9;

            alumno1.Nota2 = 7;
            alumno2.Nota2 = 9;
            alumno3.Nota2 = 8;

            int notaFinal1 = alumno1.CalcularNotaFinal();
            int notaFinal2 = alumno2.CalcularNotaFinal();
            int notaFinal3 = alumno3.CalcularNotaFinal();

            Console.WriteLine("El alumno: " + alumno1.Apellido + ", " + alumno1.Nombre + " tiene como nota final: " + notaFinal1);
            Console.WriteLine("El alumno: " + alumno2.Apellido + ", " + alumno2.Nombre + " tiene como nota final: " + notaFinal2);
            Console.WriteLine("El alumno: " + alumno3.Apellido + ", " + alumno3.Nombre + " tiene como nota final: " + notaFinal3);
        }
    }
}
