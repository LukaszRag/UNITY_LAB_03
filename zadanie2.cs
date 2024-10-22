using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class zadanie2 : MonoBehaviour
{
    public float speed = 2f; 
    private Vector3 startPosition;
    private bool movingForward = true;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float step = speed * Time.deltaTime; 
        if (movingForward)
        {
            
            transform.position += Vector3.right * step;

            
            if (transform.position.x >= startPosition.x + 10)
            {
                movingForward = false; 
            }
        }
        else
        {
            
            transform.position -= Vector3.right * step;

            
            if (transform.position.x <= startPosition.x)
            {
                movingForward = true; 
            }
        }
    }
}
