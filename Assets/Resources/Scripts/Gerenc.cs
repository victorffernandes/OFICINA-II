using UnityEngine;
using System.Collections;

public class Gerenc : Default {
    public static GameObject player;
    public static Player pScript;
    public bool bus;
    public static bool goodAction = false;

	// Use this for initialization
	void Start () 
    {
        player = GameObject.FindGameObjectWithTag("Player");
        pScript = player.GetComponent<Player>();
    }

    public static void returnToCheckPoint()
    {
        string lastWayPointName = PlayerPrefs.GetString("checkPoint");
        Debug.Log(lastWayPointName);
        GameObject.FindGameObjectWithTag("Player").transform.position = GameObject.Find(lastWayPointName).transform.position;
    }


    IEnumerator StartBusWalking()
    {
        yield return new WaitForSeconds(2f);
        pScript.isWalking = true;
    }

	void CorrectChoice()
	{
        player.GetComponent<Player>().nextChoice = 1;
	}

	void WrongChoice()
	{
        pScript.isWalking = false;
        Fade.fadeIn();
        bus = false;
	}

	// Update is called once per frame
    public override void Update()
    {
        if( !bus && Fade.alpha == 1 )
            //player.GetComponent<SpriteRenderer>().sprite = Resource

        Screen.orientation = ScreenOrientation.LandscapeLeft;                                                                 
	}
}