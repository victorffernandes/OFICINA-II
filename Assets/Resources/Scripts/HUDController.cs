using UnityEngine;
using System.IO;
using System;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class HUDController : MonoBehaviour {

	public UnityEngine.UI.Text gold;
	public UnityEngine.UI.Text silver;
	public UnityEngine.UI.Text bronze;
	public static bool isOn = true;

	public void saveText()
	{
		string text = FindObjectOfType<InputField>().text.Replace(";"," ").Replace("|"," ");
		if (!File.Exists ("CriticasNPA_2003_GenteFina.txt")){
			System.IO.StreamWriter sw = File.CreateText("CriticasNPA_2003_GenteFina.txt");
			sw.Close();
		}
		
		using (StreamWriter file = new StreamWriter("CriticasNPA_2003_GenteFina.txt",true))
		{
			file.WriteLine(text+";"+PlayerPrefs.GetInt("gold")+";"+
			               PlayerPrefs.GetInt("silver")+";"+
			               PlayerPrefs.GetInt("bronze")+"|");
		}
		PlayerPrefs.SetInt ("gold", 0);
		PlayerPrefs.SetInt ("silver", 0);
		PlayerPrefs.SetInt ("bronze", 0);
	}


	public void switchVolume()
	{
		if(isOn)GameObject.FindGameObjectWithTag ("UISound").GetComponent<Image> ().sprite = Resources.Load<Sprite> ("Sprites/NoSound");
		if(!isOn)GameObject.FindGameObjectWithTag ("UISound").GetComponent<Image> ().sprite = Resources.Load<Sprite> ("Sprites/Sound");
		isOn = !isOn;
		foreach(AudioSource a in FindObjectsOfType<AudioSource>())
			{
			a.enabled = HUDController.isOn;
			}
	}

	void Start()
	{
		foreach(AudioSource a in FindObjectsOfType<AudioSource>())
		{
			a.enabled = HUDController.isOn;
		}
		if (Application.loadedLevelName.Equals("Ganhou")) {
				gold.text = "x"+PlayerPrefs.GetInt("gold").ToString();
				silver.text = "x"+PlayerPrefs.GetInt("silver").ToString();
			bronze.text = "x"+PlayerPrefs.GetInt("bronze").ToString();
		}
		try{
			if(!isOn)GameObject.FindGameObjectWithTag ("UISound").GetComponent<Image> ().sprite = Resources.Load<Sprite> ("Sprites/NoSound");
			if(isOn)GameObject.FindGameObjectWithTag ("UISound").GetComponent<Image> ().sprite = Resources.Load<Sprite> ("Sprites/Sound");
		}catch{}


	}

	public void changeScene(string h)
	{
		StartCoroutine( changeC (h) );
	}

	public void ScoreToPlayerPrefs()
	{
		foreach (string s in DPuzzle.points) {
			PlayerPrefs.SetInt(s, PlayerPrefs.GetInt(s)+1);
			Debug.Log(s);
		}
	}
	
	public IEnumerator changeC(string g)
	{
		GameObject.FindGameObjectWithTag("fade").GetComponent<Animator>().Play("fadeOut");
		yield return new WaitForSeconds (0.6f);
		Application.LoadLevel(g);
	}
}
