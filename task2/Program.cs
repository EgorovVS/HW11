/* Задача 2: Проверка на простое число:
N = 13 -> "Это простое число"
N = 12 -> “Это не простое число” */

int N = Prompt("Введите число ");
PrimeNumber(N);

void PrimeNumber(int number, int num = 2)
{
    if(number/2<num)
    {
        Console.WriteLine($"{N} является простым числом");
        return;
    }
    if(number%num == 0)
    {
        Console.WriteLine($"{N} не является простым числом");
        return;
    }
    else
    {
        PrimeNumber(number, num + 1);
    }
}

int Prompt(string text)
{
    Console.WriteLine(text);
    int value = int.Parse(Console.ReadLine());
    return value;

}