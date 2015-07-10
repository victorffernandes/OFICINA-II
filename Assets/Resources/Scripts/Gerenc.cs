using UnityEngine;
using System.Collections;

public class Gerenc : Default {

	// Use this for initialization
	void Start () {
	
	}

	void CorrectChoice()
	{
		GameObject.FindGameObjectWithTag ("Player").GetComponent<Player> ().nextChoice = 1;
	}

	void WrongChoice()
	{
		GameObject.FindGameObjectWithTag ("Player").GetComponent<Player> ().nextChoice = 0;
	}

	// Update is called once per frame
	void Update () {
        Screen.orientation = ScreenOrientation.LandscapeLeft;                                                                 
	}
}
