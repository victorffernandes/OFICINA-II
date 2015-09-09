using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {
	public void Change(string name)
	{
		Application.LoadLevel (name);
	}
}
