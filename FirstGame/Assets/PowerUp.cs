using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]//don't forget to add this, because scriptable objects are assets not components, which means that the object uses this it cannot be an object 
public class PowerUp : ScriptableObject {// remember that ScriptableOjects are not in MonoBehavior, it is in it's own small box
    public int PowerLevel = 10;
    public Player CurrentPlayer;
    public void Runpowerup (){
       CurrentPlayer.Score += PowerLevel;//this is when one object references another object
    }
    //never name your funtion the same as your class, 
    //now that we are not in mono behavior there is no print function is is now Debug.Log()n which debug means find, and log means report. 
}
//once you are done making your scriptable object, you can now *right click* and create a powerup asset menu
//You can 