using UnityEngine;
using System.Collections;

public class Dogs : MonoBehaviour {
    public bool canMove = false;
    public float speed;

    void ActiveTrigger()
    {
        if (!Gerenc.goodAction)
        {
            canMove = true;
            //GetComponentInChildren<BoxCollider2D>().gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("Cutscene!!");
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (canMove) transform.Translate(0, -speed * Time.deltaTime, 0);
	}
}
