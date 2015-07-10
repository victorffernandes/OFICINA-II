using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextChange : MonoBehaviour {
    public Text t;
	// Use this for initialization
	void Start () {
        if(Application.loadedLevelName == "GameOver")
        t.text = "Pontuação :" + Gerenc.points.ToString();

        if (Application.loadedLevelName == "Ganhou")
            t.text = "Você fez " + Gerenc.points.ToString() + "pontos !";

        Gerenc.points = 200;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
