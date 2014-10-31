using UnityEngine;
using System.Collections;

public class test_miniMap_Camera : MonoBehaviour {
	void Start()
	{
		GameObject obj = new GameObject();
		Camera camera = obj.AddComponent<Camera>();
		camera.rect = new Rect(0.25F, 0.5F, 0.25F, 0.25F);
	}
}
