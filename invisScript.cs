using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invisScript : MonoBehaviour {

	void Start () {
        GameObject.Find(this.name).transform.localScale = new Vector3(0, 0, 0);
    }

    void Update () {
		
	}
}
