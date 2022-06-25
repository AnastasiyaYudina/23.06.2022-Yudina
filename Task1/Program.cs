// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.

Console.WriteLine ("Введите число 1!");
 int a = Convert.ToInt32(Console.ReadLine ());
 Console.WriteLine ("Введите число 2!");
 int b = Convert.ToInt32(Console.ReadLine ());
if (a == b * b) {
    Console.WriteLine ("Верно!");
}
else Console.WriteLine ("Не верно");

