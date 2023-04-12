using System;
static bool CheckNameLenght(string name)
{
    if (name.Length>20 || name.Length == 0)
    {
        Console.WriteLine("The name can't hold more than 20 characters or be empty!");
        return false;
    }
    else return true;
    
}
string name = Console.ReadLine();
bool check = CheckNameLenght(name);
while (check == false)
{
    name  = Console.ReadLine();
    check =  CheckNameLenght(name);
}
if (check == true)
{
    name = name.ToLower();
    name = name.Trim();
    name = name.Replace(" ", "");
    Console.WriteLine("Email:");
    name = name + "@mail.com";
    Console.WriteLine(name);
}

