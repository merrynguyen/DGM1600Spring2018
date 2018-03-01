using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsWithParameters : MonoBehaviour 
{

	public int Health = 20;

void OnTriggerEnter(Collider other)
{
	AddHealth(25);

	print("Hit Something");
	print(other);
	
	AddNumbers(14, 2);
	PlayerData("Bob Belcher");
}
void AddHealth (int newHealth)
{
	Health += newHealth;
}
void AddNumbers (int a, int b)
{
	print(a += b);
}
void PlayerData(string name)
{
	print("This player is " + name);
}

}
