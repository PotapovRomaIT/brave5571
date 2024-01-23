// dotnet new console 
// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

// int number = 9;
// int result = number * number;
// Console.ReadLine() - получить информацию из строчки
// Console.Write("Введите число: ");
// int input = Convert.ToInt32(Console.ReadLine());
// "Привет" + " Мир" (конкатенация) = "Привет Мир"
// 123 + 123 = 246
// Console.WriteLine(input + 1000);

// Console.ReadLine() - получить информацию из строчки
Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
// f = 25; s = 5: f == s*s, 25 == 5 * 5
if (firstNumber == secondNumber * secondNumber) //  a является кв от числа be
{
    Console.WriteLine("Да, " + firstNumber + " является кв. от числа " + secondNumber);
}
else // a не является кв от числа b
{
    Console.WriteLine("НЕТ, " + firstNumber + "  НЕ является кв. от числа " + secondNumber);
}
