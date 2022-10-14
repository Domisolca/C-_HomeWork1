Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число C: ");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if(numberB > max)
{
    max = numberB;
}

if(numberC > max)
{
    max = numberC;
}

Console.Write("max = " + max);