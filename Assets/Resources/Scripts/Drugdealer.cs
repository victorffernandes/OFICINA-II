using UnityEngine;
using System.Collections;

public class Drugdealer : MonoBehaviour {
	public GameObject cigarro;
	public float speed;
	// Use this for initialization
	void Start () {
		cigarro = GameObject.FindGameObjectWithTag("Cigarro");
	}
	
	// Update is called once per frame
	void Update () {
	if (cigarro.GetComponent<DraggableObj> ().matchFound)
	{
			transform.position += new Vector3(0,Time.deltaTime * speed,0);		
	}
	
}
}
