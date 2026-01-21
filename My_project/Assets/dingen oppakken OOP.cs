using UnityEngine;

public abstract class DingenOppakkenOOP : MonoBehaviour
{
    public int points;
    public string itemName;

    protected virtual void Start()
    {
        GetComponent<Collider>().isTrigger = true;
    }

    protected virtual void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ApplyEffect();
            Destroy(gameObject);
        }
    }

    protected abstract void ApplyEffect();
}

