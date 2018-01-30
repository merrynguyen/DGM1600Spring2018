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