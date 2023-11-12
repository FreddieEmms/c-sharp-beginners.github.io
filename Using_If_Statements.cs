
Console.WriteLine("(1) - Pork\n(2) - Chicken\n(3) - Lamb");//The \n Seperates it on to different lines.

Console.Write("What will you order (using numbers): ");
string menuOrder = Console.ReadLine(); //We can just store as a string we don't have to convert it

if(menuOrder == "1") //We use speech marks if it is a string, we dont have to if it is an integer
                     //and we don't need a semi colon here or on the curly brackets
{
    Console.WriteLine("You have ordered the pork!"); //We need a semi colon here, this prints when we choose pork
}
else if(menuOrder == "2")
{
    Console.WriteLine("You have ordered chicken!");
}
else if  (menuOrder == "3")
{
    Console.WriteLine("You have ordered Lamb!");
}
else //We use else if none of the variables match the requirements, it is not mandatory to use
{
    Console.WriteLine("This is not on the menu!");
}