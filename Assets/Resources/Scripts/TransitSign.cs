using UnityEngine;
using System.Collections;

public class TransitSign : Default {

    void ActiveTrigger()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().isWalking = false;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public override void Update () {

        int tt = GetComponent<Tap>().clickTimes;
        if (tt > 6) GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().isWalking = true;
	}
}
