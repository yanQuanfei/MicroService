using System;

namespace FindBall
{
    class Program
    {
        static int A1 = 1;
        static int B1 = 1;
        static int C1 = 1;

        static  int A2 = 1;
        static  int B2 = 1;
        static int C2 = 1;

        static int A3 = 1;
        static int B3 = 1;
        static int C3 = 1;

        static int A4 = 1;
        static int B4 = 2;
        static int C4 = 1;
        static void Main(string[] args)
        {

            if (A1 + A2 + A3 + A4 == B1 + B2 + B3 + B4)//第一次称
            {
                if (A1 + A2 + A3 == C1 + C2 + C3)//第二次称
                {
                    if (A1 > C4)//第三次称
                    {
                        Console.WriteLine("C4轻:" + C4);
                    }
                    else
                    {
                        Console.WriteLine("C4重:" + C4);
                    }

                }
                else if (A1 + A2 + A3 > C1 + C2 + C3)//第二次称   轻
                {
                    if (C1 == C2)//第三次称
                    {
                        Console.WriteLine("C3轻:" + C3);
                    }
                    else if (C1 > C2)//第三次称
                    {
                        Console.WriteLine("C2轻:" + C2);
                    }
                   else if (C1 < C2)//第三次称
                    {
                        Console.WriteLine("C1轻:" + C1);
                    }

                }
              else  if (A1 + A2 + A3 < C1 + C2 + C3)//第二次称   重
                {
                    if (C1 == C2)//第三次称 平
                    {
                        Console.WriteLine("C3重:" + C3);
                    }
                    else if (C1 > C2)//第三次称
                    {
                        Console.WriteLine("C1重:" + C1);
                    }
                    else if (C1 < C2)//第三次称
                    {
                        Console.WriteLine("C2重:" + C2);
                    }

                }
            }
            else
            {
                if (B1 + B2 + B3 + A4 == C1 + C2 + C3 + B4)
                {

                }
            }

           
        }
    }
}
