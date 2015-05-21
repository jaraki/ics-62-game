using UnityEngine;
using System.Collections;

public class RedBloodCell : MonoBehaviour {
	public int speed;
	private int x;
	private int y;
	private int z;
	public GameObject target;

	// Use this for initialization
	void Start () {
		x = (int)(Random.value * 180);
		y = (int)(Random.value * 180);
		z = (int)(Random.value * 180);

	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (x * Time.deltaTime, y * Time.deltaTime, z * Time.deltaTime);
		transform.position += Vector3.forward * speed * Time.deltaTime;
	}
}
