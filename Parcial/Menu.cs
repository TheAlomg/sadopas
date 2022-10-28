using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    internal class Menu
    {
        public void menu()
        {
            int num = 0;
            Console.SetCursorPosition(30, 6); Console.WriteLine("Menu Estudiante");
            Console.SetCursorPosition(30, 8); Console.WriteLine("1. Estudiante Pregrado");
            Console.SetCursorPosition(30, 10); Console.WriteLine("2. Estudiante postgrado");
            Console.SetCursorPosition(30, 12); Console.WriteLine("Seleccion: ");
            Console.SetCursorPosition(40, 12); num = int.Parse(Console.ReadLine());
            do
            {
                switch (num)
                {
                    case 1:
                        MenuPregrado menuPregrado = new MenuPregrado();
                        menuPregrado.menuPregrado();

                        break;
                    case 2:
                        MenuPostgrado menuPostgrado = new MenuPostgrado();
                        menuPostgrado.menuPostgrado();

                        break;
                }
            } while (num > 0 || num < 3);
            Console.ReadKey();
        }
    }
}
