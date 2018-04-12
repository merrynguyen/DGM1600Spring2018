using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour {

	public float PowerLevel = 0.2;
	public Image HealthBar;
	public PowerUp PowerUpTransfer;



	private void OnTriggerEnter(Collider obj)
	{
		HealthBar.fillAmount += PowerLevel
		
		if(HealthBar.fillAmount = 0)

		
			obj.GetComponent<MoveCharacter>().MovePattern = PowerUpTransfer.MovePattern();
			
		}
}
