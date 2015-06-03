using UnityEngine;
using System.Collections;

public class RedBloodCell : MonoBehaviour {
    private int x, y, z;
    private float timer = 2f;

    private Transform rotater;

    private void Awake() {
        rotater = transform.GetChild(0);
    }

    public void Position(BloodVessel bloodVessel, float curveRotation, float ringRotation) {
        transform.SetParent(bloodVessel.transform, false);
        transform.localRotation = Quaternion.Euler(0f, 0f, -curveRotation);
        rotater.localPosition = new Vector3(0f, bloodVessel.CurveRadius);
        rotater.localRotation = Quaternion.Euler(ringRotation, 0f, 0f);
    }

    // Use this for initialization
    void Start () {
		x = (int)(Random.value * 180);
		y = (int)(Random.value * 180);
		z = (int)(Random.value * 180);

	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer < 0f) {
            Destroy(gameObject);
        }
		transform.Rotate (x * Time.deltaTime, y * Time.deltaTime, z * Time.deltaTime);
	}
}
