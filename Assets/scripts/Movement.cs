using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{


    private Rigidbody rigidBody;
    private Vector3 movement;
    public float speed;
    bool isFalling;
    public float jump;

    public float movementSpeed = 10f;
    public Rigidbody rb;



    void Awake()
    {

        rigidBody = GetComponent<Rigidbody>();


    }
    void Update()
    {

        Vector3 movement = new Vector3(2F, 0F, 0F);
        rb.velocity = movement * movementSpeed;
    }
  
    void FixedUpdate()
    {

        rigidBody.AddForce(movement.normalized * speed);
        if (Input.GetButton("Jump") && isFalling == false)
        {
            rigidBody.velocity = new Vector3(0f, jump, 0f);
            isFalling = true;
        }


    }



    void OnCollisionStay()
    {
        isFalling = false;
    }
}

