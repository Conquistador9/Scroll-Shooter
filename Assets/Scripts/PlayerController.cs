using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Settings")]
    [Range(0,10)]
    [SerializeField] private float _runSpeed, _liftSpeed, _jump;
    private PlayerState _playerState;
    private Rigidbody2D _rb;
    private PlayerRevers _playerRevers;
    private bool _isGrounded = true;
    private bool _isAir = false;

    private void Start()
    {
        _playerState = GetComponent<PlayerState>();
        _rb = GetComponent<Rigidbody2D>();
        _playerRevers = GetComponent<PlayerRevers>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        if(horizontal > 0)
        {
            _playerRevers.ReversRight();
        }
        else if(horizontal < 0)
        {
            _playerRevers.ReversLeft();
        } 
/*
        if (_rb.velocity.magnitude <= 0.01f && _isGrounded)
        {
            _playerState.Idle();
        }
*/
        if (Mathf.Abs(_rb.velocity.magnitude) > 0.01f && _isGrounded)
        {
            _playerState.Run();
        }
        else
        {
            _playerState.Idle();
        }
            Jump();
        CheckAir();
    }

    private void FixedUpdate()
    {
        _rb.velocity = new Vector2((Input.GetAxisRaw("Horizontal") * _runSpeed), _rb.velocity.y);
    }

    public void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _rb.AddForce(Vector2.up * _jump, ForceMode2D.Impulse);
            _isGrounded = false;
            _isAir = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            _isGrounded = true;
            _isAir = false;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        _isGrounded = false;
        _isAir = true;
    }

    private void CheckAir()
    {
        if (_isAir)
        {
            _playerState.Jump();
        }
    }
}