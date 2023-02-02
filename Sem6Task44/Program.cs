// Задача №44
// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Например:
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1


//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод Фибоначчи
int[] Fibonacci(int num)
{
    int[] arr = new int[num];
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i < num; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;
}

//Метод выводит на экран массив
void Print1DArray(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i<arr.Length-1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length-1] + "]");
}

int num = ReadData("Введите число: ");
Print1DArray(Fibonacci(num));


// //Метод выводит на экран массив
// void Print1DArray(int[] arr)
// {
//     Console.Write("[");
//     for(int i = 0; i<arr.Length-1; i++)
//     {
//         Console.Write(arr[i] + ",");
//     }
//     Console.WriteLine(arr[arr.Length-1] + "");
// }

// Console.WriteLine("введите целое");
// int a = int.Parse(Console.ReadLine());
// while (a < 2)
// {
//     Console.WriteLine("\n\r число должно быть больше 1");
//     int a = int.Parse(Console.ReadLine());
// }
// int[] mas = new mas[a];
// mas[0] = 0;
// mas[1] = 1;
// for (int i = 2; i <= a; i++)
// {
//     mas[i] = mas[i - 1] + mas[i - 2];
// }
// void Print1DArr(int[] mas)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write(mas[i] + ", ");
//     }
//     Console.WriteLine(mas[mas.Length - 1] + "]");
// }
// void Print1DArr(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + ", ");
//     }
//     Console.WriteLine(arr[arr.Length - 1] + "]");


// double Factorial(int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if(n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// for (int i = 1; i < 40; i++)
// {
// Console.WriteLine($"{i}! = {Factorial(i)}"); //1*2*3 = 6
// }



//f(1) = 1
//f(2) = 1
//f(n) = f(n-1) + f(n-2)

// double Fibonacci(int n)

// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }
// for (int i = 1; i < 50; i++)
// {
//     Console.WriteLine($"f({i}) = {Fibonacci(i)}");
// }

