using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 45f;
    void Update()
    {
        transform.Rotate(new Vector3(0, speed, 0) * Time.deltaTime);
    }
}
