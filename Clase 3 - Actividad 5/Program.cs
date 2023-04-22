﻿namespace actividad5
{
    class Program
    {
        static void Main(string[] args) 
        {

            Console.WriteLine("Ingrese el numero mas alto para calcular la cantidad de numeros primos en ese rango");
            int maximo = int.Parse(Console.ReadLine());

            for (int i = 2; i <= maximo; i++)
            {
                bool esPrimo = true;

                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }

                if (esPrimo)
                {
                    Console.WriteLine(i + " es primo.");
                }
            }

        }
    }
}
