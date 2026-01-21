using UnityEngine;
using System;

public abstract class Collectable : MonoBehaviour
{
    public static event Action<Collectable> OnCollected;

    public abstract void OnCollect(GameObject collector);

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        Debug.Log("Trigger hit: " + gameObject.name);

        OnCollect(other.gameObject);

        OnCollected?.Invoke(this);

        Destroy(gameObject);
    }
}
