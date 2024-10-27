using UnityEngine;

[RequireComponent(typeof(EntityMove))]
public class PlayerController : MonoBehaviour
{
    private EntityMove _move;

    private Vector2 _playerMoveInputs;

    private void Awake()
    {
        _move = GetComponent<EntityMove>();

        GetComponent<MeshRenderer>().enabled = false;

        PlayerInputs.OnMove += Move;
    }

    private void Update()
    {
        _move.Move(_playerMoveInputs);
    }

    private void OnDestroy()
    {
        PlayerInputs.OnMove -= Move;
    }

    private void Move(Vector2 inputs) => _playerMoveInputs = inputs;
}