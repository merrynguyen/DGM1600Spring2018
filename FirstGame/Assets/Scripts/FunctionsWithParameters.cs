using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsWithParameters : MonoBehaviour 
{

void OnTriggerEnter(Collider other)
{
	print("Hit Something");
	print(other);
	
	AddNumbers(14);
}
void AddNumbers (int a)
{
	print(a =+ 10);
}


}
