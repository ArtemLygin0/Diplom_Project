using UnityEngine;

public class InvisibleBlocks : MonoBehaviour
{
    [SerializeField] private DieClass _dieClass;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _dieClass.Die();
        }
    }
}
