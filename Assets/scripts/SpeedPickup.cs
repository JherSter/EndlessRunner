using UnityEngine;
using System.Collections;

public class SpeedPickup : MonoBehaviour {
	
	private PlayerMovement playerMovement;


	void Start(){
		
		//Player = GameObject.FindGameObjectWithTag ("Player");
		playerMovement = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerMovement> ();


	}

		void OnCollisionEnter(Collision coll) {
			Debug.Log(coll.gameObject.tag);


		if (coll.gameObject.tag == "Player") {
			Debug.Log("ello");
			

			Destroy (gameObject);

		}

	}
}