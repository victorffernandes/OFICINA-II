using UnityEngine;
using System.Collections;

public class CloudController : MonoBehaviour {
    public float speed;
    bool isAlive = true;

    public void startFading()
    {
        SpriteRenderer sp = GetComponent<SpriteRenderer>();
        sp.color = new Color(sp.color.r, sp.color.g, sp.color.b, sp.color.a - 0.01f);
        if (sp.color.a <= 0) Destroy(gameObject);
    }

	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        if (!isAlive) startFading();
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "EndPhase")
        {
            isAlive = false;
        }
    }
}
