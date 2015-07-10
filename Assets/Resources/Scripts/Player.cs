using UnityEngine;
using System.Collections;

public class Player : Default {
    public Transform[] t;
    public int current = 0;
    public bool isWalking = true;
    public override void OnTouch(Touch t)
    {
        Debug.Log("tocou");
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if(col.gameObject.tag.Equals("WayPoint") && !col.gameObject.GetComponent<WayPoint>().isPuzzle)
        {
            isWalking = true;
            Destroy(col.gameObject);
            if (t.Length - 1 != current ) current++;
        }
        if (col.gameObject.tag.Equals("WayPoint") && col.gameObject.GetComponent<WayPoint>().isPuzzle)
        {
            isWalking = false;
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public override void Update () {
        base.Update();
        if (isWalking)
        {
            transform.position = Vector3.MoveTowards(transform.position, t[current].position, 0.1f);
        }
	}
}
