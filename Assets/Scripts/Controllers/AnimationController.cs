using UnityEngine;

public class AnimationController : MonoBehaviour
{
    protected InputController _controller;
    protected Animator _animator;

    protected virtual void Awake()
    {
        _controller = GetComponent<InputController>();
        _animator = GetComponentInChildren<Animator>();
    }
}
