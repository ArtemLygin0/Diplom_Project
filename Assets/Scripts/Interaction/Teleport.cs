using UnityEngine;

public class Teleport : MonoBehaviour
{
    // 1 ������� ���������� ��������� � Unity (+++)
    /*
    public Vector3 teleportPoint;
    private void OnTriggerStay(Collider other)
    {
        other.transform.position = teleportPoint;
    }
    */
    // 2 ������� �� ������ ����� � ������� ��������������� EmptyObject(+++)
    /*
    public Transform teleportPoint;
    private void OnTriggerStay(Collider other)
    {
        other.transform.position = teleportPoint.transform.position;
    }
    */

    //3 ����������� �� �������  (����� ��������� ������ �����) (+++)    ���� �������� ������������ �� �������� ��������� �� ����� ������
    /*
    //��� ������.
    public GameObject Sphere;
    //������������� ���������� ������������ ��������� �����������.
    private int S = 5;

    public void OnButtonDown()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Sphere.transform.Translate(S, 0, 0);
        }
    }
    */
    //4 ���������� � �������� ������� (C ��������� �������) (+++)
    /*
    public void Start()
    {
        [SerializeField] public Transform teleportPoint;
        public Rigidbody rb;

        var pos1 = teleportPoint.transform.position;
        var pos2 = rb.transform.position;

        var exchange = pos2;                    //�
        rb.transform.position = pos1;           //������ ������� � ����
        teleportPoint.transform.position = exchange;   //� ������ � ������    
    }
   */
    //5  ���������� � �������� ������� (����� RayCast) (--)

    //���� ����� ���������� ��� �������
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
            // �������� �� 3 ����� �����
        }

    }
}