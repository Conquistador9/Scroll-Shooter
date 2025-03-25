using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    [SerializeField] private GameObject _playerIdle, _playerRun, _playerJump, _playerShoot;

    public void Idle()
    {
        _playerIdle.SetActive(true);
        _playerRun.SetActive(false);
        _playerJump.SetActive(false);
    }

    public void Run()
    {
        _playerRun.SetActive(true);
        _playerIdle.SetActive(false);
        _playerJump.SetActive(false);
    }

    public void Jump()
    {
        _playerJump.SetActive(true);
        _playerIdle.SetActive(false);
        _playerRun.SetActive(false);
    }

    public void Shoot()
    {
        _playerShoot.SetActive(true);
        _playerIdle.SetActive(false);
        _playerRun.SetActive(false);
        _playerJump.SetActive(false);
    }

    public void ShootOff()
    {
        _playerShoot.SetActive(false);
    }
}