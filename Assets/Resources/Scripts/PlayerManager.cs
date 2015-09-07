﻿using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

    public bool isWalking = true;
    public float speed;
    public bool isPlaying = true;

	// Use this for initialization
	void Start () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag.Equals("EnterPuzzle"))
        {
            col.gameObject.transform.parent.SendMessage("startPuzzle");
        }
        if (col.gameObject.tag.Equals("EndPhase") && isPlaying)
        {
            isWalking = false;
            isPlaying = false;
            FindObjectOfType<HUDController>().changeScene("Menu");
        }

        if (col.gameObject.layer.Equals(8) && col.gameObject.tag.Equals("EnterPuzzle") && !col.transform.parent.GetComponent<DPuzzle>().isSolved)
        {
            isWalking = false;
            GetComponent<Animator>().SetBool("isWalking", false);
        }
        else if (col.gameObject.layer.Equals(8) && col.gameObject.tag.Equals("EnterPuzzle") && col.transform.parent.GetComponent<DPuzzle>().isSolved)
        {
			isWalking = true;
            
        }

    }

	// Update is called once per frame
	void Update () {
        if (isWalking)
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
	}
}