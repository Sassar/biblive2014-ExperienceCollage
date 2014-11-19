using UnityEngine;
using System.Collections;

public class MainManager : MonoBehaviour {

	public float screenW;

	private string One_Of_SN;	// SN:Shelf Name
	private string[] Shelf_Obj_Names = {
		"A3-1_sh", "A3-2_sh", "A4_sh", "A5_sh",
				  "B01_sh", "B02_HM", "B03_sh", "B04_sh", "B05_sh", "B06_sh", "B07_sh", "B08_sh", "B09_sh",
		"B10_sh", "B11_sh", "B12_sh", "B13_sh", "B14_sh", "B15_sh", "B16_sh", "B17_sh", "B18_sh", "B19_sh",
		"B20_sh", "B21_sh", "B22_sh", "B23_sh", "B24_sh", "B25_sh", "B26_sh", "B27_sh", "B28_sh", "B29-a_sh", "B29-b_sh", "B29+_sh", "B29-B30_sh",
		"B30_sh", "B31_sh", "B31-B32_sh", "B32_sh", "B33_sh", "B33-B34_sh","B34_sh", "B35_sh", "B35-B36_sh", "B36_sh", "B37_sh", "B37-B38_sh", "B38_sh", "B39_sh", "B39-B40_sh",
		"B40_sh", "B41-B42_sh", "B41_sh", "B42_sh", "B43_sh", 
		"D01_sh", "D02_sh", "D03_sh", "D04_sh", "D05_sh", "D06_sh", "D07_sh",
	};
	private string[] Shelf_Name;
	private int num_Of_SO;	// SO:Shelfs Object
	private float[] Movie_lengths = new float[130];
	public	float Length_Of_LM;	//LM:Longest movie
	public	float Length_Of_SM;	//SM:Shotest movie
	private MovieTexture mov_Texture;
//	private AssetImporter mov;
	private int i =0;

	// Use this for initialization
	void Start () {

		screenW = Screen.width;
		num_Of_SO = Shelf_Obj_Names.Length;

		//get movies' length 
		for(i=0; i<num_Of_SO; i++){
//			Shelf_Name[i] = Shelf_Obj_Names[i].Replace("_HM", "");
//			mov = GameObject.Find (Shelf_Name);

//			mov_Texture = GameObject.Find (Shelf_Obj_Names[i]).renderer.material.mainTexture as MovieTexture;
//			Movie_lengths[i] = mov_Texture.duration;
		}


		//		//get most longest & shotest length in all movies
		quick(Movie_lengths, 0, num_Of_SO-1);
		Length_Of_LM = Movie_lengths[0];
		Length_Of_SM = Movie_lengths[num_Of_SO-1];

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

	//quick sort
	void quick(float[] a, int left, int right){
		int pl = left;	//left cursor
		int pr = right;	//right cursor
		float centerF = (pl + pr) / 2;
		int centerI= (int) centerF;
		float x = a[centerI];	//center
		float temp;
		do{
			while(a[pl] < x)	pl++;
			while(a[pr] > x)	pr--;
			if(pl <= pr){
				temp = a[pl];
				a[pl] = a[pr];
				a[pr] = temp;
				pl++;
				pl--;
			}
		} while(pl <= pr);
		if(left < pr)	quick(a, left, pr);
		if(pl < right)	quick(a, pl, right);
	}
}