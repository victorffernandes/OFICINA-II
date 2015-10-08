using UnityEngine;
using System.Collections;

public class SplahScreenAnimController : MonoBehaviour {
	static bool isStart = true;
	// Use this for initialization
	void Start () {
		if (isStart) {
			GetComponent<Animator> ().Play ("splashScreenEntry");
		} 
		else {
			gameObject.SetActive(false);
		}
		isStart = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
