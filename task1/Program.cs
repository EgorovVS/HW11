/* Задача 1: Определите, является ли число степенью двойки:
N = 16 -> "Является степень двойки"
N = 12 -> “Не является степенью двойки” */

int N = Prompt(" Введите число ");
PowerTwo(N);

int Prompt(string text)
{
    Console.WriteLine(text);
    int value = int.Parse(Console.ReadLine());
    return value;
}

void PowerTwo(int num, int sqr = 2)
{
    if (num == 1)
    {
        Console.WriteLine($"{N} является степенью двойки");
        return;
    }
    if (num % sqr == 0)
    {
        PowerTwo(num / 2, sqr);
    }
    else
    {
        {
            Console.WriteLine($"{N} не является степенью двойки");
            return;
        }
    }
}
