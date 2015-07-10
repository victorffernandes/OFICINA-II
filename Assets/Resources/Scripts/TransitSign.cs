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
	void Update () {

        int tt = GetComponent<Tap>().clickTimes;
        if (tt.Equals(6)) GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().isWalking = true;
	}
}
