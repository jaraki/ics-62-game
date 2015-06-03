using UnityEngine;
using System.Collections;
public abstract class RedBloodCellGenerator : MonoBehaviour {

    public abstract void GenerateItems(BloodVessel bloodVessel);
}

public class RBCSpawner : RedBloodCellGenerator {
    public RedBloodCell rbcPrefab;

    public override void GenerateItems(BloodVessel bloodVessel) {
        float start = (Random.Range(0, bloodVessel.pipeSegmentCount) + 0.5f);
        float direction = Random.value < 0.5f ? 1f : -1f;

        float angleStep = bloodVessel.CurveAngle / bloodVessel.CurveSegmentCount;
        for (int i = 0; i < bloodVessel.CurveSegmentCount/2; i++) {
            RedBloodCell rbc = Instantiate<RedBloodCell>(rbcPrefab);
            float pipeRotation =
                (start + i * direction) *
                360f / bloodVessel.pipeSegmentCount;
            rbc.Position(bloodVessel, i * angleStep, pipeRotation);
        }
    }
}
