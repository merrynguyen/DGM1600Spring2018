using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

	public PowerUp PowerUpTransfer;

	private void OnTriggerEnter(Collider obj)
	{

		obj.GetComponent<MoveCharacter>().MovePattern = PowerUpTransfer.Transfer();
	}
	
}
