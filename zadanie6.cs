using UnityEngine;

public class zad6 : MonoBehaviour
{
    public Transform target;  
    public float smoothTime = 0.3f;  
    public float lerpSpeed = 5f;  

    private Vector3 velocity = Vector3.zero;  

    void Update()
    {
        
        Vector3 targetPosition = target.position;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);

        
        // transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * lerpSpeed);
    }
}
