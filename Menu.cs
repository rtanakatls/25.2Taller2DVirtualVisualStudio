using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2D252
{
    internal class Menu
    {
        private List<Student> students;
        public void Execute()
        {
            ShowMenu();
        }

        private void ShowMenu()
        {
            bool continueFlag = true;
            students = new List<Student>();
            while (continueFlag)
            {
                Console.WriteLine("Selecciona una opción:");
                Console.WriteLine("1. Ingresar estudiante");
                Console.WriteLine("2. Mostrar todos los estudiantes");
                Console.WriteLine("0. Salir");
                string option = Console.ReadLine();
                switch(option)
                {
                    case "1":
                        Student student = CreateStudent();
                        students.Add(student);
                        break;
                    case "2":
                        ShowAllStudents();
                        break;
                    case "0":
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
        }

        private void ShowAllStudents()
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.GetData());
            }
        }

        private Student CreateStudent()
        {
            string code;
            string name;
            float grade1;
            float grade2;
            float grade3;
            Console.WriteLine("Ingrese el código del estudiante:");
            code = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del estudiante:");
            name = Console.ReadLine();
            Console.WriteLine("Ingrese la primera nota:");
            grade1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota:");
            grade2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tercera nota:");
            grade3 = float.Parse(Console.ReadLine());
            return new Student(code, name, grade1, grade2, grade3);
        }

    }
}
