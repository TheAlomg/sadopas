using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    internal class MenuPregrado
    {
        public void menuPregrado()
        {
            int num = 0;
            Console.SetCursorPosition(30, 6); Console.WriteLine("Menu Estudiante Pregrado");
            Console.SetCursorPosition(30, 8); Console.WriteLine("1.Estudiante de Pregrado");
            Console.SetCursorPosition(30, 10); Console.WriteLine("2. Promedio Estudiante pregrado");
            Console.SetCursorPosition(30, 12); Console.WriteLine("3 Estudiantes Destacados de Pregrado");
            Console.SetCursorPosition(30, 14); Console.WriteLine("Seleccion: ");
            Console.SetCursorPosition(40, 14); num = int.Parse(Console.ReadLine());
            do
                switch (num)
                {
                    case 1:

                        break;
                    case 2:
                        Console.SetCursorPosition(30, 15); Console.WriteLine("Programas de Pregrado");
                        Console.SetCursorPosition(30, 16); Console.WriteLine("1. sistema");
                        Console.SetCursorPosition(30, 17); Console.WriteLine("2. Derecho");
                        Console.SetCursorPosition(30, 18); Console.WriteLine("3. Enfermeria");
                        Console.SetCursorPosition(30, 19); Console.WriteLine("4. Licenciatura");
                        Console.SetCursorPosition(30, 20); Console.WriteLine("5. musica");
                        Console.SetCursorPosition(30, 22); Console.WriteLine("Seleccion: ");
                        Console.SetCursorPosition(40, 22); num = int.Parse(Console.ReadLine());
                        break;
                } while (num > 0 || num < 3);
        }
    }
}
