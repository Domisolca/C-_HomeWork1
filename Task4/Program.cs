Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 1)
{
    Console.WriteLine("Число меньше 1!");
}
else
{
    int currentNumber = 1;

    while(currentNumber <= number)
    {
        if(currentNumber % 2 == 0)
        {
            Console.Write(currentNumber + " ");
        }
        
        currentNumber++;
    }
}