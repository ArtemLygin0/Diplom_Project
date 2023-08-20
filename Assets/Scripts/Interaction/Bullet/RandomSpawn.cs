using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomSpawn : MonoBehaviour
{
    [SerializeField] private GameObject[] bullets;  // Префабы пуль
    [SerializeField] private Transform shotSpawn;   // Точка спавна
    [SerializeField] private Vector3 spawnValues;   // Отклонение от точки спавна
    [SerializeField] private int bulletsCount;      // Количество пуль
    [SerializeField] private float spawnWait;       // Цикл появления пуль
    [SerializeField] private float startWait;       // Время перед началом волны
    [SerializeField] private float waveWait;        // Новая волна через waveWait сек

    private void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);

        while (true)    // Пока игрок живой будут спавнится пули (пока что бесконечный цикл)
        {
            for (int i = 0; i < bulletsCount; i++)
            {
                Vector3 spawnPosition = new Vector3(spawnValues.x, spawnValues.y, spawnValues.z);   //+++ Отклонение от начала координат
                Quaternion spawnRotation = Quaternion.identity;                                     //--- Отклонение от начала поворота

                GameObject bullet = bullets[Random.Range(0, bullets.Length)];

                //Instantiate(bullet, spawnPosition, spawnRotation);
                GameObject clone_Bullet = Instantiate(bullet, shotSpawn.transform.position + spawnPosition, shotSpawn.rotation);    // ---GameObject для удаления

                yield return new WaitForSeconds(Random.Range(0.5f, spawnWait));     // Разброс по времени создания пуль
            }
            yield return new WaitForSeconds(waveWait);
        }
    }
}