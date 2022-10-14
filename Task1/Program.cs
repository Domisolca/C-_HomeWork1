Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA > numberB)
{
    Console.Write("max = " + numberA + "; min = " + numberB);
}
else
{
    Console.Write("max = " + numberB + "; min = " + numberA);
}