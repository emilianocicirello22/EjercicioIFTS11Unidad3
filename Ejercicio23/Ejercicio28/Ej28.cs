using System;
/*28)Calcular e informar el promedio de los números pares menores a un valor definido por el usuario. Dicho número 
 no debe ser superior a 1500.
*/
namespace Ejercicio28
{
    class Ej28
    {
        static void Main(string[] args)
        {
            //inicializamos variables
            int numero = 0;
            double promedio = 0;
            do
            {
                Console.WriteLine("ingrese un numero no mayor a 1500");
                numero = int.Parse(Console.ReadLine());
            } while (numero > 1500);
            for(int i=0; i < numero; i++)
            {
                if (i % 2 == 0)
                {
                    promedio ++;
                }
            }
            Console.WriteLine($"El promedio de pares es {(double)numero / promedio}");
        }
    }
}
