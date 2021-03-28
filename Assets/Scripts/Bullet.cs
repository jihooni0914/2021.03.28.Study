using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log(col.transform.tag);

        if (col.transform.CompareTag("Player"))
        {
            col.transform.position = new Vector3(0, 3, -40);
        }
        if (col.transform.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }
}
