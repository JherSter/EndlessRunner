using UnityEngine;
using System.Collections;

public class Deathwall : MonoBehaviour {


    void OnCollisionEnter(Collision col)

    {
        if (col.gameObject.name == "player")

    {

    Destroy(col.gameObject);
}
}

}
