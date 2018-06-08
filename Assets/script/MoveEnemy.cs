using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveEnemy : MonoBehaviour {

    // Use this for initialization
    Rigidbody2D rb2D;
    public float speed;
    private int mnog1=1;
    private int mnog2 = 1;

    Random rnd;
    int I = 0;
    void Start () {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
		speed = gameObject.GetComponent<ParamCaracter> ().speed;
    }
	
	// Update is called once per frame
	void Update () {
        int value = Random.Range(1,100);
        if (I > 10)
        {
            if (value > 96 && rb2D.velocity.x > -10)
            {
                //  gameObject.transform.localScale = new Vector3(Mathf.Abs(gameObject.transform.localScale.x) * (-1), gameObject.transform.localScale.y * 1, gameObject.transform.localScale.z * 1);

                rb2D.velocity = (new Vector3(speed, rb2D.velocity.y, 0));
                I = 0;

            }
            else
            {

                //  gameObject.transform.localScale = new Vector3(Mathf.Abs(gameObject.transform.localScale.x) * (-1), gameObject.transform.localScale.y * 1, gameObject.transform.localScale.z * 1);
            }

            if (value < 4 && rb2D.velocity.x < 10)
            {
                //  gameObject.transform.localScale = new Vector3(Mathf.Abs(gameObject.transform.localScale.x), gameObject.transform.localScale.y * 1, gameObject.transform.localScale.z * 1);

                rb2D.velocity = (new Vector3(-speed, rb2D.velocity.y, 0));

                I = 0;
            }
        }

		value = Random.Range(1,100);
		if (I > 10)
		{
			if (value > 96 && rb2D.velocity.x > -10)
			{
				//  gameObject.transform.localScale = new Vector3(Mathf.Abs(gameObject.transform.localScale.x) * (-1), gameObject.transform.localScale.y * 1, gameObject.transform.localScale.z * 1);

				rb2D.velocity = (new Vector3(rb2D.velocity.x, speed, 0));
				I = 0;

			}
			else
			{

				//  gameObject.transform.localScale = new Vector3(Mathf.Abs(gameObject.transform.localScale.x) * (-1), gameObject.transform.localScale.y * 1, gameObject.transform.localScale.z * 1);
			}

			if (value < 4 && rb2D.velocity.x < 10)
			{
				//  gameObject.transform.localScale = new Vector3(Mathf.Abs(gameObject.transform.localScale.x), gameObject.transform.localScale.y * 1, gameObject.transform.localScale.z * 1);

				rb2D.velocity = (new Vector3(rb2D.velocity.x , -speed, 0));

				I = 0;
			}
		}

        I++;

    }
}
