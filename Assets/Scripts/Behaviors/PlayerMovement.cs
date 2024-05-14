using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private InputController _controller;
    private Rigidbody2D _rigidbody2D;

    private Vector2 _movementDirection = Vector2.zero;
    private float _speed = 5f;

    private void Awake()
    {
        _controller = GetComponent<InputController>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction *= _speed;
        _rigidbody2D.velocity = direction;
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }
}
