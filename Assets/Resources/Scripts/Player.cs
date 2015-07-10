using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : Default {
	public GameObject lastCheckPoint;
	public GameObject current ;
	public int nextChoice = 0;
    public bool isWalking = true;
    public float speed;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag.Equals("WayPoint"))
        {
			lastCheckPoint = current;
			current = col.gameObject.GetComponent<WayPoint>().options[nextChoice];
            nextChoice = 0;
        }

        if (col.gameObject.layer.Equals(8))
        {
            Destroy(gameObject);
        }
        if (col.gameObject.layer.Equals(9))
        {
            col.gameObject.transform.parent.gameObject.SendMessage("ActiveTrigger");
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
