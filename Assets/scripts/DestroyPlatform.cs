using UnityEngine;
using System.Collections;

public class DestroyPlatform : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	void OnCollisionEnter(Collision coll) {
		Debug.Log(coll.gameObject.tag);


		if (coll.gameObject.tag == "Player") {
			Debug.Log("ello");


			Destroy (gameObject, 10f);

}

}
}