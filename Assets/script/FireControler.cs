using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireControler : MonoBehaviour {

    // Use this for initialization
    public Camera camera;
    
    public GameObject Weapon;
    public GameObject Aud;
    private float SpeedAtack=0;
    void Start () {

        SpeedAtack = gameObject.GetComponent<ParamCaracter>().SpeedAtack;

        
    }

    // Update is called once per frame
   
    bool flag = false;
    int II = -1;


    void Update()
    {
       

        for (int i = 0; i < Input.touchCount; i++)
        {
            if (TouchPhase.Began == Input.touches[i].phase)
            {
                RaycastHit2D hit;
                Vector3 P = camera.ScreenToWorldPoint(Input.touches[i].position);
                Vector2 P2d = new Vector2(P.x, P.y);
                hit = Physics2D.Raycast(P2d, P2d);
                Weapon.transform.position = P;
               // Instantiate(Weapon);
                if (hit)
                {
                    if (hit.collider.gameObject.tag == "ControlFire")
                    {

                        hit.collider.gameObject.GetComponent<FunControl>().Fire();
                        Destroy(Instantiate(Aud), 4f);


                    }
                }
            }

            
        }
       
    }
}
