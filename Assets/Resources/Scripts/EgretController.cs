using UnityEngine;
using System.Collections;

public class EgretController : MonoBehaviour {

	public Transform target;
	bool isEating = false;
	public bool canFly = false;

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "DragEl") {
			transform.parent.GetComponent<DPuzzle>().Drag[0].wasTouched = false;
			transform.parent.GetComponent<DPuzzle>().Drag[0].gameObject.transform.position = 
				transform.parent.GetComponent<DPuzzle>().Drag[0].startPosition;
			isEating = true;
		}
	}

	void OnTriggerExit2D(Collider2D col)
	{
		if (col.gameObject.tag == "DragEl") {
			//transform.parent.GetComponent<DPuzzle>().Drag[0].gameObject.transform.position
			isEating = false;
		}
	}
	

	// Update is called once per frame
	void Update () {
		if (canFly) {
			try {
				if (transform.position.y > target.position.y) {
					transform.position -= new Vector3 (0, 1 * Time.deltaTime, 0);
				} else if (transform.position.y < target.position.y) {
					transform.position += new Vector3 (0, 1 * Time.deltaTime, 0);
				}
			} catch {
			}
			transform.position -= new Vector3 (1 * Time.deltaTime, 0, 0);
		}

	}
}
