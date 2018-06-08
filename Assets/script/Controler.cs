using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controler : MonoBehaviour {

    // Use this for initialization
    public GameObject Text;
	public Camera camera;
	public GameObject Control;
	public GameObject Player;
	Vector2 Beg;
	Vector2 temp;
	Rigidbody2D rb2d;
	public float speed;
	public float speedPatron;
	public GameObject[] Weapon=new GameObject[0];
	public GameObject[] WeaponPos=new GameObject[0];

	string[] Atack = { "Up", "Right", "Down", "Left" };


	public float speedAtack = 100;
	void Start () {
		//camera = gameObject.GetComponent<Camera> ();	

		speedAtack = gameObject.GetComponent<ParamCaracter> ().SpeedAtack;
		speed = gameObject.GetComponent<ParamCaracter> ().speed;
		speedPatron = gameObject.GetComponent<ParamCaracter> ().speedpatron;
		Beg = Control.transform.position;
		rb2d = Player.GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	int I=0;
	void Update () {
		I++;
        
        for (int ii = 0; ii < Input.touchCount; ii++) {
			RaycastHit2D hit;
			Vector3 P = camera.ScreenToWorldPoint (Input.touches[ii].position);
			Vector2 P2d = new Vector2 (P.x, P.y);
			hit = Physics2D.Raycast (P2d, P2d);
			if (hit) {
//			Debug.Log (hit.collider.gameObject.name);
				if (hit.collider.gameObject.tag == "ControlMove") {
				
				
					Control.transform.position = P2d;
				} else {
					//Control.transform.localPosition = new Vector2();
				}
                

                //	Debug.Log (hit.collider.gameObject.name);
                if (I > speedAtack) {
					for (int i = 0; i < Weapon.Length; i++) {
						if (hit.collider.gameObject.name == Atack [i]) {
                           
                            GameObject G = Instantiate (Weapon [i]);
                            G.GetComponent<ParamBullet>().Atack  = gameObject.GetComponent<ParamCaracter>().Atack;
							G.transform.position = WeaponPos [i].transform.position;
							Rigidbody2D rb2 = G.GetComponent <Rigidbody2D> ();
							rb2.velocity =
						new Vector2 (hit.collider.gameObject.transform.localPosition.x * speedPatron,
								hit.collider.gameObject.transform.localPosition.y * speedPatron);
							I = 0;
							

						}
					}
				}
			}
		}

	//	Debug.Log (Control.transform.localPosition.x);
		rb2d.velocity=new Vector2 ((Control.transform.localPosition.x)*speed, (Control.transform.localPosition.y )*speed);
	
	}
}
