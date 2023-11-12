Console.WriteLine("Do you like dogs (yes or no): ");
string LikesDogs = Console.ReadLine(); //Finds out if they like dogs

Console.WriteLine("Do you like cats (yes or no): ");
string LikesCats = Console.ReadLine(); //Finds out if they like cats

Console.WriteLine("Do you like bunnies (yes or no)");
string LikesBunnies = Console.ReadLine();

if (LikesDogs == "yes" & LikesCats == "yes") //We use an AND gate to combine both requirements
{
    Console.WriteLine("You like dogs and cats!"); //Ouputs messgae
}
else if ((LikesDogs == "no" || LikesCats == "no") | (!(LikesBunnies == "no")))  // We use an OR and NOT gate to combine requirements
{
    Console.WriteLine("You don't like either dogs or cats, or you like bunnies");
}

