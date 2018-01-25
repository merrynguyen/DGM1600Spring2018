using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Animals : MonoBehaviour {

	// Use this for initialization
public string Name;
public int FoodCount; 
public Text myUIText;
void OnMouseDown()
{
	print("Name");
	myUIText.text = "I have a " + Name + ", It has this amount of food; " + FoodCount;
}
}
//Variables are exactly what they sound, but in a game there can be multiple objects that can do multiple things
//A specific variable that we did today is the different names of the different objects we put in the game play
//other variables are things like the day of week. 
//Variables are just things that can change it can be anything!
//in code it just means that a certain code will have a different meaning once it is placed in a game. but it could be the same code.
