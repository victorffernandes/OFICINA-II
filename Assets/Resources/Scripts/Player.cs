using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : Default {
	public GameObject lastCheckPoint;
	public GameObject current ;
	public int nextChoice = 0;
    public bool isWalking = true;
    public float speed;

	public void madeChoice(GameObject g)
	{
		/*Transform[] childT;
		for(int i = 0; i < g.transform.childCount)
		{
			childT = g.GetComponentsInChildren<Transform>();
		}*/
	}


    void OnCollisionStay2D(Collision2D col)
    {
        if(col.gameObject.tag.Equals("WayPoint"))
        {
			col.gameObject.GetComponent<CircleCollider2D>().enabled = false;
			lastCheckPoint = current;
			current = col.gameObject.GetComponent<WayPoint>().options[nextChoice];
            nextChoice = 0;
        }

        if (col.gameObject.tag.Equals("Bueiro") )
        {
            Destroy(gameObject);
        }

    }

	// Use this for initialization
	void Start () {
        speed *= 1f / 100f;
	}
	
	// Update is called once per frame
	public override void Update () 
    {
        base.Update();
        if (isWalking)
        {
            LookAt2D(current.transform.position);
            transform.position = Vector3.MoveTowards(transform.position, current.transform.position, speed);
        }

	}
}
