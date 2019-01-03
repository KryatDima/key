using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            string[,] res = new string[3, 3];
            bool IsX = true;

            ConsoleKeyInfo info;


            do
            {
                info = Console.ReadKey(true);

                Player1(res, x, y);

                probel(res);
                Console.Clear();
                switch (info.Key)
                {

                    case ConsoleKey.Enter:
                        {
                            if (IsX)
                            {
                                res[x, y] = "X";
                                IsX = false;
                            }
                            else
                            {
                                res[x, y] = "O";
                                IsX = true;
                            }
                            res[x, y] = "X";
                            Player1(res, x, y);
                            Console.SetCursorPosition(y, x);
                            Console.WriteLine(res[x, y]);
                            break;
                        }

                    case ConsoleKey.UpArrow:
                        {

                            if ((x < 3) & (x > 0))
                            {
                                x--;
                                Player1(res,
                                    x, y);

                            }

                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            if (x < 2)
                            {
                                x++;

                            }

                            Player1(res, x, y);



                            break;
                        }
                    case ConsoleKey.LeftArrow:
                        {
                            if (y > 0)
                            {
                                y--;
                            }

                            Player1(res, x, y);



                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            if (y < 2)
                            {
                                y++;


                            }
                            Player1(res, x, y);

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("nichego");
                            break;
                        }
                }
            }
            while (info.Key != ConsoleKey.Escape);



        }

        static void Player1(string[,] res, int x, int y)
        {

            string[,] massiv = new string[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    if (i == x && k == y)
                    {
                        Console.Write("*");

                    }
                    else
                    {
                        Console.Write(res[i, k]);
                        //probel(res);
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }
        static void probel(string[,] res)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    res[i, j] = " ";
                }
                //Console.WriteLine();
            }
        }
    }
}


