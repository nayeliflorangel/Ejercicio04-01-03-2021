using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[10];
            double major = -9999999;
            Console.WriteLine("Escriba diez números: ");
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
                if (numbers[i] > major)
                {
                    major = numbers[i];
                }
            }
            Console.WriteLine($"El número mayor es: {major}");
        }
    }
}
