// Задача №39
// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на
// первом месте, а первый - на последнем и т.д.)
// Например:
// [1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6]
// Комментарий: эту задачу можно решить 2 способами: 1)
// менять числа местами в исходном массиве; 2) создать
// новый массив и в него записать перевёрнутый исходный
// массив по элементам.


string editLine(string text)
{
    string txt = text;
    if (txt[txt.Length - 1] != ' ')
    {
        txt += " ";
    }
    return txt;
}
Random rnd = new Random();
// метод генерации массива случайными числами
int[] create1DArray(int len, int num1, int num2)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        // заполним массив минимальными и максимальными значениями
        arr[i] = rnd.Next(Math.Min(num1, num2), Math.Max(num1, num2));
    }
    return arr;
}
//  метод печати массива
void show1DArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "\t");
    }
    Console.WriteLine(" ");
}
// void show1DArrayWithMessage(string msg, int[] arr)
// {
//     Console.WriteLine(editLine(msg));
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + "\t");
//     }
//     Console.WriteLine(" ");
// }
//Ввод данных
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void revers(int[] arr)
{
    // int temp = 0;
    for (int i = 0; i < arr.Length / 2; i++)
        (arr[i], arr[arr.Length - 1 - i]) = (arr[arr.Length - 1 - i], arr[i]);
        // temp=arr[i];
        // arr[i]=arr[arr.Length-1-i];
        // arr[arr.Length-1-i]=temp;
}
// Создание массива
int[] arr = create1DArray(
    InputNum("Введите длинну массива: "),
    InputNum("Введите минимум для значений в массиве: "),
    InputNum("Введите максимум для значений в массиве: ")
    );
// напечатаем
show1DArray(arr);
revers(arr);
show1DArray(arr);