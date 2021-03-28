using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    public float amount = 5;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            rb.AddForce(Vector3.forward * amount);

        if (Input.GetKey(KeyCode.S))
            rb.AddForce(Vector3.back * amount);

        if (Input.GetKey(KeyCode.A))
            rb.AddForce(Vector3.left * amount);

        if (Input.GetKey(KeyCode.D))
            rb.AddForce(Vector3.right * amount);

    }
}
