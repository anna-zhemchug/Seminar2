// Задача 13
Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine());
if (A < 99)
{
    Console.WriteLine("Третьей цифры нет");
}
if (A >= 100)
{
    //string array = A.ToString();
    //Console.WriteLine(array[2]);
    // Нахождение третьей цифры в числе С КОНЦА:
    int B = A % 1000;
    int C = B / 100;
    Console.WriteLine(C);
}