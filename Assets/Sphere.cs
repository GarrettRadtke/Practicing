using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -22)
        {
            Respawn();
        }
    }
    private void OnEnable()
    {
        Respawn();
    }

    private void Respawn()
    {
        float randomY = UnityEngine.Random.Range(1, 15);
        float randomX = UnityEngine.Random.Range(-12, 12);

        transform.position = new Vector3(randomX, randomY);

        var rigibbody = GetComponent<Rigidbody>();
    }
}
