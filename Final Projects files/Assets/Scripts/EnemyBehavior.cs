using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehavior : MonoBehaviour {

	NavMeshAgent nav;
	Transform player;
	public float speed;


	// Use this for initialization
	void Awake () {
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		nav = GetComponent<NavMeshAgent>();	
	}
	
	// Update is called once per frame
	void Update () {
		nav.speed = speed;
		nav.SetDestination(player.position);
	}

	void OnCollisionEnter(Collision other){
		if(other.gameObject.tag == "Player"){
			GameManagement.health -= 10;
		}
	}
}
