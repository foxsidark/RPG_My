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
   
    
	void Update () {
        

        
        float XY = Mathf.Sqrt(Control.transform.localPosition.y* Control.transform.localPosition.y+ Control.transform.localPosition.x* Control.transform.localPosition.x);
        float X = 0;
        float Y = 0;
        if (XY != 0) X = Control.transform.localPosition.x / XY;
        if (XY != 0) Y = Control.transform.localPosition.y / XY;

        rb2d.velocity = new Vector2( X*speed, Y * speed);

    }
}
