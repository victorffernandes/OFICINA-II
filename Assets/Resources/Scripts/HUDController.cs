using UnityEngine;
using System.Collections;

public class HUDController : MonoBehaviour {

	public void changeScene(string g)
    {
        Application.LoadLevel(g);
    }
}
