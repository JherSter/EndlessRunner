using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour
{


    private Rigidbody rigidBody;
    private Vector3 movement;
    public float speed;
    bool isFalling;
    public float jump;


    void Awake()
    {

        rigidBody = GetComponent<Rigidbody>();


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

