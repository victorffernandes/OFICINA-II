using UnityEngine;
using System.Collections;

public class Tap : Default {
	public string action;
	public override void OnTouch(Touch t, Vector3 p)
	{
        if (Input.GetMouseButtonDown(0))
        GameObject.FindGameObjectWithTag("Gerenc").SendMessage(action);

		/*if (t.phase == TouchPhase.Began) 
		{
			GameObject.FindGameObjectWithTag("Gerenc").SendMessage(action);
		}*/
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		base.Update ();
	}
}
