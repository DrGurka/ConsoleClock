using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalogClock
{
    class Draw
    {
        public void Circle(int radius, int x, int y)
        {

            for(int i = 1; i <= radius; i++)
            {

                for(int j = 0; j < 360; j += 2)
                {

                    double angle = j * Math.PI / 180;
                    int x0 = (int)(radius * Math.Cos(angle));
                    int y0 = (int)(radius * Math.Sin(angle));

                    switch (j)
                    {
                        case 0:
                            Console.SetCursorPosition(x0 + x - 3, y0 + y);
                            Console.Write("3");
                            break;
                        case 30:
                            Console.SetCursorPosition(x0 + x - 2, y0 + y - 1);
                            Console.Write("4");
                            break;
                        case 60:
                            Console.SetCursorPosition(x0 + x - 1, y0 + y - 2);
                            Console.Write("5");
                            break;
                        case 90:
                            Console.SetCursorPosition(x0 + x, y0 + y - 3);
                            Console.Write("6");
                            break;
                        case 120:
                            Console.SetCursorPosition(x0 + x + 1, y0 + y - 2);
                            Console.Write("7");
                            break;
                        case 150:
                            Console.SetCursorPosition(x0 + x + 2, y0 + y - 1);
                            Console.Write("8");
                            break;
                        case 180:
                            Console.SetCursorPosition(x0 + x + 3, y0 + y);
                            Console.Write("9");
                            break;
                        case 210:
                            Console.SetCursorPosition(x0 + x + 2, y0 + y + 1);
                            Console.Write("10");
                            break;
                        case 240:
                            Console.SetCursorPosition(x0 + x + 1, y0 + y + 2);
                            Console.Write("11");
                            break;
                        case 270:
                            Console.SetCursorPosition(x0 + x, y0 + y + 3);
                            Console.Write("12");
                            break;
                        case 300:
                            Console.SetCursorPosition(x0 + x - 1, y0 + y + 2);
                            Console.Write("1");
                            break;
                        case 330:
                            Console.SetCursorPosition(x0 + x - 2, y0 + y + 1);
                            Console.Write("2");
                            break;
                    }
                    if (x0 != -radius && x0 != radius && y0 != -radius && y0 != radius)
                    {

                        Console.SetCursorPosition(x0 + x, y0 + y);
                        Console.Write("█");
                    }
                }
            }
        }

        public void Line(double angleRadian, int length, int x0, int y0, ConsoleColor color)
        {

            int x1 = Convert.ToInt32(x0 + length * Math.Cos(angleRadian));
            int y1 = Convert.ToInt32(y0 + length * Math.Sin(angleRadian));

            int deltaX = Math.Abs(x1 - x0);
            int deltaY = Math.Abs(y1 - y0);

            int sx = (x0 < x1) ? 1 : -1;
            int sy = (y0 < y1) ? 1 : -1;

            int err = deltaX - deltaY;

            while(true)
            {

                Console.ForegroundColor = color;
                Console.SetCursorPosition(x0, y0);
                Console.Write("█");

                if(x0 == x1 && y0 == y1)
                {

                    break;
                }

                int e2 = 2 * err;

                if(e2 > -deltaY)
                {
                    err -= deltaY;
                    x0 += sx;
                }

                if(e2 < deltaX)
                {

                    err += deltaX;
                    y0 += sy;
                }
            }
        }
    }
}
