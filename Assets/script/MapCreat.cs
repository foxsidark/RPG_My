using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCreat : MonoBehaviour {
	private const int N = 1000;
	// Use this for initialization
	public GameObject []BegObj=new GameObject[5];
	public GameObject [] Wall=new GameObject[10];
	class PairMy{
		public int F;
		public int S;
	}
	List<PairMy> Sp=new List<PairMy>();
	public int MapcountFloor=100;
	private GameObject [][] Pole=new GameObject[N][];

	Vector3 PBeg = new Vector3 (0.3f * N, 0.3f * N);

	void Start () {
		for (int i = 0; i < N; i++) {
			Pole [i] = new GameObject[N];
		}


		Pole [N / 2] [N / 2] = BegObj[0];
		Pole [N / 2+1] [N / 2] = BegObj[1];
		Pole [N / 2] [N / 2+1] = BegObj[2];
		Pole [N / 2-1] [N / 2] = BegObj[3];
		Pole [N / 2] [N / 2-1] = BegObj[4];
		PairMy M1=new PairMy();
		M1.F =N/2;
		M1.S = N/2;
		Sp.Add (M1);
		M1.F =N/2+1;
		M1.S = N/2;
		Sp.Add (M1);
		M1.F =N/2-1;
		M1.S = N/2;
		Sp.Add (M1);
		M1.F =N/2;
		M1.S = N/2+1;

		Sp.Add (M1);
		M1.F =N/2;
		M1.S = N/2-1;
		Sp.Add (M1);
		for (int i = 0; i < MapcountFloor; i++) {
			PairMy M=new PairMy();
			if (Downcreatefloor ()) {
				M.F =N/2-1+ Iup1;
				M.S = N/2+Jup1;
				Sp.Add (M);

			}
		/*if (Upcreatefloor ()) {
				M.F = N/2+1+Iup;
				M.S = N/2+Jup;
				Sp.Add (M);
				Debug.Log (M.F + " " + M.S);
			}
			 if (Rightcreatefloor ()) {
				M.F =N/2+ Iup2;
				M.S =N/2+1+ Jup2;
				Sp.Add (M);
				Debug.Log (M.F + " " + M.S);
			}
				if (Leftcreatefloor ()) {
				M.F =N/2+ Iup3;
				M.S = N/2-1+Jup3;
				Sp.Add (M);
				Debug.Log (M.F + " " + M.S);
			}*/
		}


		for (int i = 0; i < Sp.Count; i++) {
			int F = Sp [i].F;
			int S = Sp [i].S;
			if (F-1>=0 && Pole [F-1] [S]==null  ) {
				GameObject GG= Instantiate (Wall [0]);
				Vector3 P = Pole [F] [S].transform.position;
				P.y += 0.3f;
				GG.transform.position = P;
				Pole [F - 1] [S] = GG;
			}


			if (F+1<N && Pole [F+1] [S]==null  ) {
				GameObject GG= Instantiate (Wall [0]);
				Vector3 P = Pole [F] [S].transform.position;
				P.y -= 0.3f;
				GG.transform.position = P;
				Pole [F + 1] [S] = GG;
			}
		}
	
		
		
	}
	private int Iup = 0;
	private int Jup = 0;

	bool Upcreatefloor(){
		 {
			int Ran = Random.Range(0,6);
			if ((N / 2 + 1 + Iup + 1) < N
				&& (Ran == 1||Ran == 5)
				&& Pole [N / 2 + 1 + Iup + 1] [N / 2+Jup] == null) {
				GameObject G = Pole [N / 2 + 1 + Iup] [N / 2+Jup];
				Iup++;
				Pole [N / 2 + 1 + Iup] [N / 2+Jup] = Instantiate (G);
				Vector3 P = Pole [N / 2 + 1 + Iup] [N / 2+Jup].transform.position;
				P.y -= 0.3f;
				Pole [N / 2 + 1 + Iup] [N / 2+Jup].transform.position = P;
				return true;
			}

			if ((N / 2 + Iup) > 0
				&& Ran == 2
				&& Pole [N / 2 +  Iup ] [N / 2+Jup] == null) {
				GameObject G = Pole [N / 2  + Iup+1] [N / 2+Jup];
				Iup--;
				Pole [N / 2 + 1 + Iup] [N / 2+Jup] = Instantiate (G);
				Vector3 P = Pole [N / 2 + 1 + Iup] [N / 2+Jup].transform.position;
				P.y += 0.3f;
				Pole [N / 2 + 1 + Iup] [N / 2+Jup].transform.position = P;
				return true;
			}

			if ((N / 2 + 1 + Jup ) < N
				&& Ran == 3
				&& Pole [N / 2+1+Iup  ] [N / 2+ 1 + Jup] == null) {
				GameObject G = Pole [N / 2+1+Iup ] [N / 2 + Jup];
				Jup++;
				Pole [N / 2 +1+Iup ] [N / 2 + Jup] = Instantiate (G);
				Vector3 P = Pole [N / 2+1+Iup  ] [N / 2 + Jup].transform.position;
				P.x += 0.3f;
				Pole [N / 2 +1+Iup  ] [N / 2+ Jup].transform.position = P;

				return true;
			}
			if ((N / 2 + Jup ) > 0
				&& Ran == 4
				&& Pole [N / 2+1+Iup  ] [N / 2+  Jup-1] == null) {
				GameObject G = Pole [N / 2+1+Iup ] [N / 2 + Jup];
				Jup--;
				Pole [N / 2 +1+Iup ] [N / 2 + Jup] = Instantiate (G);
				Vector3 P = Pole [N / 2+1+Iup  ] [N / 2 + Jup].transform.position;
				P.x -= 0.3f;
				Pole [N / 2 +1+Iup  ] [N / 2+ Jup].transform.position = P;

				return true;
			}



			return false;
		}
		
	}

	private int Iup1 = 0;
	private int Jup1 = 0;
	bool Downcreatefloor(){
		{
			 
				int Ran = Random.Range (0, 6);
				if ((N / 2 + Iup1 - 2) > 0
				&& (Ran == 2||Ran == 5)
				   && Pole [N / 2 + Iup1 - 2] [N / 2 + Jup1] == null) {
					GameObject G = Pole [N / 2 + Iup1 - 1] [N / 2 + Jup1];
					Iup1--;
					Pole [N / 2 + Iup1 - 1] [N / 2 + Jup1] = Instantiate (G);
					Vector3 P = Pole [N / 2 + Iup1 - 1] [N / 2 + Jup1].transform.position;
					P.y += 0.3f;
					Pole [N / 2 + Iup1 - 1] [N / 2 + Jup1].transform.position = P;
				return true;
				}
				if ((N / 2 - 1 + Iup1) < N
				   && Ran == 1
				   && Pole [N / 2 - 1 + Iup1] [N / 2 + Jup] == null) {
					GameObject G = Pole [N / 2 - 1 + Iup1] [N / 2 + Jup1];
					Iup1++;
					Pole [N / 2 - 1 + Iup1] [N / 2 + Jup1] = Instantiate (G);
					Vector3 P = Pole [N / 2 - 1 + Iup1] [N / 2 + Jup1].transform.position;
					P.y -= 0.3f;
					Pole [N / 2 - 1 + Iup1] [N / 2 + Jup1].transform.position = P;
				return true;
				}

		

				if ((N / 2 + Jup1) < N
				   && Ran == 3
				   && Pole [N / 2 - 1 + Iup1] [N / 2 + 1 + Jup1] == null) {
					GameObject G = Pole [N / 2 - 1 + Iup1] [N / 2 + Jup1];
					Jup1++;
					Pole [N / 2 - 1 + Iup1] [N / 2 + Jup1] = Instantiate (G);
					Vector3 P = Pole [N / 2 - 1 + Iup1] [N / 2 + Jup1].transform.position;
					P.x += 0.3f;
					Pole [N / 2 - 1 + Iup1] [N / 2 + Jup1].transform.position = P;

				return true;
				}
				if ((N / 2 + Jup1) > 0
				   && Ran == 4
				   && Pole [N / 2 - 1 + Iup1] [N / 2 + Jup1 - 1] == null) {
					GameObject G = Pole [N / 2 - 1 + Iup1] [N / 2 + Jup1];
					Jup1--;
					Pole [N / 2 - 1 + Iup1] [N / 2 + Jup1] = Instantiate (G);
					Vector3 P = Pole [N / 2 - 1 + Iup1] [N / 2 + Jup1].transform.position;
					P.x -= 0.3f;
					Pole [N / 2 - 1 + Iup1] [N / 2 + Jup1].transform.position = P;

				return true;
				}

			return false;
		}
			
	}

	private int Iup2 = 0;
	private int Jup2 = 0;
	bool Rightcreatefloor(){
		{

			int Ran = Random.Range (0, 6);
			if ((N / 2 + Iup2 - 1) > 0
			    && Ran == 2
			    && Pole [N / 2 + Iup2 - 1] [N / 2 + Jup2 + 1] == null) {
				GameObject G = Pole [N / 2 + Iup2 ] [N / 2 + Jup2+1];
				Iup2--;
				Pole [N / 2 + Iup2 ] [N / 2 + Jup2+1] = Instantiate (G);
				Vector3 P = Pole [N / 2 + Iup2 ] [N / 2 + Jup2+1].transform.position;
				P.y += 0.3f;
				Pole [N / 2 + Iup2 ] [N / 2 + Jup2+1].transform.position = P;
				return true;
			}

			if ((N / 2 + Iup2 + 1) < N
				&& Ran == 1
				&& Pole [N / 2 + Iup2 + 1] [N / 2 + Jup2 + 1] == null) {
				GameObject G = Pole [N / 2 + Iup2 ] [N / 2 + Jup2+1];
				Iup2++;
				Pole [N / 2 + Iup2 ] [N / 2 + Jup2+1] = Instantiate (G);
				Vector3 P = Pole [N / 2 + Iup2 ] [N / 2 + Jup2+1].transform.position;
				P.y -= 0.3f;
				Pole [N / 2 + Iup2 ] [N / 2 + Jup2+1].transform.position = P;
				return true;
			}


			if ((N / 2 + Jup2 + 1+1) < N
				&& (Ran == 3||Ran == 5)
				&& Pole [N / 2 + Iup2] [N / 2 + Jup2 + 1+1] == null) {
				GameObject G = Pole [N / 2 + Iup2 ] [N / 2 + Jup2+1];
				Jup2++;
				Pole [N / 2 + Iup2 ] [N / 2 + Jup2+1] = Instantiate (G);
				Vector3 P = Pole [N / 2 + Iup2 ] [N / 2 + Jup2+1].transform.position;
				P.x += 0.3f;
				Pole [N / 2 + Iup2 ] [N / 2 + Jup2+1].transform.position = P;
				return true;
			}

			if ((N / 2 + Jup2 ) >0
				&& Ran == 4
				&& Pole [N / 2 + Iup2] [N / 2 + Jup2 ] == null) {
				GameObject G = Pole [N / 2 + Iup2 ] [N / 2 + Jup2+1];
				Jup2--;
				Pole [N / 2 + Iup2 ] [N / 2 + Jup2+1] = Instantiate (G);
				Vector3 P = Pole [N / 2 + Iup2 ] [N / 2 + Jup2+1].transform.position;
				P.x -= 0.3f;
				Pole [N / 2 + Iup2 ] [N / 2 + Jup2+1].transform.position = P;
				return true;
			}
			return false;
		}
	}


	private int Iup3 = 0;
	private int Jup3 = 0;
	bool Leftcreatefloor(){
		{

			int Ran = Random.Range (0, 6);
			if ((N / 2 + Iup3 - 1) > 0
				&& Ran == 2
				&& Pole [N / 2 + Iup3 - 1] [N / 2 + Jup3 - 1] == null) {
				GameObject G = Pole [N / 2 + Iup3 ] [N / 2 + Jup3-1];
				Iup3--;
				Pole [N / 2 + Iup3 ] [N / 2 + Jup3-1] = Instantiate (G);
				Vector3 P = Pole [N / 2 + Iup3 ] [N / 2 + Jup3-1].transform.position;
				P.y += 0.3f;
				Pole [N / 2 + Iup3 ] [N / 2 + Jup3-1].transform.position = P;
				return true;
			}

			if ((N / 2 + Iup3 + 1) < N
				&& Ran == 1
				&& Pole [N / 2 + Iup3 + 1] [N / 2 + Jup3 - 1] == null) {
				GameObject G = Pole [N / 2 + Iup3 ] [N / 2 + Jup3-1];
				Iup3++;
				Pole [N / 2 + Iup3 ] [N / 2 + Jup3-1] = Instantiate (G);
				Vector3 P = Pole [N / 2 + Iup3 ] [N / 2 + Jup3-1].transform.position;
				P.y -= 0.3f;
				Pole [N / 2 + Iup3 ] [N / 2 + Jup3-1].transform.position = P;
				return true;
			}


			if ((N / 2 + Jup3 ) < N
				&& Ran == 3
				&& Pole [N / 2 + Iup3] [N / 2 + Jup3 ] == null) {
				GameObject G = Pole [N / 2 + Iup3 ] [N / 2 + Jup3-1];
				Jup3++;
				Pole [N / 2 + Iup3 ] [N / 2 + Jup3-1] = Instantiate (G);
				Vector3 P = Pole [N / 2 + Iup3 ] [N / 2 + Jup3-1].transform.position;
				P.x += 0.3f;
				Pole [N / 2 + Iup3 ] [N / 2 + Jup3-1].transform.position = P;
				return true;
			}

			if ((N / 2 + Jup3-2 ) >0
				&& (Ran == 4||Ran == 5)
				&& Pole [N / 2 + Iup3] [N / 2 + Jup3-2 ] == null) {
				GameObject G = Pole [N / 2 + Iup3 ] [N / 2 + Jup3-1];
				Jup3--;
				Pole [N / 2 + Iup3 ] [N / 2 + Jup3-1] = Instantiate (G);
				Vector3 P = Pole [N / 2 + Iup3 ] [N / 2 + Jup3-1].transform.position;
				P.x -= 0.3f;
				Pole [N / 2 + Iup3 ] [N / 2 + Jup3-1].transform.position = P;
				return true;
			}
			return false;
		}
	}

	 






		

}
