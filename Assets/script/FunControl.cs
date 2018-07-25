using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunControl : MonoBehaviour {

    // Use this for initialization

    public GameObject Pos;
    public GameObject Bullet;
    public int NapravX;
    public int NapravY;

    public void Fire()
    {
        Bullet.transform.position = Pos.transform.position;
        GameObject B = Instantiate(Bullet);

        Rigidbody2D rb2d = B.GetComponent<Rigidbody2D>();
        float speed = GameObject.FindWithTag("Player").GetComponent<ParamCaracter>().speedpatron;

        rb2d.velocity = new Vector2(speed* NapravX,speed* NapravY);
     }
}
