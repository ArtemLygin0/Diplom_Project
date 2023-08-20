using UnityEngine;

public class Visibility : MonoBehaviour
{
    [SerializeField] private BoxCollider box;
    
    private void OnTriggerEnter(Collider other)
    {
        if (box.gameObject.activeSelf == true)
            box.gameObject.SetActive(false);
        else
            box.gameObject.SetActive(true);
    }
}
