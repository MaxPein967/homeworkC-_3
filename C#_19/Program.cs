// Задача 19
// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите число: ");
string str = Console.ReadLine();
int b;
if (int.TryParse(str, out b))
{
    string rev_str = "";
    for (int i = str.Length - 1; i >= 0; i--)
    {
        rev_str = rev_str + str[i];
    }
    int a = Convert.ToInt32(str);
    b = Convert.ToInt32(rev_str);

    if (a != b)
    {
        Console.WriteLine("нет");
    }
    else
        Console.WriteLine("да");
}
else
{
    Console.WriteLine("Вы должны ввести число...");
}