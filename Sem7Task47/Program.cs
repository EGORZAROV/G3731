
// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.


// собираем данные.
int m = TakeIntData("Введите количество строк матрицы: ");
int n = TakeIntData("Введите количество солбцов матрицы: ");
int leftBorder = TakeIntData("Введите минимум для заполнения матрицы: ");
int rightBorder = TakeIntData("Введите максимум для заполнения матрицы: ");
int rounder = TakeIntData("Введите количество знаков после запятой: ");
int numInMax = (int)Math.Log10(rightBorder) + 2 + rounder; // считаем количество символов в самом длинном элементе матрицы.

double[,] matrix = GenDoubleMatrix(m, n, leftBorder, rightBorder, rounder); // создаем матрицу по параметрам.

int TakeIntData(string msg) // считываем целое из консоли.
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

double[,] GenDoubleMatrix(int m, int n, double leftBorder, double rightBorder, int rounder) // формируем матрицу дробными случайными числами в заданном диапазоне с заданной точностью.
{
    double[,] matrix = new double[m, n]; // создаем двумерный массив.
    Random rnd = new Random(); // генератор случайных чисел.
    int i = 0; // счетчики.
    int j = 0;

    while (i < m)
    {
        while (j < n)
        {
            matrix[i, j] = Math.Round((rnd.NextDouble() * (rightBorder - leftBorder) + leftBorder), rounder); // записываем в массив случайное число в заданных пределах округляя до нужного кол-ва знаков.
            j++;
        }
        j = 0;
        i++;
    }
    return matrix; // возвращаем результат.
}