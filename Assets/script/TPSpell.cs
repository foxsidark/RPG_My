using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TPSpell : MonoBehaviour {

    // Use this for initialization
    public GameObject Player;
    public Transform BeginPos;
    public GameObject T;
    public Image image;
    public Text text;
    public GameObject First;
    public int timeSpellRestart = 10;
    public GameObject Music;
    public AudioClip audioclip;
    int I1 = 10;
    void Start()
    {
        I1 = timeSpellRestart;

    }

    // Update is called once per frame

    void FixedUpdate()
    {
        if (I1 < timeSpellRestart)
        {
            image.fillAmount = (float)(timeSpellRestart - I1) / timeSpellRestart;
            text.text = (float)(timeSpellRestart - I1) / 100 + "";
            I1++;
            if (timeSpellRestart <= I1)
            {
                T.SetActive(false);
                image.fillAmount = 0;
            }

        }


    }


    // Update is called once per frame
    public void TpSpel () {
        if (timeSpellRestart <= I1)
        {
            Instantiate(First);
            Music.GetComponent<AudioSource>().PlayOneShot(audioclip);
            I1 = 0;
            T.SetActive(true);
            //First.transform.position = Player.transform.position;
            Player.transform.position = BeginPos.position;
            
        }


    }

}
