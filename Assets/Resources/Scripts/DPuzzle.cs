using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class DPuzzle : Default {
    public bool isSolved = false;
    public bool canCall = false;
    public string puzzle;
    public DragDrop[] Drag;
	public static List<string> points;

    void startPuzzle()
    {
        canCall = true;
		if (puzzle == "fase1_5") {
			Drag [0].gameObject.GetComponent<AudioSource> ().Play ();
		}
    }

	void Start()
	{
		points = new List<string> ();
		DPuzzle.points = new List<string> ();
	}

    void outPuzzle() 
    {
        if (!isSolved)
        {
            foreach (DragDrop d in Drag)
            {
                if (!d.matchAttached)
                {
                    d.canMatch = false;
                    d.canFollow = false;
                    d.GetComponent<Transform>().position = d.startPosition;
                }
            }
        }
    }

	public GameObject getChildWithTag(string str)
	{
		for (int i = 0; i < transform.childCount; i++) {
			if(transform.GetChild(i).tag == str)return transform.GetChild(i).gameObject;
		}
		return gameObject;
	}

	// Update is called once per frame
	new void Update () 
    {
	    if(!isSolved && canCall)
        {
            switch(puzzle)
            {
                #region Joao
            case "fase1_1":
                int e = 0;
                    for (int i = 0; i < Drag.Length;i++ )
                    {
                        if (Drag[i].matchAttached) e++;
                    }
                    if (e.Equals(Drag.Length))
                    {
						DPuzzle.points.Add("gold");
                        isSolved = true;
                        Destroy(transform.GetComponentInChildren<Animator>().gameObject);
                        FindObjectOfType<PlayerManager>().isWalking = true;
                        FindObjectOfType<PlayerManager>().GetComponent<Animator>().SetBool("isWalking", true);
                        FindObjectOfType<PlayerManager>().GetComponent<AudioSource>().Play();
						getChildWithTag("Win").GetComponent<Animator>().Play("win");
                    }
                break;

           case "fase1_2":
                     e = 0;
                    for (int i = 0; i < Drag.Length;i++ )
                    {
                        if (Drag[i].matchAttached) e++;
                    }
                    if (e.Equals(Drag.Length))
                    {
					DPuzzle.points.Add("gold");
                        isSolved = true;
						Drag[0].match.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/puzzle2");
                        FindObjectOfType<PlayerManager>().GetComponent<AudioSource>().Play();
						getChildWithTag("Win").GetComponent<Animator>().Play("win");
                    }
               break;

			case "fase1_3":
				e = 0;
				for (int i = 0; i < Drag.Length;i++ )
				{
					if (Drag[i].matchAttached) e++;
				}
				if (e.Equals(Drag.Length))
				{
					DPuzzle.points.Add("gold");
					isSolved = true;
                    FindObjectOfType<PlayerManager>().GetComponent<AudioSource>().Play();
					getChildWithTag("Win").GetComponent<Animator>().Play("win");
				}
				break;

			case "fase1_4":
				e = 0;
				for (int i = 0; i < Drag.Length;i++ )
				{
					if (Drag[i].matchAttached) e++;
				}
				if (e.Equals(Drag.Length))
				{
					DPuzzle.points.Add("silver");
					isSolved = true;
                    FindObjectOfType<PlayerManager>().GetComponent<AudioSource>().Play();
					getChildWithTag("Win").GetComponent<Animator>().Play("win");
				}
				break;
			case "fase1_5":

				e = 0;
				for (int i = 0; i < Drag.Length;i++ )
				{
					if (Drag[i].matchAttached) e++;
				}
				if (e.Equals(Drag.Length))
				{
					DPuzzle.points.Add("gold");
					isSolved = true;
					GetComponentInChildren<AudioSource>().enabled = false;
                    FindObjectOfType<PlayerManager>().GetComponent<AudioSource>().Play();
					getChildWithTag("Win").GetComponent<Animator>().Play("win");
				}
				break;
			case "fase1_6":
				e = 0;
				for (int i = 0; i < Drag.Length;i++ )
				{
					if (Drag[i].matchAttached) e++;
				}
				if (e.Equals(Drag.Length))
				{
					DPuzzle.points.Add("gold");
					isSolved = true;
                    FindObjectOfType<PlayerManager>().GetComponent<AudioSource>().Play();
					getChildWithTag("Win").GetComponent<Animator>().Play("win");
				}
				break;
			
			case "fase2_1":
				e = 0;
				for (int i = 0; i < Drag.Length;i++ )
				{
					if (Drag[i].matchAttached) e++;
				}
				if (e.Equals(Drag.Length))
				{
					DPuzzle.points.Add("silver");
					isSolved = true;
					FindObjectOfType<PlayerManager>().GetComponent<AudioSource>().Play();
					getChildWithTag("Win").GetComponent<Animator>().Play("win");
					gameObject.transform.FindChild("WalkingGirl").gameObject.GetComponent<Animator>().SetBool("isWalking",true);
				}
				break;

			case "fase2_2":
				e = 0;
				GetComponentInChildren<EgretController>().canFly = true;
				for (int i = 0; i < Drag.Length;i++ )
				{
					if (Drag[i].matchAttached) e++;
				}
				if (e.Equals(Drag.Length))
				{
					DPuzzle.points.Add("silver");
					isSolved = true;
					getChildWithTag("Win").GetComponent<Animator>().Play("win");
					FindObjectOfType<PlayerManager>().GetComponent<AudioSource>().Play();
					points.Add("silver");
					Drag[0].match.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/men2");
					Destroy(Drag[0].gameObject);
				}
				break;

			case "fase2_3":
				e = 0;

				for (int i = 0; i < Drag.Length;i++ )
				{
					if (Drag[i].matchAttached) e++;
				}
				if (e.Equals(Drag.Length))
				{
					DPuzzle.points.Add("silver");
					isSolved = true;
					getChildWithTag("Win").GetComponent<Animator>().Play("win");
					FindObjectOfType<PlayerManager>().GetComponent<AudioSource>().Play();
					Drag[0].match.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/muroPintado");
					Destroy(Drag[0].gameObject);
				}
				break;

			case "fase2_4":
				e = 0;
				for (int i = 0; i < Drag.Length;i++ )
				{
					if (Drag[i].matchAttached) e++;
				}
				if (e.Equals(Drag.Length))
				{
					DPuzzle.points.Add("bronze");
					isSolved = true;
					getChildWithTag("Win").GetComponent<Animator>().Play("win");
					FindObjectOfType<PlayerManager>().GetComponent<AudioSource>().Play();
					transform.GetComponentInChildren<AudioSource>().enabled = HUDController.isOn;
					transform.GetComponentInChildren<AudioSource>().Play();
					Destroy(Drag[0].gameObject);
				}
				break;

			case "fase2_5":
				e = 0;
				for (int i = 0; i < Drag.Length;i++ )
				{
					if (Drag[i].matchAttached) e++;
				}
				if (e.Equals(Drag.Length))
				{
					DPuzzle.points.Add("bronze");
					isSolved = true;
					getChildWithTag("Win").GetComponent<Animator>().Play("win");
					FindObjectOfType<PlayerManager>().GetComponent<AudioSource>().Play();
				}
				break;

			case "fase2_6":
				e = 0;
				for (int i = 0; i < Drag.Length;i++ )
				{
					if (Drag[i].matchAttached) e++;
				}
				if (e.Equals(Drag.Length))
				{
					DPuzzle.points.Add("bronze");
					isSolved = true;
					getChildWithTag("Win").GetComponent<Animator>().Play("win");
					FindObjectOfType<PlayerManager>().GetComponent<AudioSource>().Play();
					GameObject.FindGameObjectWithTag("Hose").GetComponent<Animator>().Play("hoseWater");
					GameObject.FindGameObjectWithTag("House").GetComponent<Animator>().Play("safeHouse");
				}
				break;
				

				//            case "joao_2"://drag All
//                Animator g = transform.FindChild("EnterPuzzle").GetComponent<Animator>();
//                       g.SetInteger("tutorialType", 2);
//                    int n = 0;
//                for (int i = 0; i < Drag.Length;i++)
//                {
//                    if (Drag[i].wasTouched) n++;
//                }
//                if(n.Equals(Drag.Length))
//                {
//                    int k = 0;
//                    for (int i = 0; i < Drag.Length; i++)
//                    {
//                        Drag[i].canMatch = true;
//                        if (Drag[i].matchAttached) k++;
//                    }
//                }
//                else
//                {
//                    for (int i = 0; i < Drag.Length; i++)
//                    {
//                        Drag[i].canMatch = false;
//                    }
//                }
//                int m=0;
//                for (int i = 0; i < Drag.Length; i++)
//                {
//                    if (Drag[i].matchAttached) m++;
//                }
//                if (m.Equals(Drag.Length))
//                {
//                    FindObjectOfType<PlayerManager>().isWalking = true;
//                    fAnim.SetBool("isSolved", true);
//                    Animator a = transform.FindChild("EnterPuzzle").GetComponent<Animator>();
//                    a.SetInteger("tutorialType", 3);
//                    a.enabled = false;
//                    Drag[0].match.GetComponent<SpriteRenderer>().sprite = aImg[0];
//                    Destroy(transform.FindChild("EnterPuzzle").transform.FindChild("hand").gameObject);
//                    isSolved = true;
//                }
//                    break;
//            case "joao_3":
//               Animator x = transform.FindChild("EnterPuzzle").GetComponent<Animator>();
//                       x.SetInteger("tutorialType", 3);
//                    if (FindObjectOfType<PlayerManager>().paperCount > 0)
//                    {
//                        FindObjectOfType<PlayerManager>().isWalking = true;
//                        transform.FindChild("EnterPuzzle").GetComponent<Animator>().enabled = false;
//                        Destroy(transform.FindChild("EnterPuzzle").transform.FindChild("hand").gameObject);
//                        fAnim.SetBool("isSolved", true);
//                        isSolved = true;
//                    }
//
//                        break;
//			case "joao_4":
//                        if (Drag[0].matchAttached)
//                        {
//                            isSolved = true;
//                            fAnim.SetBool("isSolved", true);
//                        }
//				break;
//
//            case "joao_5":
//                int o = 0;
//                for (int i = 0; i < Drag.Length;i++)
//                {
//                    if (Drag[i].matchAttached) o++;
//
//                }
//                if (o.Equals(Drag.Length))
//                {
//                    fAnim.SetBool("isSolved", true);
//                    isSolved = true;
//                }
//                break;

            #endregion
            }

        }

	}
}
