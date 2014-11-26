using UnityEngine;
using System.Collections;
using System.IO;

public class MovieTest : MonoBehaviour {
	public MovieTexture movie;

	// Use this for initialization
	IEnumerator Start() {
		string shelfname = this.gameObject.name;
		GameObject cube = this.gameObject;
		string url = "http://biblive2014a.php.xdomain.jp/" + shelfname + ".ogg";
		Debug.Log (url);
		//start download
		WWW www = new WWW(url);
		yield return www;

		//regard this object as movieTexture
		cube.renderer.material.mainTexture = www.movie as MovieTexture; //www.texture?
		movie = cube.renderer.material.mainTexture as MovieTexture;
	}
	
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			if(movie.isPlaying){
				movie.Pause ();
			}else if(!movie.isPlaying && movie.isReadyToPlay){
				movie.Play ();
				movie.loop = true;
			}
		}
	}
}
