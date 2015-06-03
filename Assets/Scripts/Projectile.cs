using UnityEngine;
using System.Collections;

public enum Antigen { // will have better names once we decide which antigens to use, but just creating the infrastructure for now
    BLUE,
    GREEN,
    PURPLE
}
public class Projectile : MonoBehaviour {
    // Use this for initialization
    private float timer;
    public Material[] materials;

	void Start () {
        timer = 2f;
        Renderer[] renderers = gameObject.GetComponentsInChildren<Renderer>();
        foreach(Renderer renderer in renderers) {
            renderer.material = materials[(int)Shooter.antigen];
        }
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer < 0f) {
            Destroy(gameObject);
        }
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
