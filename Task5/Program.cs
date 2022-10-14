string massage = "Секретное сообщение 1";
string password = "12345";

int i = 1;
bool Flag = true;

while(i <= 3 && Flag)
{
    Console.Write("Введите пароль: ");
    string userPassword = Console.ReadLine();

    if(userPassword == password)
    {
        Console.WriteLine(massage);
        Flag = false;
    }

    i++;
}