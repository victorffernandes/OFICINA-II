using UnityEngine;
using System.Collections;

public class DraggableObj : Default {
    public string match;
    public bool canDrag;
	// Use this for initialization
	void Start () {
        canDrag = true;
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log("ooooooooooi");
        if (col.gameObject.tag.Equals(match) )
        {
            transform.position = col.gameObject.transform.position;
            Debug.Log("ooooooooooi");
            Destroy(col.gameObject);
            canDrag = false;
        }
        
    }

    public override void OnTouch(Touch t)
    {
        if (canDrag)
        {
            Vector3 r = Camera.main.ScreenToWorldPoint(t.position);
            r = new Vector3(r.x, r.y, 0);
            transform.position = r;
        }
    }


	// Update is called once per frame
	void Update ()
    {
        base.Update();
	}
}
