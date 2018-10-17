using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Labirynth_generation : MonoBehaviour {

   public GameObject[,] lab ;
    public int visotaLab;
    public int shirinaLab;
    public static bool generiruem = true;
    int kakoiBudetBlok;
    public static bool testRun=false;

    int nomerKomnati=0;

    Vector2 spawnPos;

    public GameObject stenka;
    public GameObject labOne;
    public GameObject labTwo;

	// Use this for initialization
	void Start () {
        nomerKomnati = 0;
	}
	
	// Update is called once per frame
	void Update () {

        if (generiruem)
        {
            lab = new GameObject[visotaLab, shirinaLab];

            for (int i = 0; i < visotaLab; i++)
            {
                for (int j = 0; j < shirinaLab; j++)
                {
                    spawnPos = new Vector2(i,j);
                    kakoiBudetBlok = Mathf.RoundToInt(Random.value);
                    if (i > 0 & j > 0 & i < visotaLab - 1 & j < shirinaLab - 1)
                    {


                       // UslovijaGeneracii();

                    }

                    else
                    {
                        Debug.Log("stenka");
                    }
                }
            }

            generiruem = false;testRun = true;
        }
        
        if (testRun)
        {
            

            for  (int i = 0; i < (visotaLab-2)*(shirinaLab-2); i++)
            {
                Debug.Log("zamena");
            }
            testRun = false;
        }
	}


    void UslovijaGeneracii()
    {
        if (kakoiBudetBlok == 0)
        {
            Debug.Log("234");
            Instantiate(labTwo,spawnPos,transform.rotation);
        }
        if (kakoiBudetBlok == 1)
        {
            Debug.Log("748");
           GameObject labb = Instantiate(labOne, spawnPos, transform.rotation); labb.name = "labber"+nomerKomnati;nomerKomnati++;
        }
    }
}
