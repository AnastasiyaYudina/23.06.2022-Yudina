// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее
Console.WriteLine ("Введите число 1:");
int namberA =Convert.ToInt32(Console.ReadLine ());
Console.WriteLine ("Введите число 2:");
int namberB =Convert.ToInt32(Console.ReadLine ());
int max = namberA;
int min = namberB;
if (namberA>max) max = namberA;
else min = namberA;
if (namberB>max) max = namberB;
else min = namberB;

Console.WriteLine ("Mаксимальное число: ");
Console.WriteLine (max);
Console.WriteLine ("Минимальное число: ");
Console.WriteLine (min);

