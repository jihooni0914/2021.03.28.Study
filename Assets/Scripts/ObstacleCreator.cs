using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreator : MonoBehaviour
{
    public GameObject obstacle;
    public int obstacle_count = 10;

    void OnTriggerEnter(Collider col)
    {
        if (col.transform.CompareTag("Player"))
        {
            for (int i = 0; i < obstacle_count; i++ )
            {
                Instantiate(obstacle,
                    new Vector3(Random.Range(-9, 9), 10, Random.Range(-8, -27)),
                    Quaternion.Euler(Random.Range(0, 180), Random.Range(0, 360), Random.Range(0, 180)));
            }
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
