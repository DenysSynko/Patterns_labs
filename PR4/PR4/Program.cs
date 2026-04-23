using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{

    static List<int> ProcessList(List<int> list, Func<int, bool> predicate)
    {
        return list.Where(predicate).ToList();
    }

    static Func<int, int> Compose(Func<int, int> f, Func<int, int> g)
    {
        return x => f(g(x));
    }

    static List<int> OddNumbers(List<int> list)
    {
        return ProcessList(list, x => x % 2 != 0);
    }

    static double AverageValue(List<double> list)
    {
        return list.Average();
    }

    static List<string> SortAlphabet(List<string> list)
    {
        return list.OrderBy(x => x).ToList();
    }

    static int SumEven(List<int> list)
    {
        return list.Where(x => x % 2 == 0).Sum();
    }

    static int Factorial(int n)
    {
        return Enumerable.Range(1, n)
                         .Aggregate(1, (a, b) => a * b);
    }

    static (int sum, int mult) SumAndMultiply(List<int> list)
    {
        int sum = list.Aggregate(0, (a, b) => a + b);
        int mult = list.Aggregate(1, (a, b) => a * b);
        return (sum, mult);
    }

    static List<int> Squares(List<int> list)
    {
        return list.Select(x => x * x).ToList();
    }

    static List<string> SortByLength(List<string> list)
    {
        return list.OrderBy(x => x.Length).ToList();
    }

    static int WordCount(string text)
    {
        return text.Split(' ')
                   .Where(word => !string.IsNullOrWhiteSpace(word))
                   .Count();
    }

    static string FirstNonEmpty(List<string> list)
    {
        return list.FirstOrDefault(s => !string.IsNullOrWhiteSpace(s)) ?? "Немає";
    }

    static bool AllStartWithUpper(List<string> list)
    {
        return list.All(s => !string.IsNullOrEmpty(s) && char.IsUpper(s[0]));
    }

    static int? SecondMax(List<int> list)
    {
        return list.Distinct()
                   .OrderByDescending(x => x)
                   .Skip(1)
                   .FirstOrDefault();
    }

    static int? MaxEven(List<int> list)
    {
        return list.Where(x => x % 2 == 0)
                   .DefaultIfEmpty()
                   .Max();
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 8 };
        List<double> doubles = new List<double> { 1.5, 2.5, 3.5 };
        List<string> words = new List<string> { "", "Колесо", "людяність", "", "Колір", "Чоловік" };

        Console.WriteLine("1) Непарні: " + string.Join(", ", OddNumbers(numbers)));
        Console.WriteLine("2) Середнє: " + AverageValue(doubles));
        Console.WriteLine("3) Сортування: " + string.Join(", ", SortAlphabet(words)));
        Console.WriteLine("4) Сума парних: " + SumEven(numbers));
        Console.WriteLine("5) Факторіал 6: " + Factorial(6));

        var result = SumAndMultiply(numbers);
        Console.WriteLine("6) Сума: " + result.sum + ", Добуток: " + result.mult);

        Console.WriteLine("7) Квадрати: " + string.Join(", ", Squares(numbers)));
        Console.WriteLine("8) За довжиною: " + string.Join(", ", SortByLength(words)));
        Console.WriteLine("9) Кількість слів: " + WordCount("Hello world from CSharp"));
        Console.WriteLine("10) Перший непорожній: " + FirstNonEmpty(words));
        Console.WriteLine("11) Всі з великої: " + AllStartWithUpper(words));
        Console.WriteLine("12) Друге максимум: " + SecondMax(numbers));
        Console.WriteLine("13) Найбільше парне: " + MaxEven(numbers));

        Func<int, int> add2 = x => x + 2;
        Func<int, int> square = x => (int)Math.Pow(x,3);

        var composed = Compose(square, add2);
        Console.WriteLine("14) Композиція (x+2)^3 для 3: " + composed(3));
    }
}
