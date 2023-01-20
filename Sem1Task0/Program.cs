// Задача # 0

string? inputNum =Console.ReadLine();

if(inputNum!=null)
{
// Парсим введенное число 
int number = int.Parse(inputNum);
// находим квадрат числа
// int result = number*number;
// вводим данные в консоль

int result = (int)Math.Pow(number,2);

Console.WriteLine(result);
}
