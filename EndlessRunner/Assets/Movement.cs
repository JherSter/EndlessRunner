using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    
  public float movementSpeed = 10f;
    public Rigidbody rb;


    void Start() {

    }

    void Update()
    {
        Vector3 movement = new Vector3(2F, 0F, 0F);
        rb.velocity = movement * movementSpeed;
    }
}







