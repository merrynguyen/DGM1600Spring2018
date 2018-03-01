using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicOperators : MonoBehaviour {
	public int Heart;
	public int Health;
	public string Password = "Love";



	// Use this for initialization
	void Start () {
		if (Password == "Love" || Password == "LOVE" || Password =="luv")
		{
			Heart = 100;
			Health += 10;
		}	
	
	}
}
