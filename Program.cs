// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

// тип_данных имя_переменной = значение;
// camelCase: firstNumber, secondNumber
// int number = 9; // number = 9
// int result = number * number; // 81

// Console.ReadLine() - получить информацию из строчки
// Console.Write("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// // f = 25; s = 5: f == s*s, 25 == 5 * 5
// if (firstNumber == secondNumber * secondNumber) //  a является кв от числа be
// {
//     Console.WriteLine("Да, " + firstNumber + " является кв. от числа " + secondNumber);
// }
// else // a не является кв от числа b 
// {
//     Console.WriteLine("НЕТ, " + firstNumber + "  НЕ является кв. от числа " + secondNumber);
// }
// // On Windows: Shift + Alt + F
// // On Mac: Shift + Option + F


// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// // N = 4, 
// if (N < 0) // -5 * (-1) = 5
// {
//     Console.WriteLine("Введено отр. число N");
//     N = N * -1;
// }
// int negativeN = N * -1; // -4

// while (negativeN <= N) // -3 -2 -1 0 1 2 3 
// {
//     Console.Write(negativeN + " ");
//     negativeN++; // negativeN++ (negativeN = negativeN + 1)
// }


// // a = a + 1 и a++(инкремент)
// // a = a - 1 и a--(декремент)


// int b = 8;
// int c = 6;
// int a = 7;
// int i = a;
// if (i < b)
// {
//   i = b;
// }
// if (i < c)
// {
//     i = c;
// }
// Console.Write(i);


// int number = 7;
// int i = 1;
// while (i <= number)
// {
//     if (i % 2 == 0)
//     {
//         Console.WriteLine(i);
//     }
//     i++;
// }










// СЕМИНАР 2

// Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого
// числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// // "&&" - "И": яблоки И апельсины (и то, и другое нужно купить)
// // "||" - "ИЛИ": яблоки ИЛИ апельсины(что-то одно, либо все вместе)
// if (number >= 100 && number <= 999) // Число - трехзначное
// {
//     int firstDigit = number / 100; // 274 / 100 = 2
//     int thirdDigit = number % 10; // 274 % 10 = 4
//     int result = firstDigit * 10 + thirdDigit;
//     // Интерполяция: $"Значение переменной {thirdDigit} = {}"
//     Console.WriteLine($"Результат от числа {number} = {result}");
// }
// else // Число НЕ трехзначное
// {
//     Console.WriteLine("Число НЕ трехзначное");
// }

// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number >= 100 && number <= 999)
// {
//     int secondDigit = number / 10 % 10; // 487 / 10 % 10 = 48 % 10 = 8
//     int thirdDigit = number % 10; // 487 % 10 = 7
//     // Math.Pow(5, 2) => 5 в 2 степени => 25
//     int result = (int)Math.Pow(secondDigit, thirdDigit);
//     Console.WriteLine($"Число {number}: {secondDigit}^{thirdDigit} = {result}");
// }
// else // Число НЕ трехзначное
// {
//     Console.WriteLine("Число НЕ трехзначное");
// }

// Получите 3 цифру введенного числа слева (с начала)
// 1234567 => 3
// 7891 => 9
// 32 => 3 цифры нет

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int copyNumber = number;
// if (number < 100) // Число не трехзначное
// {
//     Console.WriteLine("Третьей цифры нет :)");
// }
// else // Число трехзначное
// {
//     while (number > 999) // Если в числе минимум 4 цифры, я делю :)
//     {
//         number /= 10; 
//     }
//     Console.WriteLine($"Третья цифра от числа  {copyNumber} = {number % 10}");
// }

// "Привет" и "1234567"

// Введенная строчка состоит ТОЛЬКО из ЦИФР (TryParse)


// Получи третью цифру справа:
// 456 => 4
// 7812 => 8
// 91 => Третьей цифры нет

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int copyNumber = number;
// if (number < 100) // Число не трехзначное
// {
//     Console.WriteLine("Третьей цифры нет :)");
// }
// else // Число минимум трехзначное 
// {
//     int digitCount = 0; // Количество цифр, которое нужно убрать 
//     int digit = 0; // Третья цифра справа
//     while (digitCount < 2) // Отбрасываем 2 последние цифры
//     {
//         number /= 10;
//         digitCount++; // digitCount = digitCount + 1
//     }
//     Console.WriteLine($"Третья цифра справа от числа {copyNumber} = {number % 10}");
// }

// int number = 123;
// Console.WriteLine(number / 100 % 10);

// TryParse

// int a = 14;

// if (a % 7 == 0)
// {
//     Console.WriteLine($"{a} кратно 7");
// }




// Домашнее задание
// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// Console.Write("Ввидите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number % 7 == 0 && number % 23 == 0)
// {
//     Console.WriteLine("Кратно");
// }
// else
// {
//     Console.WriteLine("Не кратно");
// }


// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

// Console.Write("Ввидитt координаты точки X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ввидитt координаты точки y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0)
// {
//     Console.WriteLine("1");
// }
// if (x > 0 && y < 0)
// {
//     Console.WriteLine("2");
// }
// if (x < 0 && y < 0)
// {
//     Console.WriteLine("3");
// }
// if (x < 0 && y > 0)
// {
//     Console.WriteLine("4");
// }
// if (x == 0 && y == 0)
// {
//     Console.WriteLine("Точки на пересечении двух осей");
// }
// if (x == 0 && y != 0)
// {
//     Console.WriteLine("Точки на пересечении оси X");
// }
// if (x != 0 && y == 0)
// {
//     Console.WriteLine("Точки на пересечении оси y");
// }


// Задача 3: Напишите программу, которая принимает на вход целое 
// число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 10 || number > 99) 
// {
//     Console.WriteLine("Число не двх значное :)");
// }
// else 
// {
//     if ( number / 10 > number % 10)
//     {
//         Console.WriteLine(number / 10);
//     }
//     else
//     {
//         Console.WriteLine(number % 10);
//     }
// }


// Задача 4: Напишите программу, которая на вход принимает 
// натуральное число N, а на выходе показывает его цифры через запятую.

// Console.Write("Введите натуральное число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// if (N < 10)
// {
//     Console.WriteLine(N);
// }
// else
// {
//     while (N > 0)
//     {
//         int digit = N % 10;
//         N /= 10;
//         if (N > 0)
//         {
//             Console.Write(digit + ",");
//         }
//         else
//         {
//             Console.WriteLine(digit);
//         }
//     }

// }

