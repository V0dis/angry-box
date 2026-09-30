using UnityEngine;

public class Bot : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Movement _movement;
    [SerializeField] private float _minDistance = 1f;
    
    private Transform _transform;
    private float _sqrMinDistance;
    private TargetTracker _targetTracker;

    private void Start()
    {
        _transform = transform;
        _targetTracker = new TargetTracker(_transform, _target);
        _sqrMinDistance = _minDistance * _minDistance;
    }

    private void Update()
    {
        if (IsCloseEnough == false) 
            Move();
    }

    private void Move()
    {
        _movement.MoveTo(_targetTracker.GetTargetPosition());
    }

    private bool IsCloseEnough => 
        _sqrMinDistance > (_target.position - _transform.position).sqrMagnitude;
}
