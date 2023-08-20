using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F_2_ollowBullet : MonoBehaviour
{
    // Смотрит на объект и поворачивается
    public GameObject target;
    public float speed;
    void Update()
    {
        transform.LookAt(target.transform.position);
        transform.position = Vector3.Lerp(transform.position, target.transform.position, speed * Time.deltaTime);
    }
}