using UnityEngine;

public class Opdracht2 : MonoBehaviour
{

    public GameObject cylinder;
    public Transform cylinderPosition;

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(cylinder, cylinderPosition);
        }
    }
}
