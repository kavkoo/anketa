namespace HelloWorld;

public class Program
{
    public static void Main(string[] args)
    {
        Console.ForegroundColor = (ConsoleColor)14;

        string name = GetName(args);

        int age = GetAge();

        if(age < 25)
        {
            Console.WriteLine("Ага! По молодым прибиваешься?");
            return;;
        }

        Console.WriteLine("Сколько раз ты его любишь?");
        string numberSring = Console.ReadLine();

        int times = int.Parse(numberSring);

        Console.ForegroundColor = (ConsoleColor)13;

        for(int i = 0; i < times; i++)
        {
            Console.WriteLine($"{i+1}. Я люблю {name} =)\nЕму {age} года\nЯ люблю {numberSring} раз");
            Console.WriteLine();
        }
    }

    private static string GetName(string[] args)
    {
        int len = args.Length;
        Console.WriteLine("Кого ты любишь?");
        string name;
        if(len>=1)
        {
            name = args[0];
            Console.WriteLine($"{args[0]}");
        }
        else
        {
            name = Console.ReadLine();
        }

        return name;
    }

    private static int GetAge()
    {
        Console.WriteLine("Сколько ему лет?");
        string ageString = Console.ReadLine();

        int age;
        bool success = int.TryParse(ageString, out age);

        while(!success)
        {
            Console.WriteLine();
            Console.WriteLine($"Необходимо ввести целое число, попробуй ещё раз:");
            ageString = Console.ReadLine();
            success = int.TryParse(ageString, out age);
        }

        return age;
    }
}