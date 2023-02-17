
// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// * Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным цветом.

// собираем данные от пользователя.
int m = TakeIntData("Введите количество строк матрицы: ");
int n = TakeIntData("Введите количество солбцов матрицы: ");
int leftBorder = TakeIntData("Введите минимум для заполнения матрицы: ");
int rightBorder = TakeIntData("Введите максимум для заполнения матрицы: ");
int rounder = TakeIntData("Введите количество знаков после запятой: ");
int numInMax = (int)Math.Log10(rightBorder) + 2 + rounder; // подсчитываем количество символов в длинном элементе матрицы.

double[,] matrix = GenDoubleMatrix(m, n, leftBorder, rightBorder, rounder); // создаем матрицу по параметрам.

DrawMatrix(matrix, numInMax); // рисуем матрицу.

void DrawMatrix(double[,] matrix, int numInMax)
{
    throw new NotImplementedException();
}

Console.WriteLine("\n\rСреднее арифметическое по столбцам:"); // выводим результат подсчета средних арифметических.
PrintArray(CountColumnsAverage(matrix));

double[] averageDiagonal = CountDiagonalAverage(matrix);
Console.WriteLine("Среднее арифметическое на главной диагонали:" + averageDiagonal[0]);
Console.WriteLine("Среднее арифметическое на побочной диагонали:" + averageDiagonal[1]);



int TakeIntData(string msg) // метод считывающий целое, выводя сообщение.
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

double[,] GenDoubleMatrix(int m, int n, double leftBorder, double rightBorder, int rounder) // генерируем матрицу дробными случайными числами в заданном диапазоне с заданной точностью
{
    double[,] matrix = new double[m, n]; // создаем двумерный массив.
    Random rnd = new Random(); // генератор случайных чисел.
    int i = 0; // счетчики.
    int j = 0;

    while (i < m)
    {
        while (j < n)
        {
            matrix[i, j] = Math.Round((rnd.NextDouble() * (rightBorder - leftBorder) + leftBorder), rounder); // записываем в массив случайное число, округлив до нужного кол-ва знаков.
            j++;
        }
        j = 0;
        i++;
    }
    return matrix; // возвращаем результат.
}

double[] CountColumnsAverage(double[,] matrix) // расчет среднего арифметического по столбцам.
{
    // расчитываем размер матрицы, создаем массив для записи ответа.
    int m = matrix.GetLength(0);
    int n = matrix.GetLength(1);
    double[] average = new double[n];
    int i = 0;
    int j = 0;

    while (j < n) // цикл по массиву, внешний по столбцам, внутренний по строкам.
    {
        while (i < m)
        {
            average[j] = average[j] + matrix[i, j]; // накапливаем сумму.
            i++;
        }
        average[j] = Math.Round((average[j] / m), 4); // делим накопленную сумму на кол-во элементов.
        i = 0;
        j++;
    }
    return average;
}

double[] CountDiagonalAverage(double[,] matrix)
{
    // расчитываем размер матрицы, создаем массив для записи ответа.
    int m = matrix.GetLength(0);
    int n = matrix.GetLength(1);
    double[] average = new double[2];
    int i = 0;
    int j = 0;

    while (i < m) // цикл.
    {
        while (j < n)
        {
            if (i == j) average[0] = average[0] + matrix[i, j]; // если элемент на основной диагонали.
            if (j == (n - 1 - i)) average[1] = average[1] + matrix[i, j]; // если элемент на диагонали.
            j++;
        }
        j = 0;
        i++;
    }
    // делим накопленные суммы на кол-во элементов.
    average[0] = Math.Round(average[0] / Math.Min(m, n), 4);
    average[1] = Math.Round(average[1] / Math.Min(m, n), 4);
    return average;

}

void PrintArray(double[] inArray)// метод - одномерный массив на экран.
{
    int i = 1; // счетчик.
    int arrayLength = inArray.Length; // переменная содержащая длину массива.

    if (arrayLength != 0) Console.Write("[\"" + inArray[0]); // если массив не пустой, то выводим 0-й элемент.
    else Console.Write("["); // выводим только открывющуюся скобку.

    while (i < arrayLength)
    {
        Console.Write("\",\"" + inArray[i]); // выводим i-й элемент массива.
        i++;
    }

    if (arrayLength != 0) Console.WriteLine("\"]"); // если массив не пустой, закрываем кавычку и скобку.
    else Console.WriteLine("]"); // закрываем скобку.
}