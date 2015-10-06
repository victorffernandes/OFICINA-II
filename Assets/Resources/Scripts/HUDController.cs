using UnityEngine;
using System.Collections;

public class HUDController : MonoBehaviour {

	public void changeScene(string h)
	{
		StartCoroutine( changeC (h) );
	}

	public void ScoreToPlayerPrefs()
	{
		foreach (string s in DPuzzle.points) {
			PlayerPrefs.SetInt(s, PlayerPrefs.GetInt(s)+1);
			Debug.Log(PlayerPrefs.GetInt(s));
		}
	}



	public IEnumerator changeC(string g)
	{
		GameObject.FindGameObjectWithTag("fade").GetComponent<Animator>().Play("fadeOut");
		yield return new WaitForSeconds (1.5f);
		Application.LoadLevel(g);
	}
}
