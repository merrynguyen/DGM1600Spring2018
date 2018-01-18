using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {
//Remember that the name of the class has to match the file 
//in a code block {} are needed, the end of the line needs ; print is a funtion that needs ()
	// Use this for initialization
	void Start () {

		print("I love my dog.");
		print("Yes, I really do.");
	}
void OnMouseDown()
{
	print("Bark.");
}
	// Update is called once per frame
	void Update () {
		
	}
}
