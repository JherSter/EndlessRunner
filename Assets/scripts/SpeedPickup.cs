using UnityEngine;
using System.Collections;

public class SpeedPickup : MonoBehaviour {
	

	



	void Start(){
		
		//Player = GObject.FindGameObjectWithTag ("Player");
		//TimeLeft = GameObject.FindGameObjectWithTag ("Canvas").GetComponent<Text> ();
	

	}

		void OnCollisionEnter(Collision coll) {
			Debug.Log(coll.gameObject.tag);
		Debug.Log("NIELS IS LElIJK");


		if (coll.gameObject.tag == "Player") {
			Debug.Log("ello");
	;
			

			Destroy (gameObject);

		}

	}
}