using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement2 : MonoBehaviour
{
    private int iznos_sile = 1000;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.forward * iznos_sile);
        
    }
}
