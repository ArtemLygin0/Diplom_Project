using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowingPlant : MonoBehaviour
{
    /*
    [SerializeField] public GameObject Plant;
    private bool playerDead = false;
    private float speed = 1f;
    private int count = 0;
    private PlayerController _playerController;

    //��������
    //1) ����� ����� ������ ������ (������� �� PlayerController)
    //2) ����� ���������� ������
    //3) ���� ��������� � ������, �������

    //���� ������� ��� ����� �� PlayerController ��� �� ������, ���� ������ �� �������� �����
    private void Update()
    {
        if (playerDead)    //������ ���� ������
        {
            GameObject plant = Instantiate(Plant, transform.position, Quaternion.identity);
            playerDead = false;

            count++;
            //Destroy(plant);   //���������� ��������
        }
        else
            transform.Translate(new Vector3(0, 0, speed * count));  //���� ����� �� ������������ ���� � �������, ����� �� ��� + ������ ��� �� ��������� � ����� �����
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        //���������� ������
        if (collision.gameObject.tag == "Destructible") // ���� ���� �������� � ��������, �� ��� ���������
        {
            Destroy(gameObject);
        }
    }
    */
}
