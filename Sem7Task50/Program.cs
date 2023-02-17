
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру


// собираем данные :
int m = TakeIntData("Введите количество строк матрицы: ");
int n = TakeIntData("Введите количество солбцов матрицы: ");

double[,] matrix = GenFibonachiMatrix(m, n); // заполняем числами Фибоначи.

int lenMax = (int)Math.Log10(matrix[m - 1, n - 1]) + 1; // расчитываем количество символов в самом большом элементе для вывода матрицы.

Console.WriteLine("\n\rМатрица заполненная числами Фибоначи:");  // выводим результат.


double findMe = TakeDoubleData("\n\rВведите число для поиска: "); // спрашиваем число для поиска.

if (IsInMatrix(matrix, findMe)) DrawMatrixMarkElement(matrix, lenMax, findMe, 12); // отмечаем требуемые элементы, либо сообщаем, что такого числа нет.
else Console.WriteLine("Данный элемент отсутствует в матрице");

void DrawMatrixMarkElement(double[,] matrix, int lenMax, double findMe, int v)
{
    throw new NotImplementedException();
}

double TakeDoubleData(string msg) //метод считывающий вещественное число из консоли, выводя сообщение.
{
    Console.Write(msg);
    
    return Convert.ToDouble(Console.ReadLine() ?? "0");
}

int TakeIntData(string msg) //метод считывающий целое из консоли, выводя сообщение.
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

double[,] GenFibonachiMatrix(int m, int n) // создаем матрицу с целыми случайными числами.
{
    double[,] matrix = new double[m, n]; // двумерный массив. 
    int i = 0; // счетчики.
    int j = 2;
    matrix[0, 0] = 0;
    matrix[0, 1] = 1;
    double numBeforePrevious = 0;
    double numPrevious = 1;

    while (i < m)
    {
        while (j < n)
        {
            matrix[i, j] = numPrevious + numBeforePrevious; // записываем в массив случайное число округлив до нужного кол-ва знаков.
            numBeforePrevious = numPrevious;
            numPrevious = matrix[i, j];
            j++;
        }
        j = 0;
        i++;
    }
    return matrix; // возвращаем результат.
}

bool IsInMatrix(double[,] matrix, double FindMe) // метод отвечающий на вопрос есть ли заданный элемент в матрице.
{
    // счетчики:
    int i = 0;
    int j = 0;
    // получаем размерность матрицы:
    int m = matrix.GetLength(0);
    int n = matrix.GetLength(1);

    while (i < m)
    {
        while (j < n)
        {
            if (matrix[i, j] == FindMe) return true; // если элемнт найден возвращаем true
            j++;
        }
        j = 0;
        i++;
    }
    return false; // возвращаем false.
}
