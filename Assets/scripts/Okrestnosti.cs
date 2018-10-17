using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Okrestnosti : MonoBehaviour {

    public GameObject fir; public GameObject fir1; public GameObject fir2; public GameObject fir3; public GameObject fir4;
    public GameObject planet;
    bool generate = true;
    public Vector3 planetPosition;
    Vector3 radiusOutsidePlanet;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (generate)
        {
            for (int i = 0; i < 20; i++)
            {
                DerevoPlaced();
            }
            
            generate = false;
        }


	}

    void DerevoPlaced()
    {
        radiusOutsidePlanet = Random.onUnitSphere * 35.75f;
       // Vector3 napr = radiusOutsidePlanet - planetPosition;
        GameObject firplaced = Instantiate(fir, radiusOutsidePlanet, transform.rotation);
        firplaced.transform.LookAt(planetPosition);
        firplaced.transform.Rotate(-90, 0, 0);
        firplaced.transform.parent = planet.transform;

        radiusOutsidePlanet = Random.onUnitSphere * 37.75f;
        GameObject firplaced1 = Instantiate(fir1, radiusOutsidePlanet, transform.rotation);
        firplaced1.transform.LookAt(planetPosition);
        firplaced1.transform.Rotate(-90, 0, 0);
        firplaced1.transform.parent = planet.transform;

        radiusOutsidePlanet = Random.onUnitSphere * 37.75f;
        GameObject firplaced2 = Instantiate(fir2, radiusOutsidePlanet, transform.rotation);
        firplaced2.transform.LookAt(planetPosition);
        firplaced2.transform.Rotate(-90, 0, 0);
        firplaced2.transform.parent = planet.transform;

        radiusOutsidePlanet = Random.onUnitSphere * 37.75f;
        GameObject firplaced3 = Instantiate(fir3, radiusOutsidePlanet, transform.rotation);
        firplaced3.transform.LookAt(planetPosition);
        firplaced3.transform.Rotate(-90, 0, 0);
        firplaced3.transform.parent = planet.transform;

        radiusOutsidePlanet = Random.onUnitSphere * 37.75f;
        GameObject firplaced4 = Instantiate(fir4, radiusOutsidePlanet, transform.rotation);
        firplaced4.transform.LookAt(planetPosition);
        firplaced4.transform.Rotate(-90, 0, 0);
        firplaced4.transform.parent = planet.transform;
    }
}
