using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int A = 10;
    public int B = 10;
    public int C = 10;
	public int Score = 0;
	public int PowerUp = 10;


    // Use this for initialization
    void Start()
    {
        if (A + B == C)
        {
            print(C);
        }
        if (C - A == C)
        {
            print(B);
        }
        if (A * B == C)
        {
            print(B);
        }
        if (A / B == C)
        {
            print(C);
        }
        if (A <= 0)
        {
            A++;
        }
        if (A >= 10)
        {
            A--;
        }// REMEMBER that = is assign and replace
		C = A + B; // this would mean that C is now 20
		C += A + B; // this would mean that C is now 40
    }

}

