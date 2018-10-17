using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravitation : MonoBehaviour {

    public Transform Planet;
    public Transform house;
    public float gravity = -9.81f;

    void FixedUpdate()
    {

        Vector3 dir = (house.position - Planet.position).normalized;
        Physics.gravity = dir * gravity;

    }
}
