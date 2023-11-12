
static int Addition(int num1, int num2)
/*Whatever the numbers are entered into the function later,
it will temporarily be changed to in this function then switched back*/
{
    int total = num1 + num2;
    //Adds them together
    return total;
    //Gives back the total but doesn't store it, it has to be printed at the moment
}

int number1 = 5;
int number2 = 5;
int number3 = 10;

Console.WriteLine(Addition(number1, number2));
//Uses the number stored which passes them through the function


Console.WriteLine(Addition(number3, number2));