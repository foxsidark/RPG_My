using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpBar : MonoBehaviour {

    // Use this for initialization
    public GameObject Hp;
    float MaxHp;
    float Hp1;
	void Start () {

        MaxHp = gameObject.GetComponent<ParamCaracter>().MaxHp;
        Hp1 = gameObject.GetComponent<ParamCaracter>().Hp;
    }
	
	// Update is called once per frame
	void Update ()
    {
        Hp1 = gameObject.GetComponent<ParamCaracter>().Hp;
        Hp.transform.localScale = new Vector3((float)(Hp1) / MaxHp, Hp.transform.localScale.y);


    }
}
