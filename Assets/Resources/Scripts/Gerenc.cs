using UnityEngine;
using System.Collections;
using UnityEngine;

public class Gerenc : Default {
    GameObject player;
    public static bool outOfBus = false;
    GameObject savedMap;
    public static bool goodAction = false;
    IEnumerator StartBusTimer()
    {
        yield return new WaitForSeconds(6f);
        if (GameObject.FindGameObjectWithTag("Seat").GetComponent<DraggableObj>().matchFound)
        {
            EndBusPuzzle();
        }
        else Debug.Log("Perdeu");
    }

	// Use this for initialization
	void Start () {
        if(Application.loadedLevelName.Equals("inBus"))
        {
            savedMap = GameObject.FindGameObjectWithTag("DontDestroy");
            savedMap.SetActive(false);
            StartCoroutine(StartTimerForBus());
        }
        if (Application.loadedLevelName.Equals("inGame"))
        {
            if(!Gerenc.outOfBus && !GameObject.FindGameObjectWithTag("DontDestroy"))
            {
                Debug.Log("ooi");
                GameObject map = Resources.Load("Prefabs/InGameMap") as GameObject;
                Instantiate(map);
            }
            else if (Gerenc.outOfBus && GameObject.FindGameObjectWithTag("DontDestroy"))
            {
                Destroy(GameObject.FindGameObjectsWithTag("DontDestroy")[1]);
                GameObject wayP = GameObject.Find("WayPoint1");
          GameObject.FindGameObjectWithTag("Player").transform.position = new Vector2(wayP.transform.position.x - 0.9f,wayP.transform.position.y);
          GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().current = GameObject.Find("WayPoint1");
            }
        }


        player = GameObject.FindGameObjectWithTag("Player");
        
	}

    IEnumerator StartTimerForBus()
    {
        yield return new WaitForSeconds(4f);
        if (GameObject.FindObjectOfType<DraggableObj>().matchFound) EndBusPuzzle();
    }

    void StartBusPuzzle()
    {
        if(Application.loadedLevelName.Equals("inGame"))
        {
            Object.DontDestroyOnLoad( GameObject.FindGameObjectWithTag("DontDestroy"));
            Application.LoadLevel("inBus");
        }
    }

    void EndBusPuzzle()
    {
        DontDestroyOnLoad(savedMap);
        savedMap.SetActive(true);
        Gerenc.outOfBus = true;
        Application.LoadLevel("inGame");
    }

	void CorrectChoice()
	{
        
	}

	void WrongChoice()
	{
        StartBusPuzzle();
	}

	// Update is called once per frame
	void Update () {
        Screen.orientation = ScreenOrientation.LandscapeLeft;                                                                 
	}
}
