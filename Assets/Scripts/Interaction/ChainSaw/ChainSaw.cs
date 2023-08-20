using DG.Tweening;
using UnityEngine;

public class ChainSaw : MonoBehaviour
{
    [SerializeField] private DieClass _dieClass;
    [SerializeField] private Transform[] _pos = new Transform[] { }; 

    [SerializeField] private float _speed = 3f;
    [SerializeField] private Ease _ease = Ease.Linear;

    private Transform _currentPos;
    private bool _isMoving = false;
    private void Start()
    {
        _currentPos = _pos[0];
        transform.position = _pos[0].position;
    }
    public void Move()
    {
        if (_isMoving) return;
        _isMoving = true;
         
        int i = 0;
        for (; i < _pos.Length; i++)
            if (_currentPos == _pos[i])
                break;

        if (i == _pos.Length - 1)
            i = 0;
        else
            i++;

        MoveToPos(_pos[i]);
    }
    public void Update()
    {
        if (!_isMoving) Move();
    }

    private void MoveToPos(Transform targetPos)
    {
        var distance = Vector3.Distance(transform.position, targetPos.position);
        var duration = distance / _speed;

        _currentPos = targetPos;
        transform
            .DOMove(targetPos.position, duration)
            .SetEase(_ease)
            .OnComplete(OnComplete);
    }

    private void OnComplete()
    {
        _isMoving = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            _dieClass.Die(true);
    }
}