using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Название не по конвенции, Нижние подчеркивание лишнии
public class F_2_ollowBullet : MonoBehaviour
{
    // ������� �� ������ � ��������������
    public GameObject target;
    public float speed;
    void Update()
    {
        transform.LookAt(target.transform.position);
        transform.position = Vector3.Lerp(transform.position, target.transform.position, speed * Time.deltaTime);
    }
}