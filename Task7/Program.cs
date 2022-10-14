int min = 1, max = 10, number = new Random().Next(min, max);
bool flagContinue = true;
int i = 1;

while (i <= 3 && flagContinue)
{
    Console.Write("Введите число в интервале [" + min + "; " + max + "]: ");
    int userNumber = Convert.ToInt32(Console.ReadLine());

    if (userNumber == number)
    {
        Console.WriteLine("Вы угадали число!");
        flagContinue = false;
    }
    else if (userNumber < number)
    {
        Console.WriteLine("Ваше число меньше загаданного!");
    }
    else
    {
        Console.WriteLine("Ваше число больше загаданного!");
    }

    i++;
}