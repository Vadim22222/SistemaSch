using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int xi, ss1, ss2,xx;
            string x1="";

            float x7 = 0;

            Console.WriteLine("Введите число: ");

            xx = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nЕго система счисления: ");

            ss1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nСистема счисления, в которую нужно перевести: ");

            ss2 = Convert.ToInt32(Console.ReadLine());
          
            if (ss1 == ss2)
            {
                Console.WriteLine(xx);
            }
            else
            {
                if (ss1 == 10)
                {
                    while (xx>0)
                    {
                        x1 = Convert.ToString(xx % ss2) + x1;
                        xx /= ss2;
                    }

                }
                else if (ss2==10)
                {
                    for(int i=Convert.ToString(xx).Length-1; i>-1; i--)
                    {
                        x7 = MathF.Pow(ss1, i) * (Convert.ToInt32(Convert.ToString(xx)[Convert.ToString(xx).Length - i - 1])-48) + x7;
                    }
                    x1 = Convert.ToString(x7);
                }
                else
                {
                    for (int i = Convert.ToString(xx).Length - 1; i > -1; i--)
                    {
                        x7 = MathF.Pow(ss1, i) * (Convert.ToInt32(Convert.ToString(xx)[Convert.ToString(xx).Length - i - 1]) - 48) + x7;
                    }

                    xi = Convert.ToInt32(x7);
                    while (xi > 0)
                    {
                        x1 = Convert.ToString(xi % ss2) + x1;
                        xi /= ss2;
                    }

               
                }
              Console.WriteLine($"\nЧисло: {x1}");

            }


        }
    }
}
