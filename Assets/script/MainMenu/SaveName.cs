using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SaveName : MonoBehaviour {

    // Use this for initialization
    public Text text1;
	public void SaveNameFunction()
    {
        PlayerPrefs.SetString("Player", text1.text);
    }
}
