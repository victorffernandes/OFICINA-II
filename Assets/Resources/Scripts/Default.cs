using UnityEngine;
using System.Collections;

public abstract class Default : MonoBehaviour {

    public void LookAt2D(Vector3 target)
    {
        Vector3 dir = target - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    public virtual void OnTouch(Touch t ) { }


    


	public virtual void Update () {
        if (Input.touchSupported && Input.touchCount > 0) {
			for (int i = 0; i < Input.touchCount; i++) {
				Vector2 point = new Vector2 (Input.GetTouch (i).position.x, Input.GetTouch (i).position.y);
				if (this.gameObject.collider2D.OverlapPoint (Camera.main.ScreenToWorldPoint (point)))
					OnTouch (Input.GetTouch (i));
			}
		} 
		else 
		{
			try
			{}
		}
	}
}
