using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadanie3 : MonoBehaviour
{
    public float speed = 2f; 
    private Vector3 startPosition;
    private int currentCorner = 0; 
    private Vector3[] corners; 
    private Vector3 targetPosition; 

    void Start()
    {
        startPosition = transform.position;
        corners = new Vector3[4]; 

        
        corners[0] = startPosition + new Vector3(10, 0, 0); 
        corners[1] = corners[0] + new Vector3(0, 0, 10); 
        corners[2] = corners[1] - new Vector3(10, 0, 0); 
        corners[3] = corners[2] - new Vector3(0, 0, 10); 

        targetPosition = corners[currentCorner]; 
    }

    void Update()
    {
        float step = speed * Time.deltaTime; 
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);

       
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            currentCorner = (currentCorner + 1) % corners.Length; 
            targetPosition = corners[currentCorner]; 
            transform.Rotate(0, 90, 0); 
        }
    }
}

