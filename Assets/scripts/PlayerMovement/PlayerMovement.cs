﻿using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    public Camera playerCamera;

    public float speed = 12.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        if (playerCamera == null)
        {
            playerCamera = Camera.main;
        }


        playerCamera.transparencySortMode = TransparencySortMode.Orthographic;
    }

    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
		//zet in start 
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(1, 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
			//gebruik hieronder || om het in 1 if statement te zetten
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
            if (Input.touchCount > 0)
            {
                moveDirection.y = jumpSpeed;
            }

        }
        moveDirection.y -= gravity * Time.smoothDeltaTime;
        controller.Move(moveDirection * Time.smoothDeltaTime);


        //After we move, adjust the camera to follow the player
        playerCamera.transform.position = new Vector3(transform.position.x, transform.position.y , playerCamera.transform.position.z);
    }
}