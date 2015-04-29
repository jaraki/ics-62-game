using UnityEngine;
using System.Collections;

public class VerticalController : MonoBehaviour {
	
	public float sensitivity;
	private float mouseVertical;

	void Start(){
		mouseVertical = 0.0f;
	}
	// Update is called once per frame
	void Update () {
		mouseVertical = -Input.GetAxis ("Mouse Y");
		Vector3 rot = transform.localEulerAngles;
		rot.x += mouseVertical * sensitivity;
		transform.localEulerAngles = rot;
	}
}
