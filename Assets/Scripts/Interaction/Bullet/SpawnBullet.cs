using UnityEngine;
//Механика
//1) Пуля летит прямо +++ 
//2) Если попадает в игрока, то вызывает метод DIE +++
//3) Если в destructible object, то объект пропадает, вместе с пулей. +++
//4) Если пуля никуда не попадает, то через время пропадает +++

public class SpawnBullet : MonoBehaviour
{
    [SerializeField] public GameObject Bullets;
    [SerializeField] private Transform shotSpawn;

    private float spawn_time = 3f;
    private float t = 0;        

    private void Update()
    {
        t += Time.deltaTime;
        if (t >= spawn_time)    //Каждый такт спавна
        {
            GameObject bullet = Instantiate(Bullets, shotSpawn.transform.position, shotSpawn.rotation);
            Destroy(bullet, 8f);   //Уничтожить через время
            t = 0;
        }
    }
}