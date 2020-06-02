using System;
using System.Net.Sockets;
/*26)Calcular e informar el factorial de un número positivo. (El Factorial de un número entero positivo se define como 
n!=1*2*3….(n-2)*(n-1)*n. También se define que el factorial de 0=1 --> 0!=1)
Utilizar un ciclo repetir para la lectura del dato con el fin de no permitir avanzar hasta que no se ingrese un 
número mayor o igual que 0.*/

namespace Ejercicio26
{
    class Ej26
    {
        static void Main(string[] args)
        {
            //inicializamos variables
            int nro = 0,factorial = 0;

            //ingresamos los datos con una validacion
            do
            {
                Console.WriteLine("Ingrese un numero mayor o igual a 0");
                nro = int.Parse(Console.ReadLine());
            } while (nro < 0);

            //asignamos el numero a la variable factorial para calcular
            factorial = nro;

            //calculamos el factorial 
            if (nro == 0)
            {
                //si es 0 mostramos el resultado
                Console.WriteLine($"El factorial de {factorial} != 1");

            }
            else
            {
                //seteamos al la variable nro para poder multiplicarla
                nro = 1;
                //sino calculamos el factorial
                for(int i=1; i<factorial; i++)
                {
                    nro += nro * i;
                }
                //mostramos el resultado
                Console.WriteLine($"el factorial de {factorial} != {nro}");
            }

            

        }
    }
}
