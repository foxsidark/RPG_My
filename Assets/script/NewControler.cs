using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewControler : MonoBehaviour {

    // Use this for initialization
    public Camera camera;
    public GameObject Control;
    Rigidbody2D rb2d;
    private float speed;
   
   
  
    void Start () {
       
        speed = gameObject.GetComponent<ParamCaracter>().speed;
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        Control.transform.localPosition = new Vector3();

    }

    // Update is called once per frame
    
    bool flag = false;
   
    Touch touch;
	void FixedUpdate () {
        

        for (int i = 0; i < Input.touchCount; i++)
        {
          // if (TouchPhase.Began == Input.touches[i].phase)
            {
                RaycastHit2D hit;
                Vector3 P = camera.ScreenToWorldPoint(Input.touches[i].position);
                Vector2 P2d = new Vector2(P.x, P.y);
                hit = Physics2D.Raycast(P2d, P2d);
                if (hit)
                {
                    if (hit.collider.gameObject.tag == "ControlMove")
                    {
                        flag = true;
                        touch = Input.touches[i];

                    }
                }

            }
        }
        if (Input.touchCount>0 && flag && touch.phase == TouchPhase.Ended)
        {
            flag = false;
            Control.transform.localPosition = new Vector3();

        }
        if (flag)
        {
            Vector3 P = camera.ScreenToWorldPoint(touch.position);
            Vector2 P2d = new Vector2(P.x, P.y);
            Control.transform.position = P2d;
        }
        float XY = Mathf.Sqrt(Control.transform.localPosition.y* Control.transform.localPosition.y+ Control.transform.localPosition.x* Control.transform.localPosition.x);
        float X = 0;
        float Y = 0;
        if (XY != 0) X = Control.transform.localPosition.x / XY;
        if (XY != 0) Y = Control.transform.localPosition.y / XY;

        rb2d.velocity = new Vector2( X*speed, Y * speed);

    }
}
