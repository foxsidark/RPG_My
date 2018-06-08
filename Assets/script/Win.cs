using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour {

    // Use this for initialization
    void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log (col.gameObject.tag);
        if (col.gameObject.name == "Caracters")
            Application.LoadLevel(0);
    }
}
