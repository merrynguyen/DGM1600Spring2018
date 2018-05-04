using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagement : MonoBehaviour {

	public static int health;
	public Text healthText;
	public Text victory;
	public Transform[] spawnPoints;
	public GameObject coinObject;



	// Use this for initialization
	void Awake () {
		health = 100;

		for(int i = 0; i < 12 ;i++){
			coinObject = Instantiate(coinObject,spawnPoints[i].transform);

		}
	}
	
	// Update is called once per frame
	void Update () {
		healthText.text = "Health: " + health;
		
		if(health<=0){
			health = 100;
			GameOver();
		}

		if(Input.GetKeyDown(KeyCode.Escape)){
			GameExit();
		}
	}

	void GameOver(){
		victory.text = "Game Over! Press Esc to Quit";
		Time.timeScale = 0.0f;
	}

	void GameExit(){
		Debug.Log("Game has quit.");
		Application.Quit();
	}
}
