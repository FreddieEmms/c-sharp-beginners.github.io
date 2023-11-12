bool input_validified = false;

while ( input_validified == false) //Will continute the loop until valid
{
    //Goes back to try again after the catch is executed in loop
    try
    {
        Console.Write("Enter a number that is an integer: ");
        int num = Convert.ToInt32(Console.ReadLine());
        //Converts to integer
        //As not gone to catch{} then it must be valid

        input_validified = true;
    }
    catch 
    {
        Console.WriteLine("This is not a valid input it must be an integer");
        //Will not stop the loop as it is still not a valid input
        //Displays a message that it is wrong
    }
}
