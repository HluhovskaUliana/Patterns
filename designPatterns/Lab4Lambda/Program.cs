using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab5Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var doubles = new List<double> { 1.5, 2.5, 3.5, 4.5 };
            var strings = new List<string> { "Banana", "Apple", "Cherry", "", "Orange" };

            Console.WriteLine("1. Odd numbers: " + string.Join(", ", FilterOdds(numbers)));
            Console.WriteLine("2. Average: " + FindAverage(doubles));
            Console.WriteLine("3. Sorted strings: " + string.Join(", ", SortStringsAlphabetically(strings)));
            Console.WriteLine("4. Sum of evens: " + SumEvenNumbers(numbers));
            Console.WriteLine("5. Factorial(5): " + Factorial(5));
            Console.WriteLine("6. Sum & Product: " + string.Join(", ", SumAndProduct(numbers)));
            Console.WriteLine("7. Squares: " + string.Join(", ", Squares(numbers)));
            Console.WriteLine("8. Sort by length: " + string.Join(", ", SortByLength(strings)));
            Console.WriteLine("9. Word count: " + WordCount("Design patterns are typical solutions to common problems in software design. "));
            Console.WriteLine("10. First non-empty: " + FirstNonEmpty(strings));
            Console.WriteLine("11. All start with capital: " + AllStartWithCapital(new List<string> { "Apple", "Banana", "Cherry" }));
            Console.WriteLine("12. Second largest: " + SecondLargest(numbers));
            Console.WriteLine("13. Largest even: " + LargestEven(numbers));
        }

        // 1. Відфільтрувати непарні числа
        static IEnumerable<int> FilterOdds(List<int> numbers) =>
            numbers.Where(n => n % 2 != 0);

        // 2. Знайти середнє
        static double FindAverage(List<double> numbers) =>
            numbers.Average();

        // 3. Сортування рядків в алфавітному порядку
        static IEnumerable<string> SortStringsAlphabetically(List<string> strings) =>
            strings.OrderBy(s => s);

        // 4. Сума парних чисел
        static int SumEvenNumbers(List<int> numbers) =>
            numbers.Where(n => n % 2 == 0).Sum();

        // 5. Факторіал
        static int Factorial(int n) =>
            Enumerable.Range(1, n).Aggregate((a, b) => a * b);

        // 6. Сума та добуток
        static IEnumerable<int> SumAndProduct(List<int> numbers) =>
            new List<int> { numbers.Sum(), numbers.Aggregate(1, (a, b) => a * b) };

        // 7. Квадрат кожного числа
        static IEnumerable<int> Squares(List<int> numbers) =>
            numbers.Select(n => n * n);

        // 8. Сортування рядків за довжиною
        static IEnumerable<string> SortByLength(List<string> strings) =>
            strings.OrderBy(s => s.Length);

        // 9. Підрахунок слів у реченні
        static int WordCount(string sentence) =>
            sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries).Count();

        // 10. Перший непорожній рядок
        static string FirstNonEmpty(List<string> strings) =>
            strings.FirstOrDefault(s => !string.IsNullOrWhiteSpace(s));

        // 11. Перевірка, чи всі рядки починаються з великої літери
        static bool AllStartWithCapital(List<string> strings) =>
            strings.All(s => !string.IsNullOrEmpty(s) && char.IsUpper(s[0]));

        // 12. Друге за величиною число
        static int SecondLargest(List<int> numbers) =>
            numbers.OrderByDescending(n => n).Skip(1).First();

        // 13. Найбільше парне число
        static int LargestEven(List<int> numbers) =>
            numbers.Where(n => n % 2 == 0).Max();
    }
}
