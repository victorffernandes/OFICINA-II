using UnityEngine;
using System.Collections;

public class DragDrop : Default {
    public Vector3 startPosition;
	private GameObject instPoint;
    public GameObject match;
    public bool wasTouched = false;
    public bool matchAttached = false;
    public bool canMatch;
    public bool canFollow;
    public Vector3 matchedPosition;
    //Vector3 pointerPos;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.Equals(match) && canMatch && !matchAttached)
        {
            matchAttached = true;
            transform.localPosition = matchedPosition;
        }

    }
	

    public override void OnTouch(object t)
    {
        if(t is Touch)
        {
            if ( !matchAttached)
            {
                //pointerPos = ((Touch)t).position; 
                wasTouched = true;
            }
        }
        else if (t is Vector3)
        {
            if (Input.GetButton("Fire1") &&  !matchAttached)
            {
                //pointerPos = ((Vector3)t);
                wasTouched = true;
            }
        }
    }
	void Start () {
       startPosition =  transform.position;
       canFollow = true;
		GameObject g = Resources.Load ("Prefabs/InterestPoint") as GameObject;
		instPoint = (GameObject)Instantiate(g,g.transform.TransformPoint(gameObject.transform.position) , Quaternion.identity);
       //GameObject g = (GameObject)Instantiate(Resources.Load("Prefabs/InterestPoint"), Vector3.zero, Quaternion.identity);
       //g.transform.parent = gameObject.transform;
       //g.transform.localPosition = new Vector3(0, 0, 0);
	}
	new void Update () {
        
		if (!matchAttached) {
			instPoint.GetComponent<SpriteRenderer> ().enabled = true;
		}
        if (Input.touchSupported && Input.touchCount != 0 && wasTouched && canFollow && !matchAttached)
        {
            Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            transform.position = new Vector3(worldPoint.x, worldPoint.y, 0);
			instPoint.GetComponent<SpriteRenderer>().enabled = false;
        }
        else if (wasTouched && Input.GetButton("Fire1") && !matchAttached && canFollow)
        {
            Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(worldPoint.x, worldPoint.y, 0);
			instPoint.GetComponent<SpriteRenderer>().enabled = false;
        }
        else { wasTouched = false; }

        if (!matchAttached)
        {
            base.Update();
            if (!wasTouched) transform.position = startPosition;
        }
	}
}
