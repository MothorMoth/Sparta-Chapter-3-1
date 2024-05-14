using UnityEngine;

public class PlayerAimRotation : MonoBehaviour
{
    [SerializeField]private SpriteRenderer _playerRenderer;
    private InputController _controller;

    private void Awake()
    {
        _controller = GetComponent<InputController>();
    }

    private void Start()
    {
        _controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        _playerRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
}
