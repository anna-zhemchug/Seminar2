// Задача 13
Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine());
if (A < 99)
{
    Console.WriteLine("Третьей цифры нет");
}
if (A >= 100)
{
    string array = A.ToString();
    Console.WriteLine(array[2]);
}