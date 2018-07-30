using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountPatronScript : MonoBehaviour {

    // Use this for initialization
    public Text text1;
    float speedAtackPlayerMax;
    float SpeedAtackRegen;
    public static float speedAtackPlayer;
    float stopregen = 10000;

	void Start () {
        SpeedAtackRegen = gameObject.GetComponent<ParamCaracter>().SpeedAtackRegen;
        speedAtackPlayer =gameObject.GetComponent<ParamCaracter>().SpeedAtack;
        speedAtackPlayerMax= speedAtackPlayer;
        text1.text = speedAtackPlayer+"";
    }

    // Update is called once per frame
    float I = 0;
	void FixedUpdate () {
        if (speedAtackPlayerMax> speedAtackPlayer)
        {

            if (I > stopregen && speedAtackPlayer>=1  || I > stopregen*10)
            {
                I = 0;
                speedAtackPlayer++;
                text1.text = speedAtackPlayer + "";
            }
            I += SpeedAtackRegen;
        }    
    }

    public void FireDown()
    {
        if (speedAtackPlayer >= 1)
        {
            I = 0;
            speedAtackPlayer--;
            text1.text = speedAtackPlayer + "";
        }
    }
}
