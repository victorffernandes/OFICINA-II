using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

    public void LoadLevel(string level)
    {
        Application.LoadLevel(level);
        Gerenc.points = 200;
    }
}
