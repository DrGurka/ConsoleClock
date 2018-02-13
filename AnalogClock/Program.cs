using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalogClock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.Title = "Hej";
            Console.CursorVisible = false;

            int angle = 0;
            int lastSecond = DateTime.Now.Second;
            double angleRadian = (Math.PI / 180) * angle;

            Draw draw = new Draw();

            do
            {
                while (!Console.KeyAvailable)
                {

                    if (lastSecond != DateTime.Now.Second)
                    {
                        Console.Clear();
                        angle = DateTime.Now.Second * 6 - 90;
                        angleRadian = (Math.PI / 180) * angle;

                        draw.Circle(14, Console.WindowWidth / 2, Console.WindowHeight / 2);

                        //Sekund visare
                        draw.Line(angleRadian, 11, Console.WindowWidth / 2, Console.WindowHeight / 2, ConsoleColor.Red);

                        //Minut visare
                        angle = DateTime.Now.Minute * 6 - 90;
                        angleRadian = (Math.PI / 180) * angle;

                        draw.Line(angleRadian, 9, Console.WindowWidth / 2, Console.WindowHeight / 2, ConsoleColor.Green);

                        //Tim visare
                        angle = DateTime.Now.Hour * 30 - 90;
                        angleRadian = (Math.PI / 180) * angle;

                        draw.Line(angleRadian, 5, Console.WindowWidth / 2, Console.WindowHeight / 2, ConsoleColor.Blue);
                        Console.ResetColor();

                        lastSecond = DateTime.Now.Second;
                    }
                }
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
