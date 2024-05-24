using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_1_lab_4
{
    class Program
    {
        static void Main()
        {
            // Lambda Expression để tính bình phương của một số
            Func<int, int> square = x => x * x;
            int result = square(5);
            Console.WriteLine("Bình phương của 5 là: " + result);

            // Lambda Expression để kiểm tra số chẵn
            Predicate<int> isEven = x => x % 2 == 0;
            Console.WriteLine("6 có phải là số chẵn không? " + isEven(6));

            // Lambda Expression để in ra các phần tử trong danh sách
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine("Các số trong danh sách: ");
            numbers.ForEach(num => Console.Write(num + " "));
            Console.WriteLine();

            // Lambda Expression để tính tổng các số chia hết cho 3 trong danh sách
            var sumDivisibleBy3 = numbers.Where(num => num % 3 == 0).Sum();
            Console.WriteLine("Tổng các số chia hết cho 3 là: " + sumDivisibleBy3);
        }
    }

}
