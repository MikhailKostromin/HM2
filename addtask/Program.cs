Console.WriteLine("Какое число программистов увидел робот");
int x = Convert.ToInt32(Console.ReadLine());


if (x % 10== 1 & x !=11 & x <100)
{
     Console.WriteLine($"{x} программист");
}

else if (x % 10 == 2 & x !=12 & x % 10 == 3 & x !=13 & x % 10 == 4 & x !=14 & x <100)
{
     Console.WriteLine($"{x} программиста");
}

else
{
    Console.WriteLine($"{x} программистов"); 
}

