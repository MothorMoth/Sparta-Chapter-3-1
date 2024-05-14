using UnityEngine;

public class PlayerAnimationController : AnimationController
{
    private static readonly int _isWalking = Animator.StringToHash("isWalking");
    private readonly float _magnituteThreshold = 0.5f;

    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 vector)
    {
        _animator.SetBool(_isWalking, vector.magnitude > _magnituteThreshold);
    }
}
