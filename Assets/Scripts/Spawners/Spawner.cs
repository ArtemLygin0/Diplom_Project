using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] public GameObject Sphere;
    public float spawn_time = 1f;
    private float t = 0;
    public int count = 10;
    void Update()
    {
        t += Time.deltaTime;
        if ((t >= spawn_time) && (count > 0))
        {
            GameObject sphere = Instantiate(Sphere, transform.position, Quaternion.identity);
            Destroy(sphere, 11f);
            count--;
            t = 0;
        }
    }
}
