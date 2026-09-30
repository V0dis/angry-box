using UnityEngine;

public class TargetTracker
{
    private Transform _transform;
    private Transform _target;

    public TargetTracker(Transform transform, Transform target)
    {
        _transform = transform;
        _target = target;
    }
    
    public Vector3 GetTargetPosition() => 
        _target == null 
            ? _transform.position
            : _target.position;
}

