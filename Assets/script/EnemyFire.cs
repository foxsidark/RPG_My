using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour {

	// Use this for initialization
	public GameObject[] WeaponPos=new GameObject[4];
	public GameObject Weapon;
	public float speedPatron;
	public float speedAtack = 100;
	void Start () {
		speedAtack = gameObject.GetComponent<ParamCaracter> ().SpeedAtack;
		speedPatron = gameObject.GetComponent<ParamCaracter> ().speedpatron;
			
	
		
	}
	
	// Update is called once per frame
	int I=0;
	void Update () {
		I++;
	
		if (I > speedAtack) {

			I = 0;
			int Up=0;
			int Right=0;
			int Ran = Random.Range (0, WeaponPos.Length);
            Weapon.transform.position = WeaponPos[Ran].transform.position;
            GameObject G = Instantiate (Weapon );
            G.GetComponent<ParamBullet>().Atack = gameObject.GetComponent<ParamCaracter>().Atack;

            switch (Ran) {
			case 0:
				Up = 1
				;
				
				break;
			case 1:
				Right=1
				;
				break;
			case 2:
				Up = -1;
				break;
			case 3:
				Right = -1;
				break;
			}
			Rigidbody2D rb2 = G.GetComponent <Rigidbody2D> ();
			rb2.velocity =
				new Vector2 (Right * speedPatron,
					Up* speedPatron);
		}

		
	}
}
