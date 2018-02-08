using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPowerUp : MonoBehaviour {
	public PowerUp MyPowerUp;
	void OnMouseDown()
	{
		if (MyPowerUp.PowerLevel >= 100)
	{
		print("I Have the Power!!!");
	}	
	}
}
