// // // Решение "со звёздочкой" 
// // 2. Определение палиндрома для пятизначного числа с помощью словаря
// // // Метод, возвращающий словарь четырехзначных палиндромов
// Dictionary<int, int> FillPalindroms()
// {
//     Dictionary<int, int> palindroms = new Dictionary<int, int>();

//     // Цикл внутри цикла, заполняющих значения словаря палиндромов
//     for (int i = 1; i < 10; i++)
//     {
//         for (int j = 0; j < 10; j++)
//         {
//             int key = j * 10 + i;
//             int value = i * 1000 + j * 100 + j * 10 + i;
//             palindroms.Add(key, value);
//         }
//     }

//     return palindroms;
// }
// // Метод, проверяющий на палиндром
// bool CheckIfPalindrom(int inputNumber, Dictionary<int, int> palindroms)
// {
//     // Делаем из исходного пятизначного числа четырёхзначное, убирая третью цифру
//     int fourDigitNumber = (inputNumber / 1000) * 100 + inputNumber % 100;
//     // Проверка на вхождение в словарь палиндромов
//     return palindroms.ContainsValue(fourDigitNumber);
// }

// int inputNumber = 0;
// string inputLine = ReadData("Введите пятизначное число: ");
// if (int.TryParse(inputLine, out inputNumber))
// {
//     if (inputNumber > 9999 && inputNumber < 100000)
//     {
//         Dictionary<int, int> fourDigitPalindroms = FillPalindroms();
//         PrintResult(CheckIfPalindrom(inputNumber, fourDigitPalindroms) ? "Это палиндром" : "Это не палиндром");
//     }
//     else
//     {
//         PrintResult("Это не пятизначное число");
//     }
// }
// else
// {
//     PrintResult("Это не число");
// }