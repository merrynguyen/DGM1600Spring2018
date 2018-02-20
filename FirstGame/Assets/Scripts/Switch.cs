using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {
	public string UserName;

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
	}

}
