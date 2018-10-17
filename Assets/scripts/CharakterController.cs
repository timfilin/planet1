using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharakterController : MonoBehaviour {

    public float moveSpeed = 15;
    public Vector3 moveDir;
    public Rigidbody rb;

    public bool left;
    public bool right;

    float first = 0;
    float second = 0;
    float third = 0;

    void Update()
    {
       moveDir = new Vector3(first,second,third).normalized;

        if (left)
        {

        }
        if (right)
        {

        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + transform.TransformDirection(moveDir * moveSpeed * Time.deltaTime));
    }

    public void Leftqq()
    {
        rb.AddRelativeTorque(-100, 0, 0); transform.RotateAround(transform.position, transform.TransformDirection(Vector3.down), 20 * Time.deltaTime);
    }
    public void Rightqq()
    {
        rb.AddRelativeTorque(100, 0, 0); transform.RotateAround(transform.position, transform.TransformDirection(Vector3.up), 20 * Time.deltaTime);
    }
    public void Forwardqq()
    {
        third = third - 0.05f;
    }
    public void Backqq()
    {
        third = third + 0.05f;
    }

    void IsPressed(Button left)
    {

    }




    }