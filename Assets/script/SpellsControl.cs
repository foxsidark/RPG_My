using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SpellsControl : MonoBehaviour {

    // Use this for initialization
    //public GameObject Player;
    public GameObject T;
    public Image image;
    public Text text;
    public GameObject First;
    public int timeSpellRestart=10;
    public GameObject Music;
    public AudioClip audioclip;
    int I1 = 10;
    void Start () {
        I1 = timeSpellRestart;

    }

    // Update is called once per frame
    
	void FixedUpdate () {
        if (I1 < timeSpellRestart) {
            image.fillAmount =(float) (timeSpellRestart-I1) / timeSpellRestart;
            text.text = (float)(timeSpellRestart - I1)/100+"";
            I1++;
            if (timeSpellRestart <= I1)
            {
                T.SetActive(false);
                image.fillAmount = 0;
            }

        }
        

    }

    public void FirstSkill()
    {
        if (timeSpellRestart <= I1)
        {
           Music.GetComponent<AudioSource>().PlayOneShot(audioclip);
            I1 = 0;
            T.SetActive(true);
            //First.transform.position = Player.transform.position;
            Instantiate(First);
        }

    }
}
