using DG.Tweening;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    //[SerializeField] private PlayerController _playerController;
    [SerializeField] private Transform _pos1;
    [SerializeField] private Transform _pos2;
    [SerializeField] private float _speed = 1f;
    [SerializeField] private Ease _ease = Ease.Linear;

    private Transform _currentPos;
    private bool _isMoving = false;

    private void Start()
    {
        _currentPos = _pos1;
        transform.position = _pos1.position;
    }
    public void Move()
    {
        if (_isMoving) return;
        _isMoving = true;

        //можно заменить одной стррочкой
        //MoveToPos(_currentPos == _pos1 ? _pos2 : _pos1);
        if (_currentPos == _pos1)
        {
            MoveToPos(_pos2);
        }
        else
        {
            MoveToPos(_pos1);
        }
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
            //.SetSpeedBased(true) //у дотвин есть внутрянняя перегрузка, шаманить самом с duration не нужно
            .OnComplete(OnComplete);
    }

    private void OnComplete()
    {
        _isMoving = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.SetParent(gameObject.transform);
        PlayerController.speed = 2.5f;//магические числа, статика
    }
    
    public void OnTriggerExit(Collider other)
    {
        other.gameObject.transform.SetParent(null);
        PlayerController.speed = 10f;
    }
}