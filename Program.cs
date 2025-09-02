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
            /*
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

            int year;
            Console.WriteLine("Ingrese un año:");
            year = int.Parse(Console.ReadLine());
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if(year % 400 == 0)
                    {
                        Console.WriteLine("El año es bisiesto");
                    }
                    else
                    {
                        Console.WriteLine("El año no es bisiesto");
                    }
                }
                else
                {
                    Console.WriteLine("El año es bisiesto");
                }
            }
            else
            {
                Console.WriteLine("El año no es bisiesto");
            }

            int a;

            Console.WriteLine("Ingrese un número:");
            a = int.Parse(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("El número es positivo");
            }
            else if (a < 0)
            {
                Console.WriteLine("El número es negativo");
            }
            else 
            {
                Console.WriteLine("El número es cero");
            }
            

            int a;

            Console.WriteLine("Ingrese un número:");
            a = int.Parse(Console.ReadLine());
            
            if (a % 7 == 0 && a % 13 == 0)
            {
                Console.WriteLine("El número es divisible entre 7 y 13");
            }
            else if (a % 7 == 0)
            {
                Console.WriteLine("El número es divisible entre 7");
            }
            else if (a % 13 == 0)
            {
                Console.WriteLine("El número es divisible entre 13");
            }
            else
            {
                Console.WriteLine("El número no es divisible entre 7 ni 13");
            }
            

            int a;

            Console.WriteLine("Ingrese un número:");
            a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("El número es par");
            }
            else
            {
                Console.WriteLine("El número es impar");
            }
            

            float grade1, grade2, grade3, grade4;

            Console.WriteLine("Ingrese la primera nota:");
            grade1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota:");
            grade2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tercera nota:");
            grade3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota de jurado:");
            grade4 = float.Parse(Console.ReadLine());

            float classAverage = (grade1 + grade2 + 2 * grade3) / 4;
            float finalAverage = (2 * classAverage + grade4) / 3;

            Console.WriteLine($"El promedio es: {finalAverage} ");
            if (finalAverage >= 13)
            {
                Console.WriteLine("Aprobado");
            }
            else
            {
                Console.WriteLine("Desaprobado");
            }

            */

            bool continueFlag = true;

            while (continueFlag)
            {
                float a;
                float b;
                string operation;

                Console.WriteLine("Ingrese el primer número:");
                a = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número:");
                b = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la operación (+, -, *, /, %) o salir:");
                operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        Console.WriteLine($"{a} + {b} = {a + b}");
                        break;
                    case "-":
                        Console.WriteLine($"{a} - {b} = {a - b}");
                        break;
                    case "*":
                        Console.WriteLine($"{a} * {b} = {a * b}");
                        break;
                    case "/":
                        if (b != 0)
                        {
                            Console.WriteLine($"{a} / {b} = {a / b}");
                        }
                        else
                        {
                            Console.WriteLine("No se puede dividir por cero");
                        }
                        break;
                    case "%":
                        if (b != 0)
                        {
                            Console.WriteLine($"{a} % {b} = {a % b}");
                        }
                        else
                        {
                            Console.WriteLine("No se puede dividir por cero");
                        }
                        break;
                    case "salir":
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("Operación no válida");
                        break;
                }
            }


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
