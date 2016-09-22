using UnityEngine;
using System.Collections;

public class Sliding : MonoBehaviour {

	public GameObject prefab1;
	public GameObject prefab2;
	private GameObject Prefab;
	void Start(){
		Prefab = prefab1;
	}
	void update(){
		if (Input.GetMouseButton (0)) {
			
			print ("Ello");
			Prefab = prefab1;
		}
		if (Input.GetMouseButton (0)) {
			print ("Ello2");
			Prefab = prefab2;
		}
		if (Input.GetKeyDown ("0") )
			Instantiate (Prefab, transform.position, Quaternion.identity);

		if (Input.GetKeyDown ("0") )
			Instantiate (Prefab, transform.position, Quaternion.identity);
		
	}
}
