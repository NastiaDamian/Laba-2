using System;
internal class Program
{
    static void Main(string[] args)
    {
        //Завдання 1 
        Console.WriteLine("Введіть ціле число");
        int num1;
        num1 = Convert.ToInt32(Console.ReadLine());
        if (num1 < 0)
        {
            Console.WriteLine("Число від'ємне");
        }
        else if (num1 > 0)
        {
            Console.WriteLine("Число додатнє");
        }
        else
        {
            Console.WriteLine("Число дорівнює нулю");
        }

        //Завданя 2 

        Console.Write("Введіть рік: ");
        int year;
        year = Convert.ToInt32(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine($"{year} є високосним роком.");
        }
        else
        {
            Console.WriteLine($"{year} не є високосним роком.");
        }

        //Завдання 3
        Console.Write("Введіть свій річний дохід: ");
        double income = Convert.ToDouble(Console.ReadLine());

        double tax = 0;

        if (income <= 10000)
        {
            tax = income * 0.1;
        }
        else if (income <= 50000)
        {
            tax = (10000 * 0.1) + ((income - 10000) * 0.2);
        }
        else
        {
            tax = (10000 * 0.1) + (40000 * 0.2) + ((income - 50000) * 0.3);
        }

        Console.WriteLine($"Податок на дохід становить: {tax:C}");


        //Завдання 4 
        Console.Write("Введіть букву ");
        char letter = Char.ToUpper(Console.ReadKey().KeyChar);
        if (Char.IsLetter(letter))
        {
            if (letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
            {
                Console.WriteLine("\nГолосна буква");
            }
            else
            {
                Console.WriteLine("\nПриголосна буква");
            }
        }
        else
        {
            Console.WriteLine("\n не є буквою");
        }

        //Завдання 5 
        int num, num2, num3;

        Console.WriteLine("Введіть перше число: ");
        num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть друге число: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть третє число: ");
        num3 = Convert.ToInt32(Console.ReadLine());

        int max = Math.Max(num, Math.Max(num2, num3));


        Console.WriteLine($"Максимальне число: {max}");

        // Завдання 6 

        Console.WriteLine("Введіть вік ");
        int age;
        age = Convert.ToInt32(Console.ReadLine());
        if (age >= 12 & age <= 18)
        {
            Console.WriteLine("Вік є піділітковим");
        }
        else
        {
            Console.WriteLine("Вік НЕ є підлітковим");
        }

        //Завдання 7

        Console.WriteLine("Введіть ціле число");
        int number;
        number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("Число є парним ");
        }
        else
        {
            Console.WriteLine("Число не парне ");
        }
        if (number % 3 == 0)
        {
            Console.WriteLine("Число ділиться на 3");
        }
        else
        {
            Console.WriteLine("Число не ділиться на 3");
        }


        // Завдання 8

        Console.Write("Введіть довжину сторони a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть довжину сторони b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть довжину сторони c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        if (IsValidTriangle(a, b, c))
        {
            DetermineLongestSide(a, b, c);
        }
        else
        {
            Console.WriteLine("Трикутник з такими сторонами не існує.");
        }
    }

    static bool IsValidTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }

    static void DetermineLongestSide(double a, double b, double c)
    {
        if (a >= b && a >= c)
        {
            Console.WriteLine("Сторона a є найдовшою.");
        }
        else if (b >= a && b >= c)
        {
            Console.WriteLine("Сторона b є найдовшою.");
        }
        else
        {
            Console.WriteLine("Сторона c є найдовшою.");
        }










    }
}