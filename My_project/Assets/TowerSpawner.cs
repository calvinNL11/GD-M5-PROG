using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    [SerializeField] private GameObject towerPrefab;



    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject tower = Instantiate(towerPrefab); 
            tower.transform.position = RandomPostion(-10f, 10f);
                
        }
    }
    private Vector3 RandomPostion(float min, float max)
    {
        float x = Random.Range(min, max);
        float y = Random.Range(min, max);
        float z = Random.Range(min, max);
        Vector3 pos = new Vector3(x, y, z);
        return pos;
    }
}