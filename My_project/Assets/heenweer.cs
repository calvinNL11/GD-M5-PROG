using UnityEngine;

public class heenweer : MonoBehaviour
{

    public float amplitude = 2.0f;    // Hoe hoog/laag (afstand tussen heen en weer)
    public float frequency = 1.0f;    // Hoe snel

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    
    void Update()
    {
        float newX = startPosition.x + amplitude * Mathf.Sin(Time.time * frequency);
        transform.position = new Vector3(newX, startPosition.y, startPosition.z);
    }
}
