using UnityEngine;

public class BulletMove : MonoBehaviour
{
    [SerializeField] private float x;
    [SerializeField] private float y;
    [SerializeField] private float z;

    //private bool stop = false;

    void FixedUpdate()
    {
    //    if (!stop)
            transform.Translate(new Vector3(x, y, z) * Time.deltaTime);
    }
    /*
    void StopWall()
    {
        if (gameObject.tag == "Ground")
        {
            stop = false;
        }
    }
    */
    private void OnCollisionEnter(Collision collision)
    {
        //StopWall();
        //stop = true;
        //if(gameObject.tag != "Ground")

        Destroy(gameObject);
    }
}