using UnityEngine;
using System.Collections;

public class SpeedPickup : MonoBehaviour {
	
	private timer TimeLeft;
	



	void Start(){
		
		//Player = GObject.FindGameObjectWithTag ("Player");
		//TimeLeft = GameObject.FindGameObjectWithTag ("Canvas").GetComponent<Text> ();
		TimeLeft = GameObject.Find("timer").GetComponentInChildren<timer>();

	}

		void OnCollisionEnter(Collision coll) {
			Debug.Log(coll.gameObject.tag);
		Debug.Log("NIELS IS LElIJK");


		if (coll.gameObject.tag == "Player") {
			Debug.Log("ello");
	
			TimeLeft.targetTime += 10f;

			Destroy (gameObject);

		}

	}
}