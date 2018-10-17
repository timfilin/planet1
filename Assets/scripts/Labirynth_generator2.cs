using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Labirynth_generator2 : MonoBehaviour {

   public GameObject[,] lab ;
    public int visotaLab;
    public int shirinaLab;
    public static bool generiruem = true;
    int kakoiBudetBlok;
    public static bool testRun=false;

    int nomerKomnati=0;

    Vector3 spawnPos;

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
                    spawnPos = new Vector3(i,-0.1f,j);
                  //  kakoiBudetBlok = Mathf.RoundToInt(Random.value);
                    if (i > 0 & j > 0 & i < visotaLab - 1 & j < shirinaLab - 1)
                    {

                        lab[i, j] = Instantiate(labOne,spawnPos,transform.rotation);
                           // UslovijaGeneracii();

                    }

                    else
                    {
                        Debug.Log("stenka");
                    }
                }
            }

            for (int i = 0; i < visotaLab+1; i++)
            {
                for (int j = 0; j < shirinaLab+1; j++)
                {
                    spawnPos = new Vector3(i, -1, j);
                    //  kakoiBudetBlok = Mathf.RoundToInt(Random.value);
                    if (i > 0 & j > 0 & i < visotaLab - 1 & j < shirinaLab - 1)
                    {

                         Instantiate(labTwo, spawnPos, transform.rotation);
                        // UslovijaGeneracii();

                    }

                    else
                    {
                        Debug.Log("stenka");
                    }
                }
            }

            generiruem = false;testRun = true;
            Destroy(lab[2, 1]); Destroy(lab[2, 2]);
        }
        
        if (testRun)
        {


            for (int i = 0; i < visotaLab; i++)
            {
                for (int j = 0; j < shirinaLab; j++)
                {
                    
                    kakoiBudetBlok = Mathf.RoundToInt(Random.value);
                    if (i > 1 & j > 1 & i < visotaLab - 1 & j < shirinaLab - 1)
                    {

                        if (lab[i, j].gameObject.tag == "first" && i % 2==0 && j%2==0)
                        {
                            Destroy(lab[i, j]);
                        }

                        if (lab[i, j].gameObject.tag == "first" && i % 2 == 0 && j % 2 != 0 && kakoiBudetBlok==0)
                        {
                            Destroy(lab[i, j]); Destroy(lab[i, j+1]);
                            if(j+2<=visotaLab-1)
                            Destroy(lab[i, j + 2]);
                        }
                        if (lab[i, j].gameObject.tag == "first" && i % 2 !=0 && j % 2 == 0 && kakoiBudetBlok == 0)
                        {
                            Destroy(lab[i, j]); Destroy(lab[i+1, j]);
                            if (i+2<=shirinaLab-1)
                            Destroy(lab[i + 2, j]);
                        }
                    }

                    
                }
            }
            testRun = false;
        }
	}


   
}
