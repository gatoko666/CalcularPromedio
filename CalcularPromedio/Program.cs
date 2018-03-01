using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//9) Escribir un método que acepte una lista de números y devuelva su promedio.


namespace CalcularPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                try
                {
                    double suma=0.0, promedio = 1;
                    int contador;

                    Console.WriteLine("Ingrese la cantidad de números que desea calcular el promedio: ");
                    int numero = int.Parse(Console.ReadLine());                  


                    for (int i = 1; i <= numero; i++)
                    {
                        Console.WriteLine("Ingrese un número  "+i +":");
                        double calcular = double.Parse(Console.ReadLine());
                        suma = suma + calcular;                      

                    }
                    promedio = suma / numero;
                    Console.WriteLine("el promedio es : "+promedio);
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Escribe algún valor válido");
                }

            }

        }
    }
}
