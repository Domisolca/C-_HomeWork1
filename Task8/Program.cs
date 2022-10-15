bool flagContinue = true;
bool flagName = false, flagPassword = false;

string name = "", password = "";

while(flagContinue)
{
    string message = Console.ReadLine();

    if(message == "Exit")
    {
        flagContinue = false;
    }
    else if(message == "SetName")
    {
        name = Console.ReadLine(); 
        flagName = true;
    }
    else if(message == "Help")
    {
        Console.WriteLine("SetName – установить имя");
        Console.WriteLine("Help – вывести список команд");
        Console.WriteLine("SetPassword – установить пароль");
        Console.WriteLine("Exit – выход");
        Console.WriteLine("WriteName – вывести имя после ввода пароля");
    }
    else if(message == "SetPassword")
     {
        password = Console.ReadLine(); 
        flagPassword = true;
    }
    else if(message == "WriteName")
     {
        if(flagPassword == false)
        {
             Console.WriteLine("Пароль не был задан!");   
        }
        else if(flagName == false)
        {
             Console.WriteLine("Имя не было задано!");   
        }
        else
        {
            string password1 = Console.ReadLine();
            if(password1 == password)
            {
                Console.WriteLine(name);
            }
            else
            {
               Console.WriteLine("Пароль неверный!"); 
            }
        }
        
     }
}