using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    
    private CharacterController _controller;
    private Vector3 _gravity;

    private void Start()
    {
        _controller = GetComponent<CharacterController>();
        _gravity = Physics.gravity;
    }

    private void Update()
    {
        _controller.Move(_gravity * Time.deltaTime);
    }

    public void Move(Vector2 input)
    {
        Vector3 direction = new Vector3(input.x, 0, input.y).normalized;
        
        _controller.Move(direction * (_speed * Time.deltaTime));
        
    }

    public void MoveTo(Vector3 target)
    {
        Vector3 direction = (target - transform.position).normalized;
        
        _controller.Move(direction * (_speed * Time.deltaTime));
    }
}
