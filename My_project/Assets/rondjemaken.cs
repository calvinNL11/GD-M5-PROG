using UnityEngine;

public class rondjemaken : MonoBehaviour
{


    public float radius = 2.0f;      
    public float speed = 1.0f;

    private Vector3 startPosition;


    void Start()
    {
        startPosition = transform.position;
    }

   
    void Update()
    {
        float x = startPosition.x + Mathf.Cos(Time.time * speed) * radius;
        float z = startPosition.z + Mathf.Sin(Time.time * speed) * radius;
        transform.position = new Vector3(x, z, startPosition.z);

    }
}
