// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// Найдите все пары в массиве и выведите пользователю


int arrayLength = TakeIntData("Введите длинну массива: "); // запрашиваем длинну массива.

while (arrayLength <= 0) // проверяем корректность ввода.
{
    arrayLength = TakeIntData("Длинна массива должна быть больше 0. Вводим длинну массива: ");
}

int[] result = GenRandArray(arrayLength, 0, 50);  // генерируем массив.
Console.WriteLine("Сгенерированный массив"); // выводим массив.
PrintArray(result);
Console.WriteLine("Сумма элементов, стоящих на нечетных местах" + SumOnOddPosition(result)); // выводим сумму элементов на нечетных местах.

Console.WriteLine("Парные элементы окрашены в цвет"); // раскрашиваем парные элементы в один цвет.
ColorisePairsInArray(result, FindPairPosition(result));

int TakeIntData(string msg) //Считываем целое, выводим сообщение.
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[] GenRandArray(int arrayLength, int leftBorder, int rightBorder) // метод генерирующий массив случайных значений и заданной длинны в заданных пределах.
{
    Random rnd = new Random(); // запускаем генератор случайных чисел.
    int i = 0; // переменная-счетчик.
    int[] result = new int[arrayLength]; // массив для заполнения.

    while (i < arrayLength)
    {
        result[i] = rnd.Next(leftBorder, rightBorder); // присваиваем i.
        i++; // переходим к следующему элементу.
    }

    return result; // возвращаем результат.
}

void PrintArray(int[] inArray)// метод выводящий одномерный массив.
{
    int i = 1; // переменная счетчик.
    int arrayLength = inArray.Length; // переменная содержащая длину массива.

    if (arrayLength != 0) Console.Write("[\"" + inArray[0]); // если массив не пустой, то выводим 0-й элемент с элементами оформления вывода.
    else Console.Write("["); // выводим открывющуюся скобку.

    while (i < arrayLength)
    {
        Console.Write("\",\"" + inArray[i]); // выводим i элемент массива.
        i++;
    }

    if (arrayLength != 0) Console.WriteLine("\"]"); // если массив не пустой, закрываем кавычку и скобку.
    else Console.WriteLine("]"); // закрываем скобку.
}

int SumOnOddPosition(int[] inArray) // метод подсчитывающий сумму элементов на нечетных местах.
{
    int arrayLength = inArray.Length; // переменная содержащая длину массива.
    int summ = 0; // сумма элементов.

    for (int i = 0; i < arrayLength; i = i + 2) // цикл в массиве начинаем с 0 элемента - это 1-й нечетный элемент.
    {
        summ = summ + inArray[i]; // добавляем к сумме значение i элемента.
    }
    return summ; // возвращаем значение счетчика.
}

int[,] FindPairPosition(int[] inArray) // метод возвращающий массив с номерами парных элементов.
{
    int[,] pairArray = new int[(inArray.GetLength(0) / 2), 2]; // массив результат.
    int pairAmount = 0; // количество найденных пар.
    bool exitFlag = false; // флажок выхода из цикла.
    int arrayLength = inArray.Length - 1; // переменная содержащая номер последнего элемента.
    int i = 0;
    int j = 0;

    while (i < arrayLength - 1)
    {
        if (!IsInArray(pairArray, i, pairAmount))
        { // проверяем есть ли i элемент массива среди пар.         
            j = i + 1;
            while (j < arrayLength && !exitFlag)// цикл перебора оставшихся элементов массива, для сравнения значения с элементом заданным "внешним" циклом.
            {
                if (!IsInArray(pairArray, j, pairAmount)) // проверяем есть ли элемент j массива среди пар.
                { 
                    if (inArray[i] == inArray[j]) // если нашли пару.
                    {
                        pairArray[pairAmount, 0] = i; // записываем номер первого числа пары.
                        pairArray[pairAmount, 1] = j; // записываем номер второго числа пары.                      
                        pairAmount++; // увеличиваем счетчик количества пар.
                        exitFlag = true; // ставим флажок выхода из цикла, пара найдена.
                    }
                }
                j++;
            }
            exitFlag = false; // опускаем флажок.        
        }
        i++;
    }

    return (Resize2DArray(pairArray, pairAmount, 2)); // отрезаем пустые элементы у массива и возвращаем его.
}

bool IsInArray(int[,] inArray, int num, int lim) // метод проверяет наличие числа в масиве, просматривая его до указанной строки.
{
    int i = 0;
    int arrayLength = inArray.GetLength(0); // переменная содержащая длину массива.
    while (i < arrayLength && i < lim)
    {
        if (inArray[i, 0] == num || inArray[i, 1] == num) return true;
        i++;
    }
    return false;
}

int[,] Resize2DArray(int[,] original, int rows, int cols) // метод изменяющий длинну двумерного массива.
{
    int[,] newArray = new int[rows, cols]; // создаем новый массив нужного размера.
    int minRows = Math.Min(rows, original.GetLength(0)); // выясняем, что меньше, количество строк новом или исходном массиве.
    int minCols = Math.Min(cols, original.GetLength(1)); // выясняем, что меньше, количество столбцов в новом или исходном массиве.

    for (int i = 0; i < minRows; i++)
        for (int j = 0; j < minCols; j++)
            newArray[i, j] = original[i, j]; // переписываем элементы из оригинального массива в новый. 
    return newArray;
}

void ColorisePairsInArray(int[] inArray, int[,] pairs) // метод выводящий массив, расскрашивая его элементы на основе матрицы пар.
{
    int i = 0; // счетчик для цикла.
    int arrayLength = inArray.Length;  // переменная содержащая длину массива.     
    int color = 1; // переменная содержащая текущий цвет символов.
    Console.Write("["); // пишем в консоль первый сивол вывода.

    while (i < arrayLength)
    {
        color = ColorNum(i, pairs); // расчитываем номер цвета для вывода очередного элемента на базе матрицы парных элеменнтов.           
        Console.ForegroundColor = (ConsoleColor)color; //изменяем цвет вывода тескста.
        Console.Write(inArray[i] + ","); // выводим значение элемента массива.
        i++;
    }
    Console.ForegroundColor = (ConsoleColor)15; // возвращаем цвет к стандартному.
    Console.WriteLine("]"); // закрываем вывод массива.
}

int ColorNum(int num, int[,] pairs) // метод расчета цвета длдя вывода элемента.
{
    int i = 0;
    int result = 15; // результат по умолчанию 15 - белый цвет.
    bool exitFlag = false; // флажок выхода из цикла.
    int pairsLength = pairs.GetLength(0); // получаем количество строк в матрице пар.

    while (i < pairsLength && !exitFlag) // просматриваем матрицу до конца либо пока не найдем элемент.
    {
        if (num == pairs[i, 0] || num == pairs[i, 1])
        {
            result = (i + 1) - (i / 13) * 13; // номер цвета не может быть больше 15(белый), цвет 0 не применим (черное на черном).  
                                              // формула позволяет избежать генерацию "неправильных" цветов.         
            exitFlag = true; // флажок для выхода из цикла.
        }
        i++;
    }
    return result;
}