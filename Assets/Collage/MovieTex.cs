using UnityEngine;
using System.Collections;
using System.IO;

public class MovieTex : MonoBehaviour {
	public TextMesh TexC;
	public string fileName;
	public MovieTexture movTexture;
	public GameObject player_num;
	public float loc_x;
	public float loc_y;
	public float loc_z;
	public Font myFont;


	// Use this for initialization
	void Start () {
		string test = this.gameObject.name;
		string[] path_array = Directory.GetFiles( Application.dataPath + "/Resources/" + test , "*.*" );
		string path = string.Join ("",path_array);
		
		fileName = System.IO.Path.GetFileNameWithoutExtension (path);
		fileName = System.IO.Path.GetFileNameWithoutExtension (fileName);
		//int array_num = path_array.Length;
		//Debug.Log (path);
		/*
		for( int i = 0; i < array_num; i++ ){
			
			Debug.Log( path_array[i] );
			
		}
		 */
		GameObject cube = this.gameObject;
		cube.renderer.material.mainTexture = Resources.Load (test + "/" + fileName) as MovieTexture;
		movTexture = cube.renderer.material.mainTexture as MovieTexture;

		player_num = new GameObject("Player_num");
		player_num.AddComponent ("TextMesh");
		player_num.GetComponent<TextMesh>().text = fileName;
		player_num.GetComponent<TextMesh>().fontSize = 1;
		//player_num.font.material.SetPass;


		myFont = (Font) Resources.Load ("font/fabian"); 
		//player_num.GetComponent<MeshRenderer> ().materials = 
 

		player_num.GetComponent<TextMesh>().font = myFont;
		player_num.transform.parent = cube.transform;
		loc_x = cube.transform.position.x;
		loc_y = cube.transform.position.y;
		loc_z = cube.transform.position.z;

		player_num.transform.position = new Vector3 (loc_x, loc_y, loc_z);		
		//player_num.transform.position.x = loc_x;
		//player_num.transform.position.x = loc_y;
		//player_num.transform.position.x = loc_z;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			if(movTexture.isPlaying){
				movTexture.Pause ();
			}else{
				movTexture.Play ();
				movTexture.loop = true;
			}
		}
	}
}