using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCreat_1 : MonoBehaviour {
	const int N=8000;
	private GameObject [][] Pole=new GameObject[N][];
	public int MapCount=4000;
	// Use this for initialization

	public GameObject BegObj;
	public GameObject [] Wall=new GameObject[10];
	public GameObject Win;
	class PairMy{
		public int F;
		public int S;
	}
	int BegI = N / 2;
	int BegJ = N / 2;
	List<PairMy> Sp=new List<PairMy>();
	void Start () {
		for (int i = 0; i < N; i++) {
			Pole[i]=new GameObject[N];
		}
		
		Pole [BegI] [BegJ] = BegObj;
		PairMy IJ = new PairMy ();
		IJ.F = BegI;
		IJ.S = BegJ;
		Sp.Add (IJ);
		for (int i = 0; i <MapCount ; i++) {
			int Ran = Random.Range (1, 5);
			MakeMap (Ran);
			if (Pole [BegI] [BegJ] == null) {
				Pole [BegI] [BegJ] = Instantiate (BegObj);
				Pole [BegI] [BegJ].transform.position = Pos (BegI, BegJ);
				PairMy IJ1 = new PairMy ();
				IJ1.F = BegI;
				IJ1.S = BegJ;
				Sp.Add (IJ1);
			}
		}
		int Krat = 4;
		for (int i = 0; i < Sp.Count; i++) {
			int RanWall = Random.Range (1, 10);
			int F = Sp [i].F;
			int S = Sp [i].S;
			if (F-1>=0 && Pole [F-1] [S]==null  ) {
				GameObject GG= Instantiate (Wall [RanWall%Krat]);


				Pole [F - 1] [S] = GG;
				Pole [F - 1] [S].transform.position = Pos (F - 1, S);
			}

			if (F+1<N && Pole [F+1] [S]==null  ) {
				GameObject GG= Instantiate (Wall [RanWall%Krat]);


				Pole [F +1] [S] = GG;
				Pole [F +1] [S].transform.position = Pos (F + 1, S);
			}
			//----------
			if (S-1>=0 && Pole [F] [S-1]==null  ) {
				GameObject GG= Instantiate (Wall [RanWall%Krat]);


				Pole [F] [S-1] = GG;
				Pole [F] [S-1].transform.position = Pos (F, S-1);
			}

			if (S+1<N && Pole [F] [S+1]==null  ) {
				GameObject GG= Instantiate (Wall [RanWall%Krat]);


				Pole [F] [S+1] = GG;
				Pole [F] [S+1].transform.position = Pos (F, S+1);
			}



		}
		GameObject WG = Instantiate (Win);

		WG.transform.position = Pos (Sp [Sp.Count - 1].F, Sp [Sp.Count - 1].S);
	}
	
	// Update is called once per frame

	void MakeMap(int R){
		if (R == 1) {
			BegI++;
		}
		if (R == 2) {
			BegI--;
		}
		if (R == 3) {
			BegJ++;
		}
		if (R == 4) {
			BegJ--;
		}
		if (BegI >= N) {
			BegI--;
		}
		if (BegI < 0) {
			BegI++;
		}
		if (BegJ >= N) {
			BegJ--;
		}
		if (BegJ < 0) {
			BegJ++;
		}
	}
		
	Vector3 Pos(int i,int j){
		return new Vector3 (i * 0.3f - 0.3f * N / 2, j * 0.3f - 0.3f * N / 2);
	}


	public GameObject[] Enemy=new GameObject[0];
	public int Period=100;
	int I=0;
	void Update () {
		I++;
		if (I > Period) {
			I = 0;
			int Ran = Random.Range (0, Sp.Count);
            int RanEnemy = Random.Range(0,Enemy.Length);
            GameObject E = Instantiate (Enemy [RanEnemy]);
			E.transform.position = Pos (Sp [Ran].F, Sp [Ran].S);
		}
	}
}
