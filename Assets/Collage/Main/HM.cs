using UnityEngine;
using System.Collections;

public class HM: MonoBehaviour {
	
	private float alpha = 1.0f;
	private float G = 0.0f;
	private float B = 1.0f;
	private string Shelf_Name;	// This shelf name
	private MovieTexture mov_Texture;
	public	float mov_Length = 0.0f;
	public	float max_ML = 1.0f;	// Max Movie Length
	
	GameObject Target_Shelf;
	GameObject ref_Obj = null;
	MainManager Main_Manager;

	// Use this for initialization
	void Start () {
		//get this gameObject
		Shelf_Name = this.gameObject.name;
//		Shelf_Name = Shelf_Name.Replace("_HM", "");
		Target_Shelf = GameObject.Find (Shelf_Name);

		//get this  shelf's movie length
		mov_Texture = Target_Shelf.renderer.material.mainTexture as MovieTexture;
		mov_Length = mov_Texture.duration;
		
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