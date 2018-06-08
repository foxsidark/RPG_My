using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAny : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter2D(Collision2D col){
		Destroy (gameObject);

	}
}
