int x = new Random().Next();
Console.WriteLine($"сгенерировалось случайное число {x}");

void ThirdNumber (int x) 
 {
    int lenght = Convert.ToInt32(Math.Log10(x));
    if (lenght>2)
    {
        int pow = Convert.ToInt32(Math.Pow(10, lenght));
        int powDel = pow/100;
        int numb = x / powDel;
        int answer = numb % 10;
        Console.WriteLine($"Третья цифра вашего числа: {answer}");
    }
    else
    {
        Console.WriteLine($"Нет третьей цифры в вашем числе: {x}");
    }
}
ThirdNumber(x);

// if (x <=99)
// {
//     Console.WriteLine("Нет третьей цифры");
// }

// else if (x>=100)
// if (x<=999)
// {
// Console.WriteLine (x=x%10);
// }

// while (x>999)
// {
//     x=x/10;
// }
// Console.WriteLine (x=x%10);










