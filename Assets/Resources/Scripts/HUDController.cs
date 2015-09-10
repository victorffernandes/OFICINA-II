using UnityEngine;
using System.Collections;

public class HUDController : MonoBehaviour {

	public void changeScene(string h)
	{
		StartCoroutine( changeC (h) );
	}

	public IEnumerator changeC(string g)
	{
		GameObject.FindGameObjectWithTag("fade").GetComponent<Animator>().Play("fadeOut");
		yield return new WaitForSeconds (1.5f);
		Application.LoadLevel(g);
	}
}
