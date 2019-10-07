using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarBehaviourScript : MonoBehaviour
{
    
    public float speed = 15.0F;
    public float jumpSpeed = 98.0F;
    public float gravity = 70.0F;
    public float rotateSpeed = 3.0F;
    private Vector3 moveDirection = Vector3.zero;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Vertical"), 0, 0);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetKeyDown(KeyCode.Space))
                moveDirection.y = jumpSpeed;

        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

        //Rotate Player
        transform.Rotate(0, Input.GetAxis("Horizontal"), 0);

    }

    // public CharacterController controller;
	// public Vector3 inputVector;
	// public float verticalVelocity;
	// public float moveSpeed = 5f;
	// public float jumpSpeed = 1.0f;
	// public float jumpForce = 1.0f;
    // public float rotateSpeed = 3.0f;
	// public bool isGrounded;
	// public float gravity = 1.0f;

	// void Start() {
	// 	controller = this.GetComponent < CharacterController > ();
	// }

	// private void OnControllerColliderHit(ControllerColliderHit hit)
	// {
	// 	if (hit.gameObject.tag == ("Ground") && isGrounded == false) {
	// 		isGrounded = true;
	// 	}
	// }

	// private void Update() {
	// 	if (controller.isGrounded) {
	// 		verticalVelocity -= gravity * Time.deltaTime;
	// 		if (Input.GetKeyDown(KeyCode.Space)) {
	// 			verticalVelocity = jumpForce;
	// 		}
	// 	}
	// 	else {
	// 		verticalVelocity -= gravity * Time.deltaTime;
	// 	}

	// 	inputVector = new Vector3(Input.GetAxis("Vertical"), verticalVelocity, -Input.GetAxis("Horizontal"));
	// 	inputVector *= moveSpeed;
	// 	// transform.LookAt(transform.position + new Vector3(inputVector.x, 0, inputVector.z));
	// 	controller.Move(inputVector * Time.deltaTime);

	// }
}
