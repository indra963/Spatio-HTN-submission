using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smoothMovement : MonoBehaviour {
    public GameObject imageTargetObj;

    // Use this for initialization
    void Start () {
        imageTargetObj = GameObject.Find("ImageTarget1");
    }

    // Update is called once per frame
    void Update () {
        this.transform.rotation = Quaternion.Slerp(imageTargetObj.transform.rotation, this.transform.rotation, 10);
    }
}
