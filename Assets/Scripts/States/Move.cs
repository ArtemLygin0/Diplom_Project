using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 0.5f;
    void Update()
    {
        transform.Translate(new Vector3(0, speed, 0) * Time.deltaTime);
    }
}
