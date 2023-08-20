using System.Collections;
using UnityEngine;

public class SpawnPoints : MonoBehaviour
{
    [SerializeField] private GameObject[] enemy;        // ������ ��������
    [SerializeField] private Transform[] spawnPoint;    // ������ �������
    [SerializeField] private float waveWait = 2;        // ����� ����� ������� �������

    private void Start()
    {
        StartCoroutine(SpawnWave());
    }
    
    IEnumerator SpawnWave()
    {
        while (true)    // ���� ����� ����� ����� ��������� ���� (���� ��� ����������� ����)
        {
            Instantiate(enemy[Random.Range(0, enemy.Length)],                               //��������� ������
                        spawnPoint[Random.Range(0, spawnPoint.Length)].transform.position,  //��������� �������
                        Quaternion.identity);

            yield return new WaitForSeconds(waveWait);
        }
    }
}
