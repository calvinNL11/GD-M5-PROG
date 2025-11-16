using UnityEngine;

public class Ratation : MonoBehaviour
{
    public float rotatespeed = 90f;
    public float amplitude = 2.0f;    
    public float frequency = 1.0f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

  
    void Update()
    {
        
        transform.Rotate(0, rotatespeed * Time.deltaTime, 0);

        float newY = startPosition.y + amplitude * Mathf.Sin(Time.time * frequency);
        transform.position = new Vector3(startPosition.x, newY, startPosition.z);
    }
}
