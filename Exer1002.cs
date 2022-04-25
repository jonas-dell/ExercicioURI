using System;

namespace Exer1002
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const double n = 3.14159;
            double raio = double.Parse(Console.ReadLine());
            double area = n * (raio * raio);

            Console.WriteLine("A = " + area.ToString("F4"));
        }
    }
}