using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2D252.School
{
    internal class SchoolMenu
    {
        private List<Classroom> classrooms;

        public SchoolMenu()
        {
            classrooms = new List<Classroom>();
        }

        public void Execute()
        {
            ShowClassroomMenu();
        }

        private void ShowClassroomMenu()
        {
            bool continueFlag = true;
            while(continueFlag)
            {
                Console.WriteLine("Selecciona una opción:");
                Console.WriteLine("1. Crear aula");
                Console.WriteLine("2. Seleccionar salón");
                Console.WriteLine("0. Salir");

                string option = Console.ReadLine();
                switch(option)
                {
                    case "1":
                        CreateClassroom();
                        break;
                    case "2":
                        ShowAllClassrooms();
                        SelectClassroom();
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


        private void CreateClassroom()
        {
            Console.WriteLine("Introduce el nombre del aula:");
            string name = Console.ReadLine();
            Classroom classroom = new Classroom(name);
            classrooms.Add(classroom);
            Console.WriteLine($"Aula {name} creada.");
        }

        private void ShowAllClassrooms()
        {
            for(int i=0;i<classrooms.Count;i++)
            {
                Console.WriteLine($"{i}. {classrooms[i].Name}");
            }
        }

        private void SelectClassroom()
        { 
            Console.WriteLine("Selecciona el número del aula:");
            int index = int.Parse(Console.ReadLine());
            if(index >= 0 && index < classrooms.Count)
            {
                Classroom selectedClassroom = classrooms[index];
                ShowStudentMenu();
            }
            else
            {
                Console.WriteLine("Índice no válido.");
            }
        }


        private void ShowStudentMenu()
        {
            bool continueFlag = true;
            while(continueFlag)
            {
                Console.WriteLine("Selecciona una opción:");
                Console.WriteLine("1. Añadir alumno al salón");
                Console.WriteLine("2. Remover alumno del salón");
                Console.WriteLine("3. Mostrar la cantidad de aprobados");
                Console.WriteLine("0. Salir");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        break;
                    case "2":
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

    }
}
