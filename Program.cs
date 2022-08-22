// Задача 10
Console.Write("Введите трёхзначное число: ");
int A = int.Parse(Console.ReadLine());
int B = A % 100;
int C = B / 10;
Console.WriteLine($"Вторая цифра: {C}");