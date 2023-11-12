string[,] shoppingList = { { "Oranges", "2" }, { "Bananas", "3" }, { "Apples", "4" }, { "Watermelon", "1" } };

int shoppingListLength = shoppingList.Length / 2;
//Gets the length
//We have two divide by two as it counts every part of the array
//We only want the amount of curly brackets


for (int i = 0; i < shoppingListLength; i++) 
//Repeats it for the length of the array
{
    Console.Write("\n" + shoppingList[i,0] + ", ");//Prints the item
    Console.Write(shoppingList[i, 1]);//Prints the amount needed
}