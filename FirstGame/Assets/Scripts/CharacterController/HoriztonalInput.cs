using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName= "NewInput")]
public class HoriztonalInput : InputBase {

	public override float FloatInput()
	{
		return Input.GetAxis("Horizontal");
	}

}
