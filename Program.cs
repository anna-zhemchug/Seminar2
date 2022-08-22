// Задача 15
Console.Write("Введите цифру, обозначающую день недели: ");
int A = int.Parse(Console.ReadLine());
if (A == 6 || A == 7)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}