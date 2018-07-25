using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToInventar : MonoBehaviour {

    public GameObject Camera1;
    public GameObject Camera2;
    // Use this for initialization
    public void ToSwordInventar()
    {
        Camera1.SetActive(true);
        Camera2.SetActive(false);

    }
    public void ToMainMenuCharacter()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(true);

    }
}
