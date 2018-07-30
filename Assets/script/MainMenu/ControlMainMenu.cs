using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ControlMainMenu : MonoBehaviour {

    // Use this for initialization
 
    //public GameObject N;
	void Start () {
		
	}
	
	// Update is called once per frame
	
   public void OnClick()
    {
       // N.SetActive(true);
        SceneManager.LoadScene("ScenaMap");
    }
    public void SaveName()
    {

        
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
