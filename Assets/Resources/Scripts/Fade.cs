using UnityEngine;
using System.Collections;

public class Fade : Default {
    public float fadeSpeed;
    public static string fadeState;
    public static float alpha = 0;
    Color color;
    public Camera camera;
	// Use this for initialization
	void Start () {
        fadeState = "fadeOut";
        alpha = GetComponent<SpriteRenderer>().color.a;
        color = GetComponent<SpriteRenderer>().color;
        GetComponent<SpriteRenderer>().color -= new Color(0, 0, 0, color.a);
	}

    public static void fadeIn()
    {
        fadeState = "fadeIn";
    }

    public static void fadeOut()
    {
        fadeState = "fadeOut";
    }

	// Update is called once per frame
	void Update () 
    {
        transform.position = new Vector3(camera.transform.position.x, camera.transform.position.y, 0);
	    if( !string.IsNullOrEmpty(fadeState) && fadeState.Equals("fadeIn"))
        {
            if (alpha >= 1)
            {
                alpha = 1;
                fadeOut();
                GetComponent<SpriteRenderer>().color = new Color(color.r, color.g, color.b, alpha);
            }
            else
            {
                alpha += fadeSpeed / 100f;
                GetComponent<SpriteRenderer>().color = new Color(color.r, color.g, color.b, alpha);
            }
        }
        else if (fadeState.Equals("fadeOut"))
        {
            if (alpha <= 0)
            {
                alpha = 0;
                fadeState = "fullClear";
                GetComponent<SpriteRenderer>().color = new Color(color.r, color.g, color.b, alpha);
            }
            else
            {
                alpha -= fadeSpeed / 1000f;
                GetComponent<SpriteRenderer>().color = new Color(color.r, color.g, color.b, alpha);
            }
        }
	}
}
