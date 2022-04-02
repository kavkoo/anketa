Console.ForegroundColor = (ConsoleColor)14;
Console.WriteLine("Кого ты любишь?");
string name = Console.ReadLine();

Console.WriteLine("Сколько ему лет?");
string ageString = Console.ReadLine();

int age = int.Parse(ageString);

if (age < 25)
{
    Console.WriteLine("Ага! По молодым прибиваешься?");
    return;
}

Console.WriteLine("Сколько раз ты его любишь?");
string numberSring = Console.ReadLine();

int times = int.Parse(numberSring);

Console.ForegroundColor = (ConsoleColor)13;

for(int i = 0; i < times; i++)
{
    Console.WriteLine($"{i+1}. Я люблю {name} =)\nЕму {ageString} года\nЯ люблю {numberSring} раз");
    Console.WriteLine();
}