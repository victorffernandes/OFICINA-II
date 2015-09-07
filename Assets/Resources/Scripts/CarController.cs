using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour {
    public float speed;
	void Update () {
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        if (! transform.GetComponentsInChildren<SpriteRenderer>()[3].isVisible )
        {
            GetComponent<AudioSource>().volume = 0;
        }
        else 
        {
            GetComponent<AudioSource>().volume = 1;
        }
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag=="EndPhase")
        {
            Destroy(gameObject);
        }
    }

}
