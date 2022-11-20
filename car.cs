using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    float speed = 0;
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            speed = 0.2f;
        }
        transform.Translate(speed, 0, 0);
        {
            speed *= 0.98f;
        }
    }
}

    
