using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {
	public float acceleration;
    public static Antigen antigen;
    public Rigidbody projectile;
    private int numAntigens;
    // Use this for initialization
    void Start () {
        numAntigens = 3;
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Q)) {
			Rigidbody clone = (Rigidbody)Instantiate(projectile, transform.position, transform.rotation);
			// Add force to the cloned object in the object's forward direction
			clone.velocity = transform.TransformDirection(Vector3.forward*acceleration);
		}
        if (Input.GetKeyDown(KeyCode.E)) {
            antigen = (Antigen)((int)(antigen + 1) % numAntigens);
            //Debug.Log(antigen);
        }
    }

}
