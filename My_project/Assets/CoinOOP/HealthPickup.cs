using UnityEngine;

public class HealthPickup : Collectable
{
    public override void OnCollect(GameObject collector)
    {
        Debug.Log("Health restored!");
        
    }
}
