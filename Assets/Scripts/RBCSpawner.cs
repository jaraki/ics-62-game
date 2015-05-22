using UnityEngine;
using System.Collections;

public class RBCSpawner : MonoBehaviour {

		public Rigidbody rbc;
		private float spawnTime;
		// Use this for initialization
		void Start() {
			spawnTime = 0f;
		}
		
		// Update is called once per frame
		void Update() {
			int randX = Random.Range(-483, 483);
			int randY = Random.Range(0, 100);
			Vector3 v = new Vector3(randX, randY, -495);
			spawnTime -= Time.deltaTime;
			if (spawnTime < 0f) {
				Instantiate(rbc, v, new Quaternion());
				spawnTime = 5f;
			}
		}
	}
