// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
 Console.Write("Введите первое число: ");
 int numA = int.Parse(Console.ReadLine());
 Console.Write("Введите второе число: ");
 int numB = int.Parse(Console.ReadLine());
 if (numA > numB)
 {
    Console.WriteLine($"{numA} больше {numB}");

 }
 else 
 {
    Console.WriteLine($"{numA} меньше {numB}");
 }