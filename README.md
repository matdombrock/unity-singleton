# Unity Simple Singleton
Dead simple unity singleton pattern implementation with no manager.

Takes advantage of the way that unity loads objects to avoid needing a manager.

## Usage

Place this script on the object you want to be a singleton instance and give it a tag.

Implement said tag into the tag variable of this class.

## Code

```c#
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
```
