using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListsAndLoops : MonoBehaviour {
	
	public TheIncredibles TheIncredibles;
	public Text AddMember;

	private void OnMouseDown()
	{
		TheIncredibles.FamilyList.Add(AddMember.text);
	}
	
	//making these list is so you can create a different objects within one component.
	//

}
