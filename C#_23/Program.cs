// Задача 23
// Напишите программу, которая принимает на вход число 
// (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number>0)
{
    Console.WriteLine("Число \t Куб");
for (int i = 1; i < number + 1; i++)
{
    Console.WriteLine("{0} \t {1}", i, i * i * i);
}
}
else Console.WriteLine("Введите положительное число");

