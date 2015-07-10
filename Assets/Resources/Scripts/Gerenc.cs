using UnityEngine;
using System.Collections;

public class Gerenc : Default {
    GameObject player;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}

    IEnumerator StartTimerForBus()
    {
        yield return new WaitForSeconds(4f);
        //if()
    }

    void StartBusPuzzle()
    {
        SpriteRenderer sr = GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>();
        sr.color = Color.cyan;
        Vector3 newScale = new Vector3(sr.transform.localScale.x * 4, sr.transform.localScale.y * 2, 0);
        sr.transform.localScale += newScale;
        sr.sprite.texture.height += (sr.sprite.texture.height * 2);
        StartCoroutine(StartTimerForBus());
    }

	void CorrectChoice()
	{
		player.GetComponent<Player>().nextChoice = 1;
        StartBusPuzzle();
	}

	void WrongChoice()
	{
		player.GetComponent<Player> ().nextChoice = 0;
        StartBusPuzzle();
	}

	// Update is called once per frame
	void Update () {
        Screen.orientation = ScreenOrientation.LandscapeLeft;                                                                 
	}
}
