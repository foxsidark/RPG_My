using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Record : MonoBehaviour
{

    // Use this for initialization
 public static void SetNewRecord()
    {
        
        int Temp = NumberLvL.LvL;
        string TempName = PlayerPrefs.GetString("Player");
        for (int i = 0; i < 10; i++)
        {
            int temp = PlayerPrefs.GetInt(i + "Record");
            string tempName = PlayerPrefs.GetString(i + "RecordName");
            if (Temp > temp)
            {
                PlayerPrefs.SetInt(i + "Record",Temp);
                PlayerPrefs.SetString(i + "RecordName", TempName);
                Temp = temp;
                TempName = tempName;
            }

        }
    }
  public void OutRecord(GameObject G)
  {
        G.GetComponent<Text>().text = "";
        for (int i = 0; i < 10; i++)
        {
            string temp = PlayerPrefs.GetString(i + "RecordName");
            if (temp == "")
            {
                temp = "Name";
            }
            G.GetComponent<Text>().text += temp + " " + PlayerPrefs.GetInt(i + "Record")+"\n"; 

        }
  }
}

