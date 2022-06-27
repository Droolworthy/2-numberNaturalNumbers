using System;

namespace CS16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numberMultiples = 0;
            int initialRandomNumber = 1;
            int finalRandomNumber = 27;
            int numberOfThrees = 100;
            int lastCicleNumber = 1000;
            int randomNumber = random.Next(initialRandomNumber, finalRandomNumber);

            Console.WriteLine("Число меньше или равно 27 и больше или равно 1 - " + randomNumber);

            for (int i = 0; i < lastCicleNumber; i += randomNumber)
            {
                if (i > numberOfThrees)
                {
                    numberMultiples++;
                    Console.WriteLine("Кратное число - " + i);
                }
            }
            Console.WriteLine("Всего кратных чисел - " + numberMultiples);
        }
    }
}
