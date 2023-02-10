// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3 7 22 2 78]-> 76


double[] Gen1DArray(int len, int minValue, int maxValue)
{
double[] arr = new double[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int[] ConvertArr(int[] arr)
{
    int[] resArr = new int[(arr.Length/2)+1];
    for (int i = 0; i < resArr.Length; i++)
    {
        resArr[i]=arr[i]*arr[arr.Length-1-i];
    }
    return resArr;
}

int[] testArr = Gen1DArray(123,0,1000);
Print1DArr(testArr);
int[] convArr = ConvertArr(testArr);
Print1DArr(convArr);
Print1DArr(testArr);