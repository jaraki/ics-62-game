using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {
	public float acceleration;
	public Rigidbody projectile;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Q)) {
			Rigidbody clone = (Rigidbody)Instantiate(projectile, transform.position, transform.rotation);
			// Add force to the cloned object in the object's forward direction
			clone.velocity = transform.TransformDirection(Vector3.forward*acceleration);
		}
	}

}
