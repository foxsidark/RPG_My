using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HpText : MonoBehaviour {

    // Use this for initialization

    public GameObject Player;
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<Text>().text = Player.GetComponent<ParamCaracter>().MaxHp + "/"+(int)(Player.GetComponent<ParamCaracter>().Hp * 100) / 100.0 ;


    }
}
