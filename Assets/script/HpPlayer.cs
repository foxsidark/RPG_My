using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpPlayer : MonoBehaviour {

    // Use this for initialization
   // public GameObject P;
    float MaxHp;
    float Hp;
    float HpReg;
    float SpeedRegenHp;
    float Armor;
    void Start()
    {

        MaxHp = gameObject.GetComponent<ParamCaracter>().MaxHp;
        Hp = gameObject.GetComponent<ParamCaracter>().Hp;
        HpReg = gameObject.GetComponent<ParamCaracter>().HpRegen;
        SpeedRegenHp = gameObject.GetComponent<ParamCaracter>().SpeedRegenHp;
        Armor= gameObject.GetComponent<ParamCaracter>().Armor;
    }

    // Update is called once per frame
  
    int I = 0;
    void Update()
    {
        I++;
      
        if (I > SpeedRegenHp)
        {
            I = 0;
            Hp += HpReg;
            gameObject.GetComponent<ParamCaracter>().Hp = Hp;
        }
        if (Hp > MaxHp)
        {
            Hp = MaxHp;
            gameObject.GetComponent<ParamCaracter>().Hp = Hp;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log (col.gameObject.tag);
        if (col.gameObject.tag == "EnemyBullet")
        {
            
            I = 0;
            int At = col.gameObject.GetComponent<ParamBullet>().Atack;
            Hp -= At - At*(Armor/(Armor+100));
            gameObject.GetComponent<ParamCaracter>().Hp= Hp;

        }
        if (Hp <= 0)
            Destroy(gameObject);

    }
}
