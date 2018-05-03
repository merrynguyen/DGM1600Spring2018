﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	public float speed;
	public float jumpSpeed = 8.0f;
	public Text countText;
	public Text winText;


	private Rigidbody rb;
	private int count;
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText ();
		winText.text = "";
		
	}
	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);

	

	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Coins"))
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
		}
	}
	void SetCountText()
	{
		countText.text = "Coins: " + count.ToString();
		if (count >= 12)
		{
			winText.text = "You Win!";
		}
	}
	


}