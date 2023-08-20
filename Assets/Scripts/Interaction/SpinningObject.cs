using UnityEngine;

public class SpinningObject : MonoBehaviour
{
    [SerializeField] private DieClass _dieClass;
    [SerializeField] private float x;
    [SerializeField] private float y;
    [SerializeField] private float z;

    private void OnTriggerEnter(Collider other)
    {
        //other.transform.rotation = Quaternion.Euler(180, 180, 180);   //Поворачивает игрока на 180 градусов

        //transform.rotation = Quaternion.Euler(0, 0, 90);    //Повернулся вокруг центра
        if (other.gameObject.CompareTag("Player"))
            _dieClass.Die(true);
    }

    private void Update()
    {
        transform.Rotate(x, y, z);
    }
}
