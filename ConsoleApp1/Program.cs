using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Number:");
            int num = int.Parse(Console.ReadLine());
            Console.Clear();
            for(int i = 0; i <=12; i++)
            {
                int R = i * num;
                Console.WriteLine(num+"*"+i+"="+R);          }
        }
    }
}
