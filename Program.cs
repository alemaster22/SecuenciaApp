using System;

namespace SecuenciaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Secuencia App \n El siguiente programa permite la generación de una secuencia númerica dados dos valores enteros \n, uno de inicio y uno de fin ");

            GeneradorSeq();

            static void GeneradorSeq()
            {
                int num1, num2;
                
                try
                {
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Por favor digite un número para especificar el final de la secuencia seguido de la tecla intro: ");
                    num2 = int.Parse(Console.ReadLine());

                    if (num2 < num1)
                    {
                        Console.WriteLine("el número seleccionado como frontera superior de la secuencia debe ser mayor al número del comienzo de la secuencia ");
                        return;
                    }

                    for (int i=num1;i<=num2;i++) {
                        Console.WriteLine(i);
                    }

                }
                catch (FormatException eF)
                {
                    Console.WriteLine("La aplicación solo admite valores númericos");
                }
                catch (OverflowException oE)
                {
                    Console.WriteLine("Se ha introducido un valor muy alto , intente nuevamente");
                }
            }

        }
    }
}
