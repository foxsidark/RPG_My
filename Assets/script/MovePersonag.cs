using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePersonag : MonoBehaviour {

	// Use this for initialization
	Rigidbody2D rb2d;
	public int speed=10;
	void Start () {
		rb2d = gameObject.GetComponent<Rigidbody2D> ();	
	}
	
	// Update is called once per frame
	void Update () {
		rb2d.velocity =new  Vector2 (0, 0);
		if (Input.GetKey("a")) {
			rb2d.velocity =new  Vector2 (-speed, rb2d.velocity.y);
		}
		if (Input.GetKey ("d")) {
			rb2d.velocity =new Vector2 (speed,  rb2d.velocity.y);
		}
		if (Input.GetKey ("w")) {
			rb2d.velocity =new Vector2 ( rb2d.velocity.x, speed);
		}
		if (Input.GetKey ("s")) {
			rb2d.velocity =new Vector2 ( rb2d.velocity.x, -speed);
		}
	}
}
