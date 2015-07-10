using UnityEngine;
using System.Collections;

public class BabyCar : Default {

    public bool babySaved = false;
    public float speed;
    public bool canMove = false;

    void ActiveTrigger()
    {
        StartCoroutine(TimeToSaveBaby(5f));
        canMove = true;
    }

    IEnumerator TimeToSaveBaby(float t)
    {
        yield return new WaitForSeconds(t);
        if (babySaved) Gerenc.goodAction = true;
    }

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
    public override void Update()
    {
       if(canMove && !babySaved) transform.Translate(-1 * Time.deltaTime * speed, 0, 0);
       int tt = GetComponent<Tap>().clickTimes;
       if (tt == 3) babySaved = true;
	}
}
