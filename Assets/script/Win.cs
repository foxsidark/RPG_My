using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Win : MonoBehaviour {

    // Use this for initialization
    void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log (col.gameObject.tag);
        if (col.gameObject.name == "Caracters")
        {
            NumberLvL.LvL++;
            SceneManager.LoadScene("ScenaMap");
        }
    }
}
