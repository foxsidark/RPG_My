using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharFollow : MonoBehaviour {

    // Use this for initialization
    private GameObject Player;
	void Start () {
        Player = GameObject.FindWithTag("Player");
        gameObject.transform.position = Player.transform.position;

    }
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.position = Player.transform.position;


    }
}
