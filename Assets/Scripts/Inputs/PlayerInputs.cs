using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputs : MonoBehaviour
{
    public static Action<Vector2> OnMove;
    //public static Action<Vector2> OnLook;

    public void Move(InputAction.CallbackContext context) => OnMove?.Invoke(context.ReadValue<Vector2>());
    //public void Look(InputAction.CallbackContext context) => OnLook?.Invoke(context.ReadValue<Vector2>());
}