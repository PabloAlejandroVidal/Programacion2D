namespace Actividad04
{
    /*
     Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) que son divisores del número.

    El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
     
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma;
            int cantNumAEncontrar;
            int cantNumEncontrados;
            int numeroPerfecto;
            int divisor;

            cantNumAEncontrar = 4;
            cantNumEncontrados = 0;
            numeroPerfecto = 1;

            Console.WriteLine("Lista de numeros Perfectos");
            Console.WriteLine();

            while (cantNumEncontrados != cantNumAEncontrar)
            {
                suma = 0;
                divisor = 1;

                while(numeroPerfecto != divisor)
                {
                    if (numeroPerfecto % divisor == 0)
                    {
                        suma += divisor;
                    }
                    divisor++;
                }

                if(suma == numeroPerfecto)
                {
                    Console.WriteLine("Numero Perfecto: " + numeroPerfecto);
                    cantNumEncontrados++;
                }
                numeroPerfecto++;
            }
        }
    }
}