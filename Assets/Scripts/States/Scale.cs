using UnityEngine;

public class Scale : MonoBehaviour
{
    public float speed = 0.5f;
    void Update()
    {
        transform.localScale += (new Vector3(0, speed, 0) * Time.deltaTime);
    }
}
