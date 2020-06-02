using System;

namespace Ejercicio25
{
    class Ej25
    {
        static void Main(string[] args)
        {
            //recorremos el for de 10 en 10
            for(int i = 0; i <= 1000; i += 10)
            {
                //imprimimos el valor de ticket
                Console.WriteLine($"Ticket numero {i}");
            }
        }
    }
}
