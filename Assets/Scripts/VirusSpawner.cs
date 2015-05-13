using UnityEngine;
using System.Collections;

public class VirusSpawner : MonoBehaviour {
    public int maxViruses;
    public static int numViruses;
    public Rigidbody virus;
    private float spawnTime;
    // Use this for initialization
    void Start() {
        numViruses = 0;
        spawnTime = 0f;
    }

    // Update is called once per frame
    void Update() {
        int randX = Random.Range(-100, 100);
        int randZ = Random.Range(-100, 100);
        Vector3 v = new Vector3(randX, 0f, randZ);
        spawnTime -= Time.deltaTime;
        if (numViruses < maxViruses && spawnTime < 0f) {
            Instantiate(virus, v, new Quaternion());
            numViruses++;
            Game.numViruses++;
            spawnTime = 5f;
        }
    }
}
