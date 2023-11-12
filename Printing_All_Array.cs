string[] shoppingList = { "Oranges", "Apples", "Bananas", "Watermelon", "Mango" };

int shoppingListLength = shoppingList.Length;
//Finds the length of the array

for (int j = 0; j < shoppingListLength; j++) 
//Does the array until equal to length of the array
{
    Console.WriteLine(shoppingList[j]); 
    //Prints each part of the array as j increase by 1 each time
}
