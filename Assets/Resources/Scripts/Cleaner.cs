using UnityEngine;
using System.Collections;

public class Cleaner : Default {
    public bool isVisible = true;
    public GameObject path;
	// Use this for initialization
	void Start () {
	
	}

    

    public override void OnTouch(Touch t, Vector3 m)
    {
        Color c = GetComponent<SpriteRenderer>().color;
        if(t.phase == TouchPhase.Moved)
        {
            GetComponent<SpriteRenderer>().color -= new Color(c.r, c.g, c.b, 0.005f);
        }

        GetComponent<SpriteRenderer>().color -= new Color(0, 0, 0, 0.005f);
        if (c.a < 0)
        {
            isVisible = false;
            Destroy(path);
        }
    }

	// Update is called once per frame
	void Update () {
        base.Update();
        
	}
}
