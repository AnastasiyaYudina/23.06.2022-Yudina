// Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого

Console.Write("Insert a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert b: ");
int b = Convert.ToInt32(Console.ReadLine());

string a = b*b ? $"Число {a} квадрат числа {b}" : $"Число {a}  не квадрат числа {b}";
Console.WriteLine(a);