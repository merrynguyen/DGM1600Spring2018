using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {
	public string UserName;
	public int Intelligence;
	//Using swtich statements are used to compare one component instead of using if statments because this is
	//more efficient. 
	// Use this for initialization
	void Start () {
		switch (UserName)
		{
			case "Password":
			print("Password is correct.");
			//do work
			break;

			case "LevelUp":
			print("You win! Next level.");
				//do Work
			break;	
		
			case "BlackPanther":
			print("Made over 2 million this week!");
			break;

			default:
			print("Why don't you just tell me which movie you want to see?");
				//do work
			break;
		}
		switch (Intelligence)
		{
			case 10:
			print("Why hello there good friend! Let me teach you about astrophysics!");
			break;

			case 9:
			print("Hello Sir, let me help you with your bags.");
			break;

			case 8:
			print("Hello Mister, will you help me with directions?");
			break;

			case 7:
			print("Hello Friend, how are you this morning?");
			break;

			case 6:
			print("Top of the mornin' to ya!");
			break;

			case 5:
			print("Hi.");
			break;

			default;
			print("Get out of my way idiot.");
			break;
		}
	

}
