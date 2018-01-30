using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

public bool Key = false;
void OnMouseDown()
{
	if(Key == true)
	print("Open Seseme");
}
}
//If statements are segments to make a game object be true to the statement or false in the statement and that leads to whatever outcome you choose it to
//an if statement can be based by a number component or just a true or false, or many other factors once we get into that more
//if statements are done in clauses as well for example
//if (3 + 3 == 6), if (3 + 4 == 7), of (5 > 2 * 3)
//for public bool statements if (true) if (false)
//we can do so many variables, for instance if we have a setting for food count we can do
//if(FoodCount < 5) then we can add a print line of "Food amount is low or if we do 
//if(FoodCount < 5) then we can add a line that says "Food amount is high"
//these are all based on conditions, that is really what an if statement is for, 
//here are soem more examples 
//if(key) if(tempurature > 98) if(dog !=dog) if(Dog == Dog)