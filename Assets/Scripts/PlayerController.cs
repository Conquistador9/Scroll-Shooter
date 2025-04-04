using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Settings")]
    [Range(0,10)]
    [SerializeField] private float _runSpeed, _jump;
    private PlayerShoot _playerShoot;
    private PlayerAnimations _anims;
    private Rigidbody2D _rb;
    private PlayerRevers _playerRevers;
    private bool _isGrounded = true;
    private bool _isAir = false;

    private void Start()
    {
        _playerShoot = GetComponent<PlayerShoot>();
        _rb = GetComponent<Rigidbody2D>();
        _playerRevers = GetComponent<PlayerRevers>();
        _anims = GetComponent<PlayerAnimations>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");

        if(horizontal > 0)
        {
            _playerRevers.ReversRight();
            _playerShoot.EnergySpriteRight();
        }
        else if(horizontal < 0)
        {
            _playerRevers.ReversLeft();
            _playerShoot.EnergySpriteLeft();
        } 

        if (Mathf.Abs(_rb.velocity.magnitude) > 0.01f && _isGrounded) _anims.Walk();
        else
        {
            _anims.Idle();
            _anims.JumpOf();
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
            _anims.JumpOf();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        _isGrounded = false;
        _isAir = true;
    }

    private void CheckAir() 
    {
        if (_isAir) _anims.Jump();
    }
}