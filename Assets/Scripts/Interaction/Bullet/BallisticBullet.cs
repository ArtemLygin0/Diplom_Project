using System;
using UnityEngine;

public class BallisticBullet : MonoBehaviour
{
    [SerializeField] private Transform _spawnTransform;
    [SerializeField] private Transform _targetTransform;
    [Range(0f, 90f)] [SerializeField] private float _angleInDegrees;
    [SerializeField] private GameObject _bullet;
    private float g = Physics.gravity.y;

    private void Update()
    {
        _spawnTransform.localEulerAngles = new Vector3(-_angleInDegrees, 0f, 0f);

        if (Input.GetMouseButtonDown(0))
        {
            Shot();
        }
    }

    public void Shot()
    {
        Vector3 fromTo = _targetTransform.position - transform.position;
        Vector3 fromToXZ = new Vector3(fromTo.x, 0f, fromTo.z);

        transform.rotation = Quaternion.LookRotation(fromToXZ, Vector3.up);

        float x = fromToXZ.magnitude;
        float y = fromTo.y;

        float _angleInRadians = _angleInDegrees * Mathf.PI / 180;

        float v2 = (g * x * x) / (2 * (y - Mathf.Tan(_angleInRadians) * x) * Mathf.Pow(Mathf.Cos(_angleInRadians), 2));
        float v = Mathf.Sqrt(Mathf.Abs(v2));

        GameObject newBullet = Instantiate(_bullet, _spawnTransform.position, Quaternion.identity);
        newBullet.GetComponent<Rigidbody>().velocity = _spawnTransform.forward * v;
        Destroy(newBullet, 5f);
    }
}
