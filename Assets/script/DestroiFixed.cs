using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroiFixed : MonoBehaviour {

    // Use this for initialization
    public float timeDestr;
	void Start () {
        Destroy(gameObject, timeDestr);

    }
	
	// Update is called once per frame
	
}
