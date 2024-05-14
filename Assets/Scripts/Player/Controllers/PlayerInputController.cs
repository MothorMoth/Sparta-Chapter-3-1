using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : InputController
{
    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;

        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        Vector2 mousePos = value.Get<Vector2>();
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
        Vector2 aimDirection = (worldPos - (Vector2)transform.position).normalized;

        CallLookEvent(aimDirection);
    }
}
