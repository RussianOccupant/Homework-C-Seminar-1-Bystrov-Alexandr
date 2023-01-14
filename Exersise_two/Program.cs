// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numB = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int numC = int.Parse(Console.ReadLine());
if (numA > numB & numA > numC)
{
    Console.WriteLine($"{numA} больше чем {numB} и {numC}");
}

if (numB > numC & numB > numA)
{
    Console.WriteLine($"{numB} больше чем {numA} и {numC}");
}

if (numC > numA & numC > numB)
{
    Console.WriteLine($"{numC} больше чем {numA} и {numB}"); 
}