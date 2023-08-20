using UnityEngine;

public class DestructibleObject : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("KillCollider"))
        {
            Destroy(gameObject);
        }
    }
}