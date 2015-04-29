using UnityEngine;
using System.Collections;

public class HorizontalController : MonoBehaviour {

	public float sensitivity;
	private float mouseHorizontal;

	void Start(){
		mouseHorizontal = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		mouseHorizontal = Input.GetAxis ("Mouse X");
		Vector3 rot = transform.localEulerAngles;
		rot.y += mouseHorizontal * sensitivity;
		transform.localEulerAngles = rot;
	}
}
