using UnityEngine;
using System.Collections;

public class HM_for_B29b_sh: MonoBehaviour {

	private float alpha = 1.0f;
	private float G = 0.0f;
	private float B = 0.0f;
	private string[] Shelf_Name = {"B29-4", "B29-5", "B29-6"};	// Target shelfs' names
	private MovieTexture mov_Texture;
	public	float mov_Length = 0.0f;
	public	float max_ML = 1.0f;	// Max Movie Length
	
	GameObject Target_Shelf;
	GameObject ref_Obj = null;
	MainManager Main_Manager;
	
	// Use this for initialization
	void Start () {

		for(int i=0; i<3; i++){
			//get this gameObject
			Target_Shelf = GameObject.Find (Shelf_Name[i]);
			
			//get this  shelf's movie length
			mov_Texture = Target_Shelf.renderer.material.mainTexture as MovieTexture;
			mov_Length += mov_Texture.duration;
		}
		
		//get maximum movie length
		Main_Manager = ref_Obj.GetComponent<MainManager>();
		max_ML = Main_Manager.Length_Of_LM;
		
		//change color of this shelf in heat map
		G = mov_Length / max_ML;
		B = G;
		this.renderer.material.color = new Color (1.0f, G, B, alpha);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
