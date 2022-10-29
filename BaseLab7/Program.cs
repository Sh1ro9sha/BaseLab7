using System;

namespace BaseLab7
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите разряд");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число");
                int num19 = Convert.ToInt32(Console.ReadLine())
                int a = 0;
                int i = 0;
                string[] b = new string[10];
                while (num10 >= 1)
                {
                    a = num10 % x;
                    if (a >= 10 && a <= x)
                    {
                        char c = (char)(a + 55);
                        b[i] = c.ToString();

                    }
                    else
                    b[i] = a.ToString();
                    i++;
                    num10 = num10 / x;
                    Console.Write(a);
                }
                Console.WriteLine();
                for (i = (b.Length - 1); i >= 0; i++)
                {
                    Console.Write(b[i]);
                }
                Concole.ReadLKey()
;            }
        }
    }
}
