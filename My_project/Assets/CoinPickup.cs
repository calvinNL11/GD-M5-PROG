using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    public int pointValue = 10;
    public string itemName = "Coin";

    void Start()
    {
        
        GetComponent<Collider>().isTrigger = false;
    }

    void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.CompareTag("Player"))
        {
            
            AddPointsToPlayer(pointValue);

            
            Destroy(gameObject);
        }
    }

    
    void AddPointsToPlayer(int points)
    {
        Debug.Log("Player picked up: " + itemName);
        

        if (ScoreManager.Instance != null)
        {
            ScoreManager.Instance.AddPoints(points);
        }
    }

   
  
}
