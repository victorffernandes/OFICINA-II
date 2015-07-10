using UnityEngine;
using System.Collections;

public class Velhinhos : MonoBehaviour {
    bool justOnce = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	    if(!justOnce && GetComponent<DraggableObj>().matchFound)
        {
            justOnce = true;
            Gerenc.goodAction = true;
        }
	}
}
