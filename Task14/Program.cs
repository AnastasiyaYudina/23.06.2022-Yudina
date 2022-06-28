// Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23

Console.Write("Insert number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 ==0)
    Console.WriteLine("кратно");
else
  Console.WriteLine($"не кратно");
  if (number % 23 ==0)
    Console.WriteLine("кратно");
else
  Console.WriteLine($"не кратно");
  
  
// string result = a % b == 0 ? $"Число {a} кратно числу {b}" : $"Число {a}  не кратно числу {b}, остаток {a % b}";
// Console.WriteLine(result);

