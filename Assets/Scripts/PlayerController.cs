using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private GameObject _playerIdle;
    [SerializeField] private GameObject _playerRun;
    [SerializeField] private GameObject _playerLadder;

    [Header("Settings")]
    [Range(0,200)]
    [SerializeField] private float _runSpeed, _liftSpeed, _jump;
    private Rigidbody2D _rb;
    private PlayerRevers _playerRevers;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _playerRevers = GetComponent<PlayerRevers>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if(horizontal > 0)
        {
            _playerRevers.ReversRight();
        }
        else if(horizontal < 0)
        {
            _playerRevers.ReversLeft();
        }

        if(vertical > 0)
        {
            _playerIdle.SetActive(false);
            _playerRun.SetActive(false);
            _playerLadder.SetActive(true);
        }

        if (_rb.velocity.magnitude == 0f && _rb.angularVelocity == 0f)
        {
            _playerIdle.SetActive(true);
            _playerRun.SetActive(false);
        }
        else
        {
            _playerIdle.SetActive(false);
            _playerRun.SetActive(true);
        }

        Debug.Log(_rb.velocity.magnitude);
    }

    private void FixedUpdate()
    {
        _rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * _runSpeed, Input.GetAxisRaw("Vertical") * _liftSpeed);
        Jump();
    }

    public void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.velocity = new Vector2(_rb.velocity.x, _jump);
        }
    }
}