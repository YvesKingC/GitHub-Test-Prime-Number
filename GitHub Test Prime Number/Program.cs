using System;

namespace GitHub_Test_Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int input, a = 0;
            Console.Write("Masukkan Input: ");
            input = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine("{0} adalah bilangan prima", input);
            }
            else
            {
                Console.WriteLine("{0} bukan bilangan prima", input);
            }
        }
    }
}
