using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public enum state{
		normal, speed, dead
	}

	public GameObject Management;
	public float speed;
	public state playerstate;
	public Text countText;
	public Text winText;
	float moveHorizontal;
	float moveVertical;
	public CharacterController characterController;

	Vector3 moveDirection = new Vector3(0,0,0);

	private Rigidbody rb;
	private int count;
	public GameObject particle;
	public GameObject trail;
	void Start ()
	{
		characterController = GetComponent<CharacterController>();
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText ();
		winText.text = "";
		playerstate = state.normal;
		
	}
	void Update()
	{
		switch(playerstate){
			case state.normal:
				break;
			case state.speed:
				trail.SetActive(true);
				break;
			case state.dead:
				GameManagement.health = 0;
				break;
		}
		
		moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		moveDirection = transform.TransformDirection(moveDirection);
		moveDirection *= speed;

		characterController.Move (moveDirection * Time.deltaTime);

	

	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Coins"))
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
			particle = Instantiate(particle,transform.position,transform.rotation);
		}
		if (other.gameObject.CompareTag("Pick Up"))
		{
			other.gameObject.SetActive (false);
			playerstate = state.speed;
			speed += 5;
			
		}
		else {
			print("Not an interactable object");
		}
	}
	void SetCountText()
	{
		countText.text = "Coins: " + count.ToString();
		if (count >= 12)
		{
			winText.text = "You Win! Press Esc to Quit";
		}
	}
	

}
