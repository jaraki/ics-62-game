using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float jumpSpeed;
	public float moveSpeed;
	private float gravity;
	private float verticalVelocity;
	private CharacterController controller;
	// Use this for initialization
	void Start () {
		gravity = 1.0f;
		verticalVelocity = 0.0f;
		controller = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 direction = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
		Vector3 velocity = direction * moveSpeed;
		if (controller.isGrounded) {
			if (Input.GetButtonDown ("Jump")) {
				verticalVelocity = jumpSpeed;
			}
		} else {
			verticalVelocity -= gravity;
		}
		velocity.y = verticalVelocity;
		velocity = transform.TransformDirection (velocity);
		controller.Move (velocity * Time.deltaTime);
	}
}
