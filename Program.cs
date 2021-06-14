using System;

namespace ExercicioPesoIdeal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Double altura , pesoIdeal;
            string sexo;
            
            Console.WriteLine("Simulador de peso ideal\n");

            Console.Write("Digite sua altura em m.........: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Digite seu sexo ('M' para masculino, 'F' para feminino) ");
            sexo = Console.ReadLine();
            
            Console.WriteLine();
            
            if (sexo == "m" || sexo == "M")
            {
               pesoIdeal = altura * 72.7 - 58.0;

               Console.WriteLine($"Seu peso ideal é {pesoIdeal:N1}kg");

            }

            else if (sexo == "F" || sexo == "f")
            {
                pesoIdeal = altura * 62.1 - 44.7;

                Console.WriteLine($"Seu peso ideal é {pesoIdeal:N1}kg");
                
            }

                else 
                {
                    Console.WriteLine($"O sexo informado ({sexo}) é inválido");
                }
            
           Console.WriteLine("\nObrigado por utilizar nosso programa!!");



            
        }
    }
}
