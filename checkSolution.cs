using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkSolution : MonoBehaviour {

    public Vector3 targetLength;

    void Start () {

    }

    void Update() {
        for (int i = 3; i <= 6; i++) {
            if (i == 3) {
                if (!verifyDistance("Cube1")) {
                    break;
                }
            }

            if (!verifyDistance("Cube" + i)) {
                break;
            }
            else if (i == 6) {
                GameObject.Find("winText").SetActive(true);
            }
        }
    }

    bool verifyDistance(string obj) {
        Vector3 a = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
        Vector3 b = new Vector3(GameObject.Find(obj).transform.position.x, GameObject.Find(obj).transform.position.y, GameObject.Find(obj).transform.position.z);
        float distanceToTarget = Vector3.Distance(a, b) * 100;
        print(obj + ": " + distanceToTarget);

        if (distanceToTarget <= 19 && distanceToTarget >= 12)
            return true;

        return false;
    }
}
