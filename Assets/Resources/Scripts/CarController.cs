using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour {
    public float speed;
    bool isAlive = true;
    public void startFading()
    {
        int e = 0;
        foreach(SpriteRenderer sp in GetComponentsInChildren<SpriteRenderer>())
        {
            sp.color= new Color(sp.color.r, sp.color.g, sp.color.b, sp.color.a - 0.01f);
            if (sp.color.a <= 0) e++;   
        }
        if (e == GetComponentsInChildren<SpriteRenderer>().Length) Destroy(gameObject);
    }


	void Update () {
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        if (Mathf.Abs((transform.position - FindObjectOfType<PlayerManager>().transform.position).x) > 15)
        {
            GetComponent<AudioSource>().volume -= 0.01f;
        }
        else 
        {
            GetComponent<AudioSource>().volume = 0.2f;
        }
        if(!isAlive)
        {
            startFading();
        }
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag=="EndPhase")
        {
            isAlive = false;
            //GetComponent<Animator>().enabled = false;
        }
    }

}
