using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {
	
	public PowerUp PowerUp;
	Private MovePattern prevMovePattern;
	private void OnTriggerEnter(Collider obj)
	{
		prevMovePattern = obj.GetComponent<MoveCharacter>().MovePattern;
		obj.GetComponent<MoveCharacter>().MovePattern= PowerUp.MovePattern;
		gameObject.SetActive(false);
		}

		void RestoreMovePattern(MovePattern oldMovePattern)
		{
			
		}
}
