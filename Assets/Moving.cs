using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
       rb.AddForce(0, 0, 800*Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(500 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-500 * Time.deltaTime, 0, 0);
        }
    }
}
