
// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

int n = TakeIntData("Введите целое число:"); // запрашиваем число.
string str = GenNumbersString(n); // формируем ответ.
Console.WriteLine(str.Remove(str.Length - 2)); // выводим строку, отрезав два символа (запятую и пробел).



int TakeIntData(string msg) //метод считывающий целое из консоли, выводит сообщение.
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}


string GenNumbersString(int n) // метод формирующий строку с числами от n до 1.
{

    if (n > 0) return ($"{n}, {GenNumbersString(n - 1)}"); // если n больше 0, то маркируем n запускаем рекурсию.
    else return (""); // возвращаем пустую строку.

}