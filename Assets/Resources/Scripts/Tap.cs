using UnityEngine;
using System.Collections;

public class Tap : Default {
	public string action;
    public int clickTimes = 0;

	public override void OnTouch(Touch t, Vector3 p)
	{
        if (Input.GetMouseButtonDown(0))
        {
            if(!string.IsNullOrEmpty(action))GameObject.FindGameObjectWithTag("Gerenc").SendMessage(action);
            clickTimes++;
        }

		/*if (t.phase == TouchPhase.Began) 
		{
			GameObject.FindGameObjectWithTag("Gerenc").SendMessage(action);
		}*/
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    public override void Update()
    {
		base.Update ();
	}
}