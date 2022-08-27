namespace Actividad02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int cuadradoDelNumeroIngresado;
            int cuboDelNumeroIngresado;
            Console.WriteLine("Ingresa un numero");
            while (!int.TryParse(Console.ReadLine(), out numeroIngresado))
            {
                Console.WriteLine("Ingresa un numero correcto");
            }
            if(numeroIngresado > 0)
            {
                cuadradoDelNumeroIngresado = (int)Math.Pow(numeroIngresado, 2);
                cuboDelNumeroIngresado = (int)Math.Pow(numeroIngresado, 3);
                Console.WriteLine($"El cuadrado de {numeroIngresado} es: {cuadradoDelNumeroIngresado}");
                Console.WriteLine($"El cubo de {numeroIngresado} es: {cuboDelNumeroIngresado}");
            }


        }
    }
}