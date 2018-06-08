using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWall : MonoBehaviour {

    // Use this for initialization
    public GameObject Wall;
    public int countWall;
    public GameObject floor;
	void Start () {
        for (int i = 0; i < countWall; i++)
        {
           
                GameObject f = floor;
                for (int j = 0; j < countWall; i++)
                {
                    GameObject G = Instantiate(floor);
                    Vector3 P1 = G.transform.position;
                    P1.x += 0.3f;
                    G.transform.position = P1;
                    floor = G;
                }
            floor = f;
            Vector3 P = floor.transform.position;
            P.y -= 0.3f;
            floor.transform.position = P;




        } 
        GameObject W = Wall;
        for (int i=0;i< countWall; i++)
        {
            GameObject G = Instantiate(Wall);
            Vector3 P = G.transform.position;
            P.x += 0.3f;
            G.transform.position = P;
            Wall = G;
        }
        Wall = W;
        for (int i = 0; i < countWall; i++)
        {
            GameObject G = Instantiate(Wall);
            Vector3 P = G.transform.position;
            P.y -= 0.3f;
            G.transform.position = P;
            Wall = G;
        }
        
        for (int i = 0; i < countWall; i++)
        {
            GameObject G = Instantiate(Wall);
            Vector3 P = G.transform.position;
            P.x += 0.3f;
            G.transform.position = P;
            Wall = G;
        }
        for (int i = 0; i < countWall; i++)
        {
            GameObject G = Instantiate(Wall);
            Vector3 P = G.transform.position;
            P.y += 0.3f;
            G.transform.position = P;
            Wall = G;
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
