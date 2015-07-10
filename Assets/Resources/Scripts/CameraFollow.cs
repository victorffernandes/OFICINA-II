using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
    public Transform player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = new Vector3(player.position.x + 5, player.position.y + 0.2f, -10);

	}
}
