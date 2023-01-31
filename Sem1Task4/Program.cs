// // Написать программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

// string? inputNum1 = Console.ReadLine();
// string? inputNum2 = Console.ReadLine();
// string? inputNum3 = Console.ReadLine();

// if(inputNum1!=null && inputNum2!=null && inputNum3!=null)

// {
// int namber1 = int.Parse(inputNum1);
// int namber2 = int.Parse(inputNum2);
// int namber3 = int.Parse(inputNum3);

// if (namber1 > namber2)
// {

// if (namber1 > namber3)

// }
// Console.WriteLine("");
// }

int[] nums = new int[3]; // Обьявляем массив данных

for (int i=0; i<3; i++)
{
    Console.WriteLine("Введите "+(i+1)+"-е число:"); // просим пользователя ввести (i+1)-е число
    nums[i]=int.Parse(Console.ReadLine()??"0"); // считываем данные в массив
}

int max=nums[0]; // создаем переменную для макс. значения и приравниваем её к 0му элементу массива 

for (int i=1; i<3; i++) // запускаем цикл по массиву, начиная с 1-го (не 0) элемента, т.к. 0й элемент уже записан в max
{
    if (nums[i]>max) // если текущий элемент больше max, то запоминаем новый максимум
    {
        max=nums[i];
    }
}

Console.WriteLine("Максимальное значение = "+max); // выводим результат