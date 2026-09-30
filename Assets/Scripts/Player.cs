using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Movement _movement;
    
    private Input _input;

    private void Awake()
    {
        _input = new Input();
        _input.Player.Enable();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        _movement.Move(_input.Player.Move.ReadValue<Vector2>());
    }
    

    public void OnDestroy()
    {
        _input.Player.Disable();
    }
}
