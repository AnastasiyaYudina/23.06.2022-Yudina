//  Напишите программу, которая принимает 
// на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine ("Введите числа:");
int namberA =Convert.ToInt32(Console.ReadLine ());
int namberB =Convert.ToInt32(Console.ReadLine ());
int namberC =Convert.ToInt32(Console.ReadLine ());

int max = namberA;

if (namberA>max) max = namberA;
if (namberB>max) max = namberB;
if (namberC>max) max = namberC;

Console.WriteLine ("Mаксимальное число: ");
Console.WriteLine (max);


