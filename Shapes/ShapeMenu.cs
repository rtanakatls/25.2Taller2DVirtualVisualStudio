using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2D252.Shapes
{
    internal class ShapeMenu
    {
        public void Execute()
        {
            ShowMenu();
        }

        private void ShowMenu()
        {
            Console.WriteLine("Introduce la opción:");
            Console.WriteLine("1. Rectángulo");
            string option = Console.ReadLine(); 

            switch(option)
            {
                case "1":
                    OperateRectangle();
                    break;
            }
        }

        private void OperateRectangle()
        {
            float b;
            float h;

            Console.WriteLine("Introduce la base: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la altura: ");
            h = float.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(b, h);
            Console.WriteLine($"El área del rectángulo es: {rectangle.GetArea()}");
        }


    }
}
