using UnityEngine;

public class DamageTrap : Collectable
{
    public override void OnCollect(GameObject collector)
    {
        Debug.Log("BOOM!!");
      
    }
}
