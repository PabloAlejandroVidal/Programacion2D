namespace Actividad03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lineaIngresada;
            int numeroIngresado;

            Console.WriteLine("Se mostraran los numeros primos hasta el numero ingresado");

            do
            {
                Console.WriteLine("Ingresa numero o ingresa [salir] para finalizar");
                lineaIngresada = Console.ReadLine();

                if (int.TryParse(lineaIngresada, out numeroIngresado))
                {

                    for(int i = 1; i <= numeroIngresado; i++)
                    {
                        int j;
                        for (j = 2; j <= i; j++)
                        {
                            if (i % j == 0)
                            {
                                if(i == j)
                                {
                                    Console.WriteLine(i);
                                }
                                break;
                            }
                        }
                        
                        
                        
                    }
                }
                else
                {
                    if(lineaIngresada != "salir")
                    {
                        Console.WriteLine(lineaIngresada + " No es un opcion valida");
                    }
                    else
                    {
                        Console.WriteLine("Programa finalizado");
                    }
                }

            } while (lineaIngresada != "salir");

        }
    }
}