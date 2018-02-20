using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ArraysAndLoops : MonoBehaviour {
	
	
	public int[] HighScores;
	public Player[] Players;
	

	// Use this for initialization
	void Start () {
		foreach (var player in Players)
		{
			print(player.PlayerName);
			print(player.Score);
			print(player.MP);
		}

		foreach (var score in HighScores)
	{
		if (score >= 1000)
		{
			print(score);
		}
	}
	}
	
	
}
