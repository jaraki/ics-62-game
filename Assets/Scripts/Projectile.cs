using UnityEngine;
using System.Collections;

public enum Antigen { // will have better names once we decide which antigens to use, but just creating the infrastructure for now
    ZERO,
    ONE,
    TWO
}
public class Projectile : MonoBehaviour {
    // Use this for initialization


	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag == "Ground" ){
			Destroy(gameObject);
		}

        if (collision.gameObject.tag == "Virus " + ((int) Shooter.antigen).ToString()) {
            Destroy(gameObject);
            collision.gameObject.GetComponent<Virus>().damage();
        }
    }
}
