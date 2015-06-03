using UnityEngine;
using System.Collections;

public class BloodVesselSystem : MonoBehaviour {
    public BloodVessel bloodVesselPrefab;

    public int pipeCount;

    private BloodVessel[] pipes;

    private void Awake() {
        pipes = new BloodVessel[pipeCount];
        for (int i = 0; i < pipes.Length; i++) {
            BloodVessel bloodVessel = pipes[i] = Instantiate<BloodVessel>(bloodVesselPrefab);
            bloodVessel.transform.SetParent(transform, false);
            bloodVessel.Generate();
            if (i > 0) {
                bloodVessel.AlignWith(pipes[i - 1]);
            }
        }
        AlignNextPipeWithOrigin();
    }

    public BloodVessel SetupNextPipe() {
        ShiftPipes();
        AlignNextPipeWithOrigin();
        pipes[pipes.Length - 1].Generate();
        pipes[pipes.Length - 1].AlignWith(pipes[pipes.Length - 2]);
        transform.localPosition = new Vector3(0f, -pipes[1].CurveRadius);
        return pipes[1];
    }

    private void ShiftPipes() {
        BloodVessel temp = pipes[0];
        for (int i = 1; i < pipes.Length; i++) {
            pipes[i - 1] = pipes[i];
        }
        pipes[pipes.Length - 1] = temp;
    }

    private void AlignNextPipeWithOrigin() {
        Transform transformToAlign = pipes[1].transform;
        for (int i = 0; i < pipes.Length; i++) {
            if (i != 1) {
                pipes[i].transform.SetParent(transformToAlign);
            }
            
        }

        transformToAlign.localPosition = Vector3.zero;
        transformToAlign.localRotation = Quaternion.identity;

        for (int i = 0; i < pipes.Length; i++) {
            if (i != 1) {
                pipes[i].transform.SetParent(transform);
            }
            
        }
    }

    public BloodVessel SetupFirstPipe() {
        transform.localPosition = new Vector3(0f, -pipes[1].CurveRadius);
        return pipes[1];
    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
