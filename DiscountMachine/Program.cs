using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество баллов: ");
            if (int.TryParse(Console.ReadLine(), out int points))
            {
                try
                {
                    int discount = DiscountCalculator.CalculateDiscount(points);
                    Console.WriteLine($"Ваша скидка: {discount}%");
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine($"Ошибка: {e.Message}");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: введите корректное число.");
            }

            Console.ReadKey();
        }
    }
}
