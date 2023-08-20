using UnityEngine;

public class FinishPlatform : MonoBehaviour
{
    [SerializeField] private LevelUI _levelUI;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Cursor.lockState = CursorLockMode.Confined;
            _levelUI.LevelComplete();
        }
    }   
}