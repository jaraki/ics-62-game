using UnityEngine;
using System.Collections;

public class Virus : MonoBehaviour {
    private int health;
    private int bulletDamage;
    private int speed;
    private Vector3 offset;
    private float duplicationTime;
    public GameObject target;
    // Use this for initialization
    void Start() {
        health = 100;
        bulletDamage = 50;
        speed = 5;
        duplicationTime = 5f;
        offset = new Vector3(3f, 0f, 3f);
    }

    // Update is called once per frame
    void Update() {
        if (health <= 0) {
            Destroy(gameObject);
            //VirusSpawner.numViruses--;
        }
        duplicationTime -= Time.deltaTime;
        if (duplicationTime < 0f) {
            Instantiate(this, transform.position + offset, Quaternion.identity);
            duplicationTime = 10f;
            Game.numViruses++;
        }
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * speed);
        transform.rotation = Quaternion.LookRotation(-Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * speed));
    }
    public void damage() {
        health -= bulletDamage;
    }
}
