using UnityEngine;
using System.Collections;

public class MainManager : MonoBehaviour {

	public float screenW;

	private string One_Of_SN;	// SN:Shelf Name
	private string[] Shelf_Obj_Names = {"B1_HM", "B2_HM"};	// need to fix!!!!!!!!!!!!!
	private int num_Of_SO;	// SO:Shelfs Object
	private float[] Movie_lengths = new float[130];
	public	float Length_Of_LM = null;	//LM:Longest movie
	public	float Length_Of_SM = null;	//SM:Shotest movie
	private MovieTexture mov_Texture;
	private int i =0;

	// Use this for initialization
	void Start () {
		screenW = Screen.width;

		num_Of_SO = Shelf_Obj_Names.Length;
		//get movies' length 
		for(i=0; i < num_Of_SO; i++){
			mov_Texture = GameObject.Find (Shelf_Obj_Names[i]).renderer.material.mainTexture as MovieTexture;
			Movie_lengths[i] = mov_Texture.duration;
		}
		
		//get most longest & shotest length in all movies
		Length_Of_LM = Movie_lengths.Max();
		Length_Of_SM = Movie_lengths.Min();

//		for(i=0; i<num_Of_SO; i++){
//			if(Length_Of_LM < Movie_lengths[i]){
//				Length_Of_LM = Movie_lengths[i];
//			} else if(Length_Of_SM > Movie_lengths[i]){
//				Length_Of_SM = Movie_lengths[i];
//			}
//		}
	}

	// Update is called once per frame
	void Update () {
		//back to "Title" scene
		if (Application.platform == RuntimePlatform.Android && Input.GetKey(KeyCode.Escape)) {
			Application.LoadLevel(0);
		}
	}
	void OnGUI(){
		//TitleButton 
		if (GUI.Button (new Rect (screenW-55, 10, 50, 25), "Title")) {
			Application.LoadLevel(0);
		}
	}
}