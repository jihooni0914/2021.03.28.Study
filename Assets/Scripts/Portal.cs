using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public Transform point;

    void OnCollisionEnter(Collision col)
    {
        if (col.transform.CompareTag("Player"))
        {
            col.transform.position = point.position;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
