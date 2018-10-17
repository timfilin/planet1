using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyController : MonoBehaviour {
    private float yVelocity = 0.0F;  Vector3 napravlenie;
    public float smoothTime = 0.1F;

    public Rigidbody player;
    public Rigidbody missile;
    public Transform missilePoint;
    public float shotForce = 100;
    public GameObject explosion;public Transform planeto;
    private Vector3 mouseOrigin;
    public float vstoronu = 0.0f, vverhvniz = 0.0f, rotateSpeed = 10;
    public Transform cam;
    public float tilt;
    void Update () {
		if (Input.GetKey("s"))
        {

            player.AddRelativeTorque(10, 0, 0); transform.RotateAround(transform.position, transform.TransformDirection(Vector3.up), 20 * Time.deltaTime);
        }
         if (Input.GetKey("w"))
        {
            player.AddRelativeTorque(-10, 0, 0); transform.RotateAround(transform.position, transform.TransformDirection(Vector3.down), 20 * Time.deltaTime);

        }
        if (Input.GetKey("a"))
        {
           // player.AddRelativeTorque(0, -7, 0);
            player.AddRelativeForce(0, 0, -15); transform.RotateAround(transform.position, transform.TransformDirection(Vector3.forward), 20 * Time.deltaTime);
        }
         if (Input.GetKey("d"))
        {

            
           // player.AddRelativeTorque(0, 7, 0);
            player.AddRelativeForce(0, 0,15 ); transform.RotateAround(transform.position, transform.TransformDirection(Vector3.back), 20 * Time.deltaTime);
        }
        
        
         if (Input.GetKeyDown("r"))
        {

        }
         if (Input.GetKeyDown("f"))
        {

        }
         if (Input.GetMouseButtonDown(0))
        {
            Rigidbody fireRocket;
            fireRocket = Instantiate(missile, missilePoint.position, Quaternion.identity) as Rigidbody;
            fireRocket.AddForce(missilePoint.forward * 300);
            
            Destroy(explosion, 3);

        }
        

    }


    void FixedUpdate()
    {
        player.AddRelativeForce(0,0,1);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down),100))
        {
            print("ok");
        }
        else { player.transform.Rotate(0, 0, 1); }

    }

    void OnMouseDown()
    {
        player.AddRelativeForce(0, 0, -15); transform.RotateAround(transform.position, transform.TransformDirection(Vector3.forward), 20 * Time.deltaTime);
    }

    
        
    }

