using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2D252
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a;
            float b;

            Console.WriteLine("Ingrese el valor de a:");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de b:");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine($"a + b = {a + b}");
            Console.WriteLine($"a - b = {a - b}");
            Console.WriteLine($"a * b = {a * b}");

            if (b != 0)
            {
                Console.WriteLine($"a / b = {a / b}");
                Console.WriteLine($"a % b = {a % b}");
            }
            else
            {
                Console.WriteLine("No se puede dividir por cero");
            }

            float d;

            Console.WriteLine("Ingrese el número de días: ");
            d=float.Parse(Console.ReadLine());

            Console.WriteLine($"{d} días son {d/7} semanas");
            Console.WriteLine($"{d} días son {d/365} años");


            /*
            string name;
            int age = 0;
            bool isCorrect = false;
            
            Console.WriteLine("Bienvenido, indícamente tu nombre:");
            name = Console.ReadLine();
            Console.WriteLine($"Hola {name}");

            while (!isCorrect)
            {
                Console.WriteLine("Indícame tu edad:");
                age = int.Parse(Console.ReadLine());
                Console.WriteLine($"Tu edad es {age}");

                if (age >= 0 & age < 18)
                {
                    Console.WriteLine("Eres menor de edad y no puedes tomar alcohol");
                    isCorrect = true;
                }
                else if (age >= 18)
                {
                    Console.WriteLine("Eres mayor de edad y puedes tomar alcohol");
                    isCorrect = true;
                }
                else
                {
                    Console.WriteLine("La edad ingresada no es válida");
                }
            }

            string option;
            Console.WriteLine("Escribe una opción:");
            Console.WriteLine("1. Saber a qué edad terminarás la carrera");
            Console.WriteLine("2. Saber cuántos años faltan para que seas mayor de edad");
            option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.WriteLine($"Terminarás la carrera a los {age + 3} años");
                    break;
                case "2":
                    if (age < 18)
                    {
                        Console.WriteLine($"Faltan {18 - age} para que seas mayor");
                    }
                    else
                    {
                        Console.WriteLine("Ya eres mayor de edad");
                    }
                    break;
            }
            */
        }
    }
}
