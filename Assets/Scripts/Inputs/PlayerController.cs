using Unity.Cinemachine;
using UnityEngine;

[RequireComponent(typeof(EntityMove))]
public class PlayerController : MonoBehaviour
{
    private EntityMove _move;

    private Vector2 _playerMoveInputs;
    private Vector2 _playerLookInputs;
    bool _isMoving = false;
    bool _isLooking = false;

    private void Awake()
    {
        _move = GetComponent<EntityMove>();

        PlayerInputs.OnMove += Move;
        PlayerInputs.OnLook += Look;
    }

    private void OnDestroy()
    {
        PlayerInputs.OnMove -= Move;
        PlayerInputs.OnLook -= Look;
    }

    private void Move(Vector2 inputs, bool isMoving)
    {
        _playerMoveInputs = inputs;
        _isMoving = isMoving;
    }

    private void Look(Vector2 inputs)
    {
        _playerLookInputs = inputs;
    }

    private void Update()
    {
        if (_isMoving) _move.Move(_playerMoveInputs);
        _move.Rotate(_playerLookInputs);
    }
}