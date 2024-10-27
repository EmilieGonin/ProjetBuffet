using UnityEngine;

[RequireComponent(typeof(EntityMove))]
public class PlayerController : MonoBehaviour
{
    private EntityMove _move;

    private Vector2 _playerMoveInputs;
    private Vector2 _playerLookInputs;

    private void Awake()
    {
        _move = GetComponent<EntityMove>();

        PlayerInputs.OnMove += Move;
        PlayerInputs.OnLook += Look;
    }

    private void Update()
    {
        _move.Move(_playerMoveInputs);
        _move.Rotate(_playerLookInputs);
    }

    private void OnDestroy()
    {
        PlayerInputs.OnMove -= Move;
        PlayerInputs.OnLook -= Look;
    }

    private void Move(Vector2 inputs) => _playerMoveInputs = inputs;
    private void Look(Vector2 inputs) => _playerLookInputs = inputs;
}