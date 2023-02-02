// Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.
// Например:
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("введите целое");
int a = int.Parse(Console.ReadLine());
string res = "";
while (a > 0)

{
    res = Convert.ToString(a % 2) + res;
    a = a / 2;
}
Console.WriteLine(res);