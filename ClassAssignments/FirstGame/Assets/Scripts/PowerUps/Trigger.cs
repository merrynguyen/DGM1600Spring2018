using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour {



	public PowerUp PowerUpTransfer;

	private void OnTriggerEnter(Collider obj)
	{
		//if (obj.GetComponent<MoveCharacter>() != null) 
			obj.GetComponent<MoveCharacter>().Player.MovePattern = PowerUpTransfer.Transfer();

			gameObject.SetActive(false);
	}
}


