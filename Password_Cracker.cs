bool password_cracked = false;
string password = "iLoveCoding123";

while(password_cracked == false)
{
    Console.Write("Enter the password: ");
    string guess = Console.ReadLine();
    if (guess == password)
    {
        Console.WriteLine("Password cracked!");
        password_cracked = true;
    }
    else;
}
