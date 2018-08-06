using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParamCaracter : MonoBehaviour {

	// Use this for initialization
	public float MaxHp;
	public float Hp;
	public float Armor;
	public float Atack;
	public float HpRegen;
	public float SpeedRegenHp;
	public float speed;
	public float SpeedAtack;
    public float SpeedAtackRegen;
    public float speedpatron;
    
    void Awake(){
        MaxHp += NumberLvL.LvL;
        Hp = MaxHp;
        if (gameObject.tag != "Player")
        {
            Atack += NumberLvL.LvL;
        }

    }
    
       
	/*void Start () {
        



    }
	
	// Update is called once per frame
	void Update () {
		
	}*/
}
