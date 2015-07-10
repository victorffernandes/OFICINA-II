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
        if(col.gameObject.name == "School")
        {
            Gerenc.points -= (int)(Time.fixedTime * 2);
            if(Gerenc.points > 0)
            {
                Application.LoadLevel("Ganhou");
            }
            else
            {
                Application.LoadLevel("GameOver");
            }
        }
        else if(col.gameObject.tag.Equals("WayPoint") && !col.gameObject.Equals(lastCheckPoint))
        {
                lastCheckPoint = current;
                current = col.gameObject.GetComponent<WayPoint>().options[nextChoice];
                nextChoice = 0;
                Debug.Log(lastCheckPoint.name);
                PlayerPrefs.SetString("checkPoint", lastCheckPoint.name);
        }

        if (col.gameObject.layer.Equals(8))
        {
            Gerenc.returnToCheckPoint();
        }
        if (col.gameObject.layer.Equals(9))
        {
            col.gameObject.transform.parent.gameObject.SendMessage("ActiveTrigger");
        }
		if (col.gameObject.layer.Equals (10))
		{
			isWalking = false;
		}
        if (col.gameObject.layer.Equals(11))
        {
            Application.LoadLevel("GameOver");
            Gerenc.points -= (int)(Time.fixedTime * 2) + 10;
        }

    }

	void OnTriggerExit2D(Collider2D col)
	{
		if (col.gameObject.layer.Equals (10))
		{
			isWalking = true;
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
