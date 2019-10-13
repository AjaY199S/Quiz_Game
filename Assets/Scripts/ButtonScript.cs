using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour {

	public GameObject button_name;
	public GameObject button_name1;
	public bool muteI;

	// Use this for initialization
	void Start () {
		button_name.SetActive (true);
		button_name1.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void ShowPanel()
	{
		button_name.gameObject.SetActive (false);
		button_name1.gameObject.SetActive (true);
	}
	public void Quit_Game()
	{
		Debug.Log ("Game Is Out");
		Application.Quit();
	}
	public void MUTEfuc()
	{
		muteI =! muteI;
		AudioListener.volume = muteI ? 0 : 1;
	}
}
