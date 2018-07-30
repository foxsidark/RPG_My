using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseAndStart : MonoBehaviour {

    // Use this for initialization
    public GameObject Play;
    public GameObject Pause;
    public GameObject ImageBuff;
    public void PauseGame()
    {
        
        Time.timeScale = 0;
        Play.SetActive(true);
        ImageBuff.SetActive(true);
        Pause.SetActive(false);
    }
    public void PlayGame()
    {
        Time.timeScale = 1;
        Play.SetActive(false);
        ImageBuff.SetActive(false);
        Pause.SetActive(true);
    }
}
