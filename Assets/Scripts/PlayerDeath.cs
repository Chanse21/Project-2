using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hazard")) // Replace "Hazard" with the tag of the collision object
        {
            Destroy(gameObject);
        }
    }
}
