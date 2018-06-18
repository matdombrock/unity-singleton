using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour {
	public string tag = "Music";
	void Start () {
		DontDestroyOnLoad (gameObject);
		GameObject[] others = GameObject.FindGameObjectsWithTag (tag);
		if (others.Length > 1) {
			Destroy (gameObject);
		}
	}
}
