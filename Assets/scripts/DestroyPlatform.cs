using UnityEngine;
using System.Collections;

public class DestroyPlatform : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("invis");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnBecameInvisible() {
		Debug.Log ("invis");
		Destroy(gameObject);
	}
}
