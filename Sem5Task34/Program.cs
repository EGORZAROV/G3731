// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int arrayLenght = TakeIntData("Введите длинну массива:"); // спрашиваем длинну массива.

while (arrayLenght <= 0) // проверяем корректность ввода.
{
    arrayLenght = TakeIntData("Длинна массива должна быть строго больше 0. Введите длинну массива:");
}

int[] result = GenRandArray(arrayLenght, 100, 999);  // генерируем массив.
Console.WriteLine("\n\rСгенерированный массив:"); // выводим массив.
PrintArray(result);
Console.WriteLine("Количество четных чисел: " + CountEven(result)); // количество четных чисел.

Console.WriteLine("\n\rОтсортированный массив:"); // выводим.
PrintArray(result);

int TakeIntData(string msg) //метод считывающий целое из консоли, выводя в неё сообщение.
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[] GenRandArray(int arrayLenght, int leftBorder, int rightBorder) // метод генерирующий массив случайных значений заданной длинны и предела.
{
    Random rnd = new Random(); // инициализируем генератор случайных чисел.
    int i = 0; // счетчик.
    int[] result = new int[arrayLenght]; // массив для заполнения.

    while (i < arrayLenght)
    {
        result[i] = rnd.Next(leftBorder, rightBorder); // присваиваем i элементу случайное значение в заданном пределе.
        i++; // переходим к следующему элементу
    }

    return result; // возвращаем результат.
}

void PrintArray(int[] inArray)// метод выводящий одномерный массив.
{
    int i = 1; // переменная счетчик.
    int arrayLength = inArray.Length; // переменная содержащая длину массива.
    if (arrayLength != 0) Console.Write("[\"" + inArray[0]); // если массив не пустой, то выводим 0-й элемент.
    else Console.Write("["); // иначе выводим только открывющуюся скобку.

    while (i < arrayLength)
    {
        Console.Write("\",\"" + inArray[i]); // выводим i-й элемент массива.
        i++;
    }

    if (arrayLength != 0) Console.WriteLine("\"]"); // если массив не пустой, то закрываем кавычку и скобку.
    else Console.WriteLine("]"); // иначе только закрываем скобку.
}
int CountEven(int[] inArray) // метод подсчета количества четных элементов массива.
{
    int arrayLength = inArray.Length; // переменная содержащая длину массива.
    int counter = 0; // количество четных элементов.

    for (int i = 0; i < arrayLength; i++) // цикл по массиву.
    {
        if (inArray[i] % 2 == 0) counter++; // если остаток от целочисленного деления на 2=0, то плюсуем счетчик четных чисел.
    }
    return counter; // возвращаем значение счетчика.
}
