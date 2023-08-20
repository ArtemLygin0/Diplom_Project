using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomSpawn : MonoBehaviour
{
    [SerializeField] private GameObject[] bullets;  // ������� ����
    [SerializeField] private Transform shotSpawn;   // ����� ������
    [SerializeField] private Vector3 spawnValues;   // ���������� �� ����� ������
    [SerializeField] private int bulletsCount;      // ���������� ����
    [SerializeField] private float spawnWait;       // ���� ��������� ����
    [SerializeField] private float startWait;       // ����� ����� ������� �����
    [SerializeField] private float waveWait;        // ����� ����� ����� waveWait ���

    private void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);

        while (true)    // ���� ����� ����� ����� ��������� ���� (���� ��� ����������� ����)
        {
            for (int i = 0; i < bulletsCount; i++)
            {
                Vector3 spawnPosition = new Vector3(spawnValues.x, spawnValues.y, spawnValues.z);   //+++ ���������� �� ������ ���������
                Quaternion spawnRotation = Quaternion.identity;                                     //--- ���������� �� ������ ��������

                GameObject bullet = bullets[Random.Range(0, bullets.Length)];

                //Instantiate(bullet, spawnPosition, spawnRotation);
                GameObject clone_Bullet = Instantiate(bullet, shotSpawn.transform.position + spawnPosition, shotSpawn.rotation);    // ---GameObject ��� ��������

                yield return new WaitForSeconds(Random.Range(0.5f, spawnWait));     // ������� �� ������� �������� ����
            }
            yield return new WaitForSeconds(waveWait);
        }
    }
}