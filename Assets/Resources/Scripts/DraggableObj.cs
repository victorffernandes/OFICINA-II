using UnityEngine;
using System.Collections;

public class DraggableObj : Default {
    public string match;
    public bool canDrag;
    public bool matchFound = false;
	// Use this for initialization
	void Start () {
        canDrag = true;
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(match);
        if (col.gameObject.tag.Equals(match) )
        {
			collider2D.enabled = false;
            transform.position = col.gameObject.transform.position;
            Destroy(col.gameObject);
            matchFound = true;
            canDrag = false;
        }
        
    }

    public override void OnTouch(Touch t,Vector3 p)
    {
        if (canDrag)
        {
            Vector3 r = Camera.main.ScreenToWorldPoint(p);
            r = new Vector3(r.x, r.y, 0);
            transform.position = r;
        }
    }


	// Update is called once per frame
    public override void Update()
    {
        base.Update();
	}
}
