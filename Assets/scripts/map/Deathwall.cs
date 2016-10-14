using UnityEngine;
using System.Collections;

public class Deathwall : MonoBehaviour {


    void OnCollisionEnter(Collision col)

    {
		if (col.gameObject.name == "Player"){
            Application.LoadLevel("main menu");
        

            Destroy(col.gameObject);
            
        }
    }

}
