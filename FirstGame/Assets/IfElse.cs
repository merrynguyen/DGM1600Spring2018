using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElse : MonoBehaviour
{

    public bool Key;
    public int Health = 100;
    public string Password = "password123";
    public bool Key2;
    public int FoodCount = 10;

	public bool Dog;
	public bool Cat;

	public int Magic = 15;

    // Use this for initialization
    void Start()
    {
        if (Key)
        {
            print("I have the key.");
        }
        else
        {
            print("You shall not pass.");
        }

        if (Health > 0)
        {
            print("Can Play.");
        }
        else
        {
            print("You are dead!");
        }

        if (Password == "password123")
        {
            print("You are in!");
        }
        else
        {
            print("You are a loser.");
        }
        if (Key2)
        {
            print("You have keys.");
        }
        else
        {
            print("You need more keys!");
        }
        if (FoodCount > 6)
        {
            print("You are full.");
        }
        else
        {
            print("You are starving");
        }
		if(Dog)
		{
			print("You have your perfect companion.");
		}
		else
		{
			print("You need a real friend.");
		}
		if(Cat)
		{
			print("Why did you choose a cat?");
		}
		else
		{
			print("Good job on picking a dog instead of a cat.");
		}
		if(Magic > 10)
		{
			print("You are a wizard!");
		}
		else
		{
			print("You need more magic in your life.");
		}

    }
}



//ELSE CLAUSE is a box, looks like "}else {" but it doesn't always look like that, 
// you don't have to have an else clause with an if clause.  
//Else clauses are the conslusions if the "if" statement is not true. 
//They are what will prompt what happens next, 
//an else statement goes hand in hand with the if statement. but they are not always needed.