using UnityEngine;
using System.Collections;

public class TitleManager : MonoBehaviour {
	
	public float screenW = Screen.width;
	public float screenH = Screen.height;
	
	// Use this for initialization
	void Start () {
	}
	
	
	// Update is called once per frame
	void Update () {
		if (Application.platform == RuntimePlatform.Android && Input.GetKey(KeyCode.Escape)) {
			Application.Quit ();
		}
	}
	void OnGUI(){
		//StartButton
		if (GUI.Button (new Rect (screenW*2/3, screenH*3/5, 100, 50), "Start")) {
			Application.LoadLevel(1);
		}
		
		//QuitButton
		if (GUI.Button (new Rect (screenW*2/3, screenH*3/5+60, 100, 50), "Quit")) {
			Application.Quit ();
		}
	}
}