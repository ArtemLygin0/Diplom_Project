using UnityEngine;

public class Teleport : MonoBehaviour
{
    // 1 Указать координаты телепорта в Unity (+++)
    /*
    public Vector3 teleportPoint;
    private void OnTriggerStay(Collider other)
    {
        other.transform.position = teleportPoint;
    }
    */
    // 2 Указать на пустую точку в которую телепортируется EmptyObject(+++)
    /*
    public Transform teleportPoint;
    private void OnTriggerStay(Collider other)
    {
        other.transform.position = teleportPoint.transform.position;
    }
    */

    //3 Переместить по вектору  (Может проходить сквозь стены) (+++)    Надо добавить телепортацию на заданное растояние по точке зрения
    /*
    //Наш объект.
    public GameObject Sphere;
    //Целочисленная переменная определяющая дистанцию перемещения.
    private int S = 5;

    public void OnButtonDown()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Sphere.transform.Translate(S, 0, 0);
        }
    }
    */
    //4 Поменяться с объектом местами (C указанием объекта) (+++)
    /*
    public void Start()
    {
        [SerializeField] public Transform teleportPoint;
        public Rigidbody rb;

        var pos1 = teleportPoint.transform.position;
        var pos2 = rb.transform.position;

        var exchange = pos2;                    //Я
        rb.transform.position = pos1;           //Объект заходит в меня
        teleportPoint.transform.position = exchange;   //Я захожу в объект    
    }
   */
    //5  Поменяться с объектом местами (Через RayCast) (--)

    //Если нужен конкретный тип объекта
    private float dist = 0;
    public void Teleportation()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward * 100f, Color.yellow);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
           float dist = hit.distance;
        }

        if (dist < 3.5f)
        {
            // Телепорт на 3 блока вперёд
        }

    }
}