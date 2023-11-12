bool loop_finished = false; //Declares the variables
int total = 0;

while(loop_finished == false) //Boolean must be false to initiate loop
{
    Console.WriteLine(total);
    total ++; //Increments the total by 1
    total = total * 3;
    if (total > 100)
    {
        loop_finished = true;//Will now no longer complete the loop as condition isn't met
    }
    else; //This can be used to show nothing else happens when there is remainder
}
