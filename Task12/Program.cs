// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.

Console.Write("Insert number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

// int result = number1 % number2;
// string result == 0 ? $"не крантно, остаток {result}" : "кратно";

if (number1 % number2 == 0)
    Console.WriteLine("кратно");
else
  ///  Console.WriteLine($"не кратно, остаток {number1 % number2}");
  Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
// if (a % b == 0)
// {
//     Console.WriteLine($"Число {a} кратно числу {b}");
// }
// else
// {
//     int num = a % b;
//     Console.WriteLine($"Число {a}  не кратно числу {b}, остаток {num}");
// }

string result = a % b == 0 ? $"Число {a} кратно числу {b}" : $"Число {a}  не кратно числу {b}, остаток {a % b}";
Console.WriteLine(result);

