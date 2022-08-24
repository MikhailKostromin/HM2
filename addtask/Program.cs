int x = new Random().Next(0,1000);
Console.WriteLine($"сгенерировалось случайное количество программистов {x}");

if (x % 10== 1)
{
     Console.WriteLine($"{x} программист");
}

if (x % 10 > 1)
{
    if (x % 10 < 5)
    {
         Console.WriteLine($"{x} программиста");
    }
}

if (x % 10 >= 5)
{
    Console.WriteLine($"{x} программистов"); 
}
if (x % 10 == 0)
{
    Console.WriteLine($"{x} программистов");
}
