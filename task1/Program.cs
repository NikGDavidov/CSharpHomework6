// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int countPositive(int m)
{
    int count = 0;
for (int i = 1; i<=m; i++)
{
    int num = int.Parse(Console.ReadLine());
if (num>0) count++;
}
return count;
}
int m = 4;
Console.WriteLine($"Количество положительных чисел - {countPositive (m)}");