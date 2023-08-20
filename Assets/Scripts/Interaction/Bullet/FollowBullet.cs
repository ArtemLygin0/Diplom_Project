using UnityEngine;

public class FollowBullet : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _player;
    //[SerializeField] private GameObject effectDead;   // Ёффект после смерти

    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _player.position, _speed * Time.deltaTime);     
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        //Instantiate(effectDead, transform.position, Quaternion.identity);
    }
}
