using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Gem"))
        {
            Debug.Log("Gem collected");
            Destroy(other.gameObject);
        }
    }
}
