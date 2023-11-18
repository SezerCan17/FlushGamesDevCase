using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]
public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private FixedJoystick _joystick;
    [SerializeField] private Animator _animator;
    [SerializeField] private float _moveSpeed;

    
    private void FixedUpdate()
    {
        HandleMovement();
        HandleAnimation();
    }

    private void HandleMovement()
    {
        Vector3 movement = new Vector3(_joystick.Horizontal * _moveSpeed*-1, _rigidbody.velocity.y*-1, _joystick.Vertical * _moveSpeed*-1);
        _rigidbody.velocity = movement;

        if (HasMovementInput())
        {
            RotateCharacter();
        }
    }

    private void HandleAnimation()
    {
        _animator.SetBool("Run", HasMovementInput());
    }

    private bool HasMovementInput()
    {
        return _joystick.Horizontal != 0 || _joystick.Vertical != 0;
    }

    private void RotateCharacter()
    {
        transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
    }
}
