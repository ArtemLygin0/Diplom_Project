using System.Collections;
using UnityEngine;

public class SpawnPoints : MonoBehaviour
{
    [SerializeField] private GameObject[] enemy;        // Массив префабов
    [SerializeField] private Transform[] spawnPoint;    // Массив Позиций
    [SerializeField] private float waveWait = 2;        // Время между спавном объеков

    private void Start()
    {
        StartCoroutine(SpawnWave());
    }
    
    IEnumerator SpawnWave()
    {
        while (true)    // Пока игрок живой будут спавнится пули (пока что бесконечный цикл)
        {
            Instantiate(enemy[Random.Range(0, enemy.Length)],                               //Рандомный префаб
                        spawnPoint[Random.Range(0, spawnPoint.Length)].transform.position,  //Рандомная позиция
                        Quaternion.identity);

            yield return new WaitForSeconds(waveWait);
        }
    }
}
