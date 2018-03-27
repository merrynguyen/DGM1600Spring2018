using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour {
 public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
	private CharacterController controller;

    private Vector3 moveDirection = Vector3.zero;


	private void Start()
	{
		controller = GetComponent<CharacterController>();
	}
    void Update() {
       
        if (controller.isGrounded) {
			moveDirection.x = Input.GetAxis("Horizontal");
			moveDirection.y = 0;
			moveDirection.z = Input.GetAxis("Vertical");
			


            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;
            
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
