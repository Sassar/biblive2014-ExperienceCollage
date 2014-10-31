using UnityEngine;
using System.Collections;

public class gifAnim : MonoBehaviour {
	public Texture[] PlayerTexture;
	public float gifNum = 0;
	public float fps = 0;

	/*
	//file load
	public string FileName = "Collage_pics";
	public string digitsFormat = "0000";
	public enum digitsLocation {Prefix, Postfix};
	public digitsLocation DigitsLocation = digitsLocation.Postfix;
	string indexStr = ""; //picture's index name
	int intIndex = 0;
	*/
	void Start(){
		if (Input.GetMouseButtonDown (0)) {
			fps = 10;
			Pauser.Resume();
		}
	}

	void Update(){


		gifNum = Time.time * fps;
		gifNum = gifNum % PlayerTexture.Length;
		renderer.material.mainTexture = PlayerTexture[(int)gifNum];
		if (Input.GetMouseButtonDown (0)) {
			fps = 10;
			Pauser.Resume();
		}
		if (Input.GetMouseButtonDown (1)) {
			//fps = 1;
			//Time.timeScale = 1;

			Pauser.Pause();
		}
	}
}
