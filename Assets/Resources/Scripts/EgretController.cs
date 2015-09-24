using UnityEngine;
using System.Collections;

public class EgretController : MonoBehaviour {

	public Transform target;
	bool isEating = false;

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "DragEl"  && isEating == false) {
			transform.parent.GetComponent<DPuzzle>().Drag[0].wasTouched = false;
			//transform.parent.GetComponent<DPuzzle>().Drag[0].gameObject.transform.position
			isEating = true;
		}
	}

	void OnTriggerExit2D(Collider2D col)
	{
		if (col.gameObject.tag == "DragEl"  && isEating == true) {
			//transform.parent.GetComponent<DPuzzle>().Drag[0].gameObject.transform.position
			isEating = false;
		}
	}



	// Update is called once per frame
	void Update () {
		try{
			if (transform.position.y > target.position.y) {
				transform.position -= new Vector3 (0, 1 * Time.deltaTime, 0);
			} else if (transform.position.y < target.position.y) {
				transform.position += new Vector3(0,1*Time.deltaTime,0);
			}
		}catch{}
		transform.position -= new Vector3 (1 * Time.deltaTime, 0, 0);

		if (isEating) {
			transform.parent.GetComponent<DPuzzle>().Drag[0].gameObject.transform.position = transform.position;
			Debug.Log("fsdfs");
		}


	}
}
