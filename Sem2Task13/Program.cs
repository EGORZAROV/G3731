// Задача 13

char[] digit = (Console.ReadLine()??"0").ToCharArray();

if (digit.Length >= 3)
{
    Console.WriteLine(digit[2]);
    // int num = int.Parse(Console.ReadLine()??"0");
}

else
{
    Console.WriteLine("Третьей цифры нет");
}
