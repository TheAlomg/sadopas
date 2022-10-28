using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    internal class MenuPostgrado
    {
        public void menuPostgrado()
        {
            int num = 0;
            Console.SetCursorPosition(30, 6); Console.WriteLine("Menu Estudiante postgrado");
            Console.SetCursorPosition(30, 8); Console.WriteLine("1. Estudiante de postgrado");
            Console.SetCursorPosition(30, 10); Console.WriteLine("2. Promedio de Estudiante postgrado");
            Console.SetCursorPosition(30, 12); Console.WriteLine("3 Estudiantes Destacados de Postgrado");
            Console.SetCursorPosition(30, 14); Console.WriteLine("Seleccion: ");
            Console.SetCursorPosition(40, 14); num = int.Parse(Console.ReadLine());
            do
                switch (num)
                {
                    case 1:

                        break;
                    case 2:
                        Console.SetCursorPosition(30, 15); Console.WriteLine("Programas de Postgrado");
                        Console.SetCursorPosition(30, 16); Console.WriteLine("1. Desarrollo de Sotware");
                        Console.SetCursorPosition(30, 17); Console.WriteLine("2. Derecho Administrativo");
                        Console.SetCursorPosition(30, 18); Console.WriteLine("3. Auditoria de Salud");
                        Console.SetCursorPosition(40, 20); num = int.Parse(Console.ReadLine());
                        break;
                    case 3:

                        break;
                } while (num >0 || num <3);
        }
    }
}
