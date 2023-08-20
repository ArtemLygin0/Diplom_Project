using UnityEngine;

public class BlueLaser : MonoBehaviour
{
    [SerializeField] private DieClass _dieClass;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            _dieClass.Die(true);
        }
    }
}

//���������� � ������� ����� (��������� / �������������)
/*
    if (!istrigger) 
        GetComponent<CapsuleCollider>().isTrigger = !istrigger;
*/
