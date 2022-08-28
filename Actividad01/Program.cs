namespace Actividad01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minValorIngresado;
            int maxValorIngresado;
            int sumaValorIngresado;
            int promedioValorIngresado;
            int valorIngresado;
            sumaValorIngresado = 0;

            Console.WriteLine("Ingrese un valor");
            while (!(int.TryParse(Console.ReadLine(), out valorIngresado)))
            {
                Console.WriteLine("Ingrese un valor valido");

            }
            minValorIngresado = valorIngresado;
            maxValorIngresado = valorIngresado;
            sumaValorIngresado += valorIngresado;

            for(int i = 0; i < 4; i++){
                Console.WriteLine("Ingrese un valor");
                while (!(int.TryParse(Console.ReadLine(), out valorIngresado)))
                {
                    Console.WriteLine("Ingrese un valor valido");
                }
                if (valorIngresado < minValorIngresado)
                {
                    minValorIngresado = valorIngresado;
                }
                if (valorIngresado > maxValorIngresado)
                {
                    maxValorIngresado = valorIngresado;
                }
                sumaValorIngresado += valorIngresado;
            }

            promedioValorIngresado = (sumaValorIngresado / 5);

            Console.WriteLine($"El valor minimo es {minValorIngresado}");
            Console.WriteLine($"El valor maximo es {maxValorIngresado}");
            Console.WriteLine($"El valor promedio es {promedioValorIngresado}");
        }
    }
}