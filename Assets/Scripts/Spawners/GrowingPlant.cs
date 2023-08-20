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

    //Механика
    //1) Растёт после смерти игрока (Передаёт из PlayerController)
    //2) Можно уничтожить пулями
    //3) Если упирается в объект, нерастёт

    //Пишу функцию где узнаю из PlayerController что он дохлый, если дохлый то растение растёт
    private void Update()
    {
        if (playerDead)    //Каждый такт спавна
        {
            GameObject plant = Instantiate(Plant, transform.position, Quaternion.identity);
            playerDead = false;

            count++;
            //Destroy(plant);   //Уничтожить растение
        }
        else
            transform.Translate(new Vector3(0, 0, speed * count));  //если помер то прибавляется блок в сторону, можно во все + каждый раз не спавнится в одном месте
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Уничтожить объект
        if (collision.gameObject.tag == "Destructible") // Если пуля попадает в растение, то оно пропадает
        {
            Destroy(gameObject);
        }
    }
    */
}
