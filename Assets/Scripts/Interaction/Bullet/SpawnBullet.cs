using UnityEngine;
//��������
//1) ���� ����� ����� +++ 
//2) ���� �������� � ������, �� �������� ����� DIE +++
//3) ���� � destructible object, �� ������ ���������, ������ � �����. +++
//4) ���� ���� ������ �� ��������, �� ����� ����� ��������� +++

public class SpawnBullet : MonoBehaviour
{
    [SerializeField] public GameObject Bullets;
    [SerializeField] private Transform shotSpawn;

    private float spawn_time = 3f;
    private float t = 0;        

    private void Update()
    {
        t += Time.deltaTime;
        if (t >= spawn_time)    //������ ���� ������
        {
            GameObject bullet = Instantiate(Bullets, shotSpawn.transform.position, shotSpawn.rotation);
            Destroy(bullet, 8f);   //���������� ����� �����
            t = 0;
        }
    }
}