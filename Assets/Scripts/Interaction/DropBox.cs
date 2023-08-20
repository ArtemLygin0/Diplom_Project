using UnityEngine;

public class DropBox : MonoBehaviour
{
    public GameObject item;
    float randomNumber;
    private void OnMouseDown()
    {
        randomNumber = Random.Range(0, 5);
        while (randomNumber >= 0)
        {
            GameObject Item = Instantiate(item, transform.position, Quaternion.identity);
            randomNumber--;
        }
        Destroy(gameObject);
    }
}
